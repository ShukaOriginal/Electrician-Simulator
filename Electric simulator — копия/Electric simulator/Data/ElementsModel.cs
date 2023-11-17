using Electric_simulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_simulator.Data
{
    public class PropertiesObject
    {
        public string name { get; set; }

        public int type { get; set; }

        public int MaxProduction { get; set; }

        public double Production { get; set; } = 0;

        public double[,] GrowthRate { get; set; } = new double[,] { { }, { } }; //коэфицент роста мощности в 1 тик (Production + GrowRate)

        public double Consumption { get; set; } = 0;//потребление

        public double MaxConsumption { get; set; } = 0;//максимальное потребление

        public int StandartPower { get; set; } = 0;//Начальное потребление/выробатка

        public bool Generator { get; set; }

        public int id { get; set; }
    }

    public class ElementsModel 
    {

        public int id = 1;

        public List<PropertiesObject> StandartElements = new List<PropertiesObject>() {
            new PropertiesObject
            {
                name = "Угольная ТЭЦ",
                type = 1,
                MaxProduction = 200,
                Production = 0,
                GrowthRate =  new double[,] {
                    {0, 40, 100, 165, 180, 200}, 
                    {0.2, 0.4, 0.65, 0.47, 0.25, 0.25}
                },
                Consumption = 0,
                MaxConsumption = 0,
                StandartPower = 170,
                Generator = true,
                id = 0,
            },
            new PropertiesObject
            {
                name = "Нефтенная ТЭЦ",
                type = 2,
                MaxProduction = 250,
                Production = 0,
                GrowthRate =  new double[,] {
                    {0, 70, 100, 165, 200, 250},
                    {0.1, 0.25, 0.4, 0.5, 0.4 ,0.4}
                },
                Consumption = 0,
                MaxConsumption = 0,
                StandartPower = 200,
                Generator = true,
                id = 0,
            },
            new PropertiesObject
            {
                name = "Газо-турбинная станция",
                type = 3,
                MaxProduction = 120,
                Production = 0,
                GrowthRate =  new double[,] {
                    {0, 40, 70, 100, 120},
                    {0.5, 0.7, 1, 1.4, 1.4}
                },
                Consumption = 0,
                MaxConsumption = 0,
                StandartPower = 80,
                Generator = true,
                id = 0,
            },
            new PropertiesObject
            {
                name = "Жилой сектор",
                type = 11,
                MaxProduction = 0,
                Production = 0,
                //GrowthRate = 1,
                Consumption = 30,
                MaxConsumption = 50,
                StandartPower = 23,
                Generator = false,
                id = 0,
            },

        };

        public List<PropertiesObject> CreatedElements = new List<PropertiesObject>();



        public void AddElement(bool generator, int numberElement, string name,
            int type, int powerElements, double[,] growthRate)
        {
            if (generator)
            {
                for (int i = 1; i <= numberElement; i++)
                {
                    //MessageBox.Show("for работает");
                    CreatedElements.Add(new PropertiesObject
                    {
                        Generator = generator,
                        name = name,
                        type = type,
                        MaxProduction = powerElements,
                        Production = 0,
                        GrowthRate = growthRate,
                        id = id,
                    });
                    id++;
                }
            }
            else
            {
                for (int i = 1; i <= numberElement; i++)
                {
                    CreatedElements.Add(new PropertiesObject
                    {
                            Generator = generator,
                            name = name,
                            type = type,
                            MaxConsumption = powerElements,
                            Consumption = 0,
                            GrowthRate = growthRate,
                            id = id,
                        
                    });
                    id++;
                }
            }
        }



    }
}
