using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electric_simulator.Model
{
    public class TimeModel
    {
        public SimulationModel Model = new SimulationModel();


        public int SecondTimer { get; set; } = 1;

        public static int TimeSpeed { get; set; } = 0;

        public static TimeSpan TimeInSimulation = new TimeSpan(7, 0, 0);

        public static bool NewTick { get; set; }

        public int i { get; set; } = 11 / 1;

        public void SimulationTick()
        {
            Math.Round(Convert.ToDouble(i));
            if (TimeSpeed != 0)
            {
                if (SecondTimer >= i)
                {
                    i = i + (11 / TimeSpeed);
                    TimeInSimulation = TimeInSimulation + new TimeSpan(0, 1, 0);
                    NewTick = true;
                    Model.Simulation();
                }
                else
                {
                    NewTick = false;
                }
                if (SecondTimer >= 11)
                {
                    SecondTimer = 1;
                    i = (11 / TimeSpeed);
                }
                SecondTimer++;
            }
        }

    }
}
