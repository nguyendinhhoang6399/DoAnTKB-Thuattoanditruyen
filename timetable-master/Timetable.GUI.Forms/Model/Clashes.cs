using System;
using System.Collections.Generic;
using System.Text;

namespace Timetable.GUI.Forms.Model
{
    public class Clashes
    {
        public int clashRoom { set; get; }
        public int clashProf { set; get; }
        public int clashRoomCapacity { set; get; }
        public int clashTimeStart { set; get; }
        public int clashSesionsGroup { set; get; }
        public int clashBusyRoom { set; get; }
        public int clashBusyProf { set; get; }
        public int clashTGN { set; get; } //teaching group numbers

        public int sumClash { set; get; }

        public double fitnessBindingRoom(double Coe)
        {
            double fit = (double)((Coe + this.clashRoom) / Coe);
            return Math.Log10(fit);
        }
        public double fitnessBindingProf(double Coe)
        {
            double fit = (double)((Coe + this.clashProf) / Coe);
            return Math.Log10(fit);
        }
        public double fitnessBindingCapacity(double Coe)
        {
            double fit = (double)((Coe + this.clashRoomCapacity) / Coe);
            return Math.Log10(fit);
        }
        public double fitnessBindingTimeStart(double Coe)
        {
            double fit = (double)((Coe + this.clashTimeStart) / Coe);
            return Math.Log10(fit);
        }
        public double fitnessBindingSesion(double Coe)
        {
            double fit = (double)((Coe + this.clashSesionsGroup) / Coe);
            return Math.Log10(fit);
        }
        public double fitnessBindingTGN(double Coe)
        {
            double fit = (double)((Coe + this.clashTGN) / Coe);
            return Math.Log10(fit);
        }
        public double fitnessBindingBusyRoom(double Coe)
        {
            double fit = (double)((Coe + this.clashBusyRoom) / Coe);
            return Math.Log10(fit);
        }
        public double fitnessBindingBusyProf(double Coe)
        {
            double fit = (double)((Coe + this.clashBusyProf) / Coe);
            return Math.Log10(fit);
        }

    }
}
