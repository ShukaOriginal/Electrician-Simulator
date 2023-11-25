using Electric_simulator.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electric_simulator.Model
{


    public class SimulationModel
    {
        public static double TotalProduction { get; set; } = 0;

        public static double TotalConsumption { get; set; } = 0;



        public void Simulation()
        {
            foreach (var element in ElementsModel.CreatedElements)
            {
                if (element.generator == true)
                {
                    for (var i = 0; i <= element.growthRate.Length; i++)
                    {
                        if (element.production >= element.growthRate[0, i] && element.production <= element.growthRate[0, i + 1] && element.production <= element.targetProduction)
                        {
                            if (element.production + element.growthRate[1, i] <= element.maxProduction)
                            {
                                TotalProduction = TotalProduction - element.production;
                                element.production = element.production + element.growthRate[1, i];
                                TotalProduction = TotalProduction + element.production;
                            }
                            else
                            {
                                TotalProduction = TotalProduction - element.production;
                                element.production = element.maxProduction;
                                TotalProduction = TotalProduction + element.production;
                            }
                            element.production = Math.Round(element.production, 1, MidpointRounding.ToEven);
                            break;
                        }
                    }
                }
                else
                {
                    Random rnd = new Random();

                    if (TimeModel.TimeInSimulation >= element.refreashTime)
                    {
                        for (int e = 0; e < element.growthRate.Length - 1; e++)
                        {
                            element.growthRate[0, e] = element.growthRate[0, e + 1];
                        }
                        var i = element.growthRate.Length - 1;

                        element.growthRate[0, i] = rnd.Next((int)Math.Round(element.growthRate[0, i - 1] * element.consumptionRate), (int)Math.Round(Math.Max(element.growthRate[0, i - 1] * (element.consumptionRate + 1), element.maxConsumption)));

                        //var a = "ГИБОН ПОГАНЫЙ";

                        TotalConsumption = TotalConsumption - element.consumption;
                        element.consumption = element.growthRate[0, 0];
                        TotalConsumption = TotalConsumption + element.consumption;

                        element.refreashTime = TimeModel.TimeInSimulation + element.intervalRefreashTime;
                    }
                }
                //AAAAAAAAAAAAAAAAAAAAA
            }
        }
    }
}
