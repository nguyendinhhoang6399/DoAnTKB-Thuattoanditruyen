using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.GUI.Forms.Model;

namespace Timetable.GUI.Forms.GA
{
    public class GeneticAlgorithm
    {
        private int populationSize;
        private double mutationRate;
        private double crossoverRate;
        private int elitismCount;
        protected int tournamentSize;
        private double roomCoe;
        private double profCoe;
        private double capacityRoomCoe;
        private double timeStartCoe;
        private double busyRoomCoe;
        private double busyProfCoe;
        private double sessionGroupCoe;
        private double tgnCoe;

        public Clashes clashes { set; get; }

        public double RoomCoe { get => roomCoe; set => roomCoe = value; }
        public double ProfCoe { get => profCoe; set => profCoe = value; }
        public double CapacityRoomCoe { get => capacityRoomCoe; set => capacityRoomCoe = value; }
        public double TimeStartCoe { get => timeStartCoe; set => timeStartCoe = value; }
        public double SessionGroupCoe { get => sessionGroupCoe; set => sessionGroupCoe = value; }
        public double BusyRoomCoe { get => busyRoomCoe; set => busyRoomCoe = value; }
        public double BusyProfCoe { get => busyProfCoe; set => busyProfCoe = value; }
        public double TGNCoe { get => tgnCoe; set => tgnCoe = value; }

        public GeneticAlgorithm(int populationSize, double mutationRate, double crossoverRate, int elitismCount,
                int tournamentSize)
        {

            this.populationSize = populationSize;
            this.mutationRate = mutationRate;
            this.crossoverRate = crossoverRate;
            this.elitismCount = elitismCount;
            this.tournamentSize = tournamentSize;
        }

        /**
		 * Initialize population
		 * 
		 * @param chromosomeLength
		 *            The length of the individuals chromosome
		 * @return population The initial population generated
		 */
        public Population initPopulation(Timetable timetable)
        {
            // Initialize population
            Population population = new Population(this.populationSize, timetable);
            return population;
        }

        /**
		 * Check if population has met termination condition
		 * 
		 * @param generationsCount
		 *            Number of generations passed
		 * @param maxGenerations
		 *            Number of generations to terminate after
		 * @return boolean True if termination condition met, otherwise, false
		 */
        public bool isTerminationConditionMet(int generationsCount, int maxGenerations)
        {
            return (generationsCount > maxGenerations);
        }

        /**
		 * Check if population has met termination condition
		 *
		 * @param population
		 * @return boolean True if termination condition met, otherwise, false
		 */
        public bool isTerminationConditionMet(Population population, double fit, Timetable timetable)
        {
            if (isTerminationConditionMet(population, timetable))
                return false;
            return population.getFittest(0).getFitness() >= fit;
        }


        public bool isTerminationConditionMet(Population population, Timetable timetable)
        {
            timetable.createClasses(population.getFittest(0));
            Clashes clashes = new Clashes();
            clashes.clashRoom = timetable.calcClashes_Room();
            clashes.clashProf = timetable.calcClashes_Professor();
            clashes.clashRoomCapacity = timetable.calcClashes_CapacityRoom();
            clashes.clashTimeStart = timetable.calcClashes_TimeStart();
            clashes.clashSesionsGroup = timetable.calcClashes_Sessions();
            clashes.clashBusyProf = timetable.calcClashes_TBP();
            clashes.clashBusyRoom = timetable.calcClashes_TBR();
            clashes.clashTGN = timetable.calcClashes_TGN();

            if (clashes.clashRoom >= this.RoomCoe || clashes.clashProf >= this.ProfCoe || clashes.clashRoomCapacity >= this.CapacityRoomCoe || clashes.clashSesionsGroup >= this.SessionGroupCoe || clashes.clashTGN >= this.TGNCoe || clashes.clashTimeStart >= this.TimeStartCoe|| clashes.clashBusyProf >= this.BusyProfCoe)
                return true;
            return false;
        }

        /**
		 * Calculate individual's fitness value
		 * 
		 * @param individual
		 * @param timetable
		 * @return fitness
		 */
        public double calcFitness(Individual individual, Timetable timetable)
        {

            // Create new timetable object to use -- cloned from an existing timetable
            Timetable threadTimetable = new Timetable(timetable);
            threadTimetable.createClasses(individual);

            // Calculate fitness
            //int clashes = threadTimetable.calcClashes();
            this.clashes = new Clashes();
            this.clashes.clashRoom = threadTimetable.calcClashes_Room();
            this.clashes.clashProf = threadTimetable.calcClashes_Professor();
            this.clashes.clashRoomCapacity = threadTimetable.calcClashes_CapacityRoom();
            this.clashes.clashTimeStart = threadTimetable.calcClashes_TimeStart();
            this.clashes.clashSesionsGroup = threadTimetable.calcClashes_Sessions();
            this.clashes.clashBusyProf = threadTimetable.calcClashes_TBP();
            this.clashes.clashBusyRoom = threadTimetable.calcClashes_TBR();
            this.clashes.clashTGN = threadTimetable.calcClashes_TGN();
            // int clashBusySchedule = threadTimetable.calcClashes_BSL();

            double totalFitnessBinding = this.clashes.fitnessBindingRoom(this.RoomCoe) + this.clashes.fitnessBindingProf(this.ProfCoe) + this.clashes.fitnessBindingCapacity(this.CapacityRoomCoe) + this.clashes.fitnessBindingSesion(this.SessionGroupCoe) + this.clashes.fitnessBindingTimeStart(this.TimeStartCoe) + this.clashes.fitnessBindingTGN(this.TGNCoe) + this.clashes.fitnessBindingBusyRoom(this.BusyRoomCoe) + this.clashes.fitnessBindingBusyProf(this.BusyProfCoe);
            double fitness = 1 - Math.Log10((1.0 + totalFitnessBinding));

            individual.setFitness(fitness);

            return fitness;
        }

        /**
		 * Evaluate population
		 * 
		 * @param population
		 * @param timetable
		 */
        public void evalPopulation(Population population, Timetable timetable)
        {
            double populationFitness = 0;

            // Loop over population evaluating individuals and summing population
            // fitness
            foreach (Individual individual in population.getIndividuals())
            {
                populationFitness += this.calcFitness(individual, timetable);
            }

            population.setPopulationFitness(populationFitness);
        }

        /**
		 * Selects parent for crossover using tournament selection
		 * 
		 * Tournament selection works by choosing N random individuals, and then
		 * choosing the best of those.
		 * 
		 * @param population
		 * @return The individual selected as a parent
		 */
        public Individual selectParent(Population population)
        {
            // Create tournament
            Population tournament = new Population(this.tournamentSize);

            // Add random individuals to the tournament
            population.shuffle();
            for (int i = 0; i < this.tournamentSize; i++)
            {
                Individual tournamentIndividual = population.getIndividual(i);
                tournament.setIndividual(i, tournamentIndividual);
            }

            // Return the best
            return tournament.getFittest(0);
        }


        /**
		 * Apply mutation to population
		 * 
		 * @param population
		 * @param timetable
		 * @return The mutated population
		 */
        public Population mutatePopulation(Population population, Timetable timetable)
        {
            // Initialize new population
            Population newPopulation = new Population(population.size());
            Random rnd = new Random();
            // Loop over current population by fitness
            for (int populationIndex = 0; populationIndex < population.size(); populationIndex++)
            {
                Individual individual = population.getFittest(populationIndex);

                // Create random individual to swap genes with
                Individual randomIndividual = new Individual(timetable);

                // Loop over individual's genes
                for (int geneIndex = 0; geneIndex < individual.getChromosomeLength(); geneIndex++)
                {
                    // Skip mutation if this is an elite individual
                    if (populationIndex > this.elitismCount)
                    {
                        // Does this gene need mutation?
                        if (this.mutationRate > rnd.NextDouble())
                        {
                            // Swap for new gene
                            individual.setGene(geneIndex, randomIndividual.getGene(geneIndex));
                        }
                    }
                }

                // Add individual to population
                newPopulation.setIndividual(populationIndex, individual);
            }

            // Return mutated population
            return newPopulation;
        }

        /**
		 * Apply crossover to population
		 * 
		 * @param population The population to apply crossover to
		 * @return The new population
		 */
        public Population crossoverPopulation(Population population)
        {
            // Create new population
            Population newPopulation = new Population(population.size());
            Random rnd = new Random();
            // Loop over current population by fitness
            for (int populationIndex = 0; populationIndex < population.size(); populationIndex++)
            {
                Individual parent1 = population.getFittest(populationIndex);

                // Apply crossover to this individual?
                if (this.crossoverRate > rnd.NextDouble() && populationIndex >= this.elitismCount)
                {
                    // Initialize offspring
                    Individual offspring = new Individual(parent1.getChromosomeLength());

                    // Find second parent
                    Individual parent2 = selectParent(population);

                    // Loop over genome
                    for (int geneIndex = 0; geneIndex < parent1.getChromosomeLength(); geneIndex++)
                    {
                        // Use half of parent1's genes and half of parent2's genes
                        if (0.5 > rnd.NextDouble())
                        {
                            offspring.setGene(geneIndex, parent1.getGene(geneIndex));
                        }
                        else
                        {
                            offspring.setGene(geneIndex, parent2.getGene(geneIndex));
                        }
                    }

                    // Add offspring to new population
                    newPopulation.setIndividual(populationIndex, offspring);
                }
                else
                {
                    // Add individual to new population without applying crossover
                    newPopulation.setIndividual(populationIndex, parent1);
                }
            }

            return newPopulation;
        }
    }
}
