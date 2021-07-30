using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timetable.GUI.Forms.GA
{
    public class Population
    {
        private Individual[] population;
        private double populationFitness = -1;

        /**
		 * Initializes blank population of individuals
		 * 
		 * @param populationSize
		 *            The size of the population
		 */
        public Population(int populationSize)
        {
            // Initial population
            this.population = new Individual[populationSize];
        }

        /**
		 * Initializes population of individuals
		 * 
		 * @param populationSize The size of the population
		 * @param timetable The timetable information
		 */
        public Population(int populationSize, Timetable timetable)
        {
            // Initial population
            this.population = new Individual[populationSize];

            // Loop over population size
            for (int individualCount = 0; individualCount < populationSize; individualCount++)
            {
                // Create individual
                Individual individual = new Individual(timetable);
                // Add individual to population
                this.population[individualCount] = individual;
            }
        }


        public Population(Population cloneable)
        {
            // Initial population
            this.population = cloneable.getIndividuals();
        }
        /**
		 * Initializes population of individuals
		 * 
		 * @param populationSize
		 *            The size of the population
		 * @param chromosomeLength
		 *            The length of the individuals chromosome
		 */
        public Population(int populationSize, int chromosomeLength)
        {
            // Initial population
            this.population = new Individual[populationSize];

            // Loop over population size
            for (int individualCount = 0; individualCount < populationSize; individualCount++)
            {
                // Create individual
                Individual individual = new Individual(chromosomeLength);
                // Add individual to population
                this.population[individualCount] = individual;
            }
        }

        /**
		 * Get individuals from the population
		 * 
		 * @return individuals Individuals in population
		 */
        public Individual[] getIndividuals()
        {
            return this.population;
        }

        /**
		 * Find fittest individual in the population
		 * 
		 * @param offset
		 * @return individual Fittest individual at offset
		 */
        public Individual getFittest(int offset)
        {
            // Order population by fitness
            //          Arrays.sort(this.population, new Comparator<Individual>() {
            //          @Override

            //          public int compare(Individual o1, Individual o2)
            //          {
            //              if (o1.getFitness() > o2.getFitness())
            //              {
            //                  return -1;
            //              }
            //              else if (o1.getFitness() < o2.getFitness())
            //              {
            //                  return 1;
            //              }
            //              return 0;
            //          }
            //      });

            //// Return the fittest individual
            Array.Sort(this.population);
            return this.population[offset];
        }


        /**
         * Set population's fitness
         * 
         * @param fitness
         *            The population's total fitness
         */
        public void setPopulationFitness(double fitness)
        {
            this.populationFitness = fitness;
        }

        /**
         * Get population's fitness
         * 
         * @return populationFitness The population's total fitness
         */
        public double getPopulationFitness()
        {
            return this.populationFitness;
        }

        /**
         * Get population's size
         * 
         * @return size The population's size
         */
        public int size()
        {
            return this.population.Length;
        }

        /**
         * Set individual at offset
         * 
         * @param individual
         * @param offset
         * @return individual
         */
        public Individual setIndividual(int offset, Individual individual)
        {
            return population[offset] = individual;
        }

        /**
         * Get individual at offset
         * 
         * @param offset
         * @return individual
         */
        public Individual getIndividual(int offset)
        {
            return population[offset];
        }

        /**
         * Shuffles the population in-place
         * 
         * @param void
         * @return void
         */
        public void shuffle()
        {
            Random rnd = new Random();
            for (int i = population.Length - 1; i > 0; i--)
            {
                int index = rnd.Next(i + 1);
                Individual a = population[index];
                population[index] = population[i];
                population[i] = a;
            }
        }


        public Population(Population pop, int size, Timetable timetable)
        {
            this.population = new Individual[size];
            if (pop.size() < size)
            {
                for (int index = 0; index < size; index++)
                {
                    if (index < pop.size())
                        this.setIndividual(index, pop.getIndividual(index));
                    else
                    {
                        Individual individual = new Individual(timetable);
                        this.setIndividual(index, individual);
                    }
                }
            }
        }
    }
}
