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

        public void Simulation()
        {
            foreach (var element in ElementsModel.CreatedElements)
            {
                if (element.generator == true)
                {
                    for (var i = 0; i <= element.growthRate.Length; i++)
                    {
                        if (element.production >= element.growthRate[0, i] && element.production <= element.growthRate[0, i + 1])
                        {
                            if (element.production + element.growthRate[1, i] <= element.maxProduction)
                            {
                                element.production = element.production + element.growthRate[1, i];
                            }
                            else
                            {
                                element.production = element.maxProduction;
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
                        for (int e = 0; e <= element.growthRate.Length - 1; e++)
                        {
                            element.growthRate[e, 0] = element.growthRate[e + 1, 0];
                        }
                        var i = element.growthRate.Length;
                        element.growthRate[element.growthRate.Length, 0] = rnd.Next((int)Math.Round(element.growthRate[i - 1, 0] * element.consumptionRate), (int)Math.Round(Math.Max(element.growthRate[i - 1, 0] * (element.consumptionRate + 1), element.maxConsumption)));
                        element.refreashTime = TimeModel.TimeInSimulation + element.intervalRefreashTime;
                    }
                }
            }
        }
    }
}
