using System;
using System.Collections.Generic;

namespace Electric_simulator.Model
{
    public class PropertiesObject
    {
        public string name { get; set; }

        public int type { get; set; }//1-500: генераторы, 501-100: потребители

        public int maxProduction { get; set; }

        public double production { get; set; } = 0;

        public double targetProduction { get; set; } = 0;

        public double[,] growthRate { get; set; } = new double[,] { { }, { } }; //коэфицент роста мощности в 1 тик (Production + GrowRate)

        public double consumption { get; set; } = 0;//потребление

        public double maxConsumption { get; set; } = 0;//максимальное потребление

        public double consumptionRate { get; set; } //то как сильно может измениться потребления относительно прошлого значения

        public TimeSpan intervalRefreashTime { get; set; }//интервал между обновлениями листа потребления

        public TimeSpan refreashTime { get; set; }//время обновления

        public int standartPower { get; set; } = 0;//Начальное потребление/выробатка

        public bool generator { get; set; }

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
                maxProduction = 200,
                production = 0,
                growthRate =  new double[,] {
                    {0, 40, 100, 165, 180, 200},
                    {0.4, 0.55, 0.85, 1, 0.9, 0.9}
                },
                consumption = 0,
                maxConsumption = 0,
                standartPower = 170,
                generator = true,
                id = 0,
            },
            new PropertiesObject
            {
                name = "Нефтенная ТЭЦ",
                type = 2,
                maxProduction = 250,
                production = 0,
                growthRate =  new double[,] {
                    {0, 70, 100, 165, 200, 250},
                    {0.3, 0.48, 0.7, 0.5, 1 ,1}
                },
                consumption = 0,
                maxConsumption = 0,
                standartPower = 200,
                generator = true,
                id = 0,
            },
            new PropertiesObject
            {
                name = "Газо-турбинная станция",
                type = 3,
                maxProduction = 120,
                production = 0,
                growthRate =  new double[,] {
                    {0, 40, 70, 100, 120},
                    {0.5, 0.7, 1, 1.4, 1.4}
                },
                consumption = 0,
                maxConsumption = 0,
                standartPower = 80,
                generator = true,
                id = 0,
            },
            new PropertiesObject
            {
                name = "Жилой сектор",
                type = 501,
                maxProduction = 0,
                production = 0,
                growthRate =  new double[,] {
                    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, //потребление меняется каждые 30 минут
                },
                consumption = 30,
                maxConsumption = 50,
                consumptionRate = 0.5,
                intervalRefreashTime = new TimeSpan(0, 30, 0),
                refreashTime = new TimeSpan(0, 0, 0),
                standartPower = 37,
                generator = false,
                id = 0,
            },

        };



        public static List<PropertiesObject> CreatedElements = new List<PropertiesObject>();

        public void AddElement(bool generator, int numberElement, string name,
            int type, int powerElements, double[,] growthRate, double consumptionRate, TimeSpan intervalRefreashTime)
        {
            if (generator)
            {
                for (int i = 1; i <= numberElement; i++)
                {
                    //MessageBox.Show("for работает");
                    CreatedElements.Add(new PropertiesObject
                    {

                        generator = generator,
                        name = name,
                        type = type,
                        maxProduction = powerElements,
                        production = 0,
                        targetProduction = 0,
                        growthRate = growthRate,
                        id = id,
                    });
                    id++;
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 1; i <= numberElement; i++)
                {
                    int minutes = rnd.Next(0, 60);

                    var a = CreateGrowthRate(growthRate, powerElements, consumptionRate);

                    CreatedElements.Add(new PropertiesObject
                    {
                        generator = generator,
                        name = name,
                        type = type,
                        maxConsumption = powerElements,
                        consumption = a[0, 0],
                        growthRate = a,
                        id = id,
                        intervalRefreashTime = intervalRefreashTime,
                        refreashTime = new TimeSpan(TimeModel.TimeInSimulation.Hours, TimeModel.TimeInSimulation.Minutes + minutes, TimeModel.TimeInSimulation.Seconds)
                    });
                    id++;
                }
            }
        }



        public static double[,] CreateGrowthRate(double[,] standartGrowthRate, int maxConsumption, double consumptionRate)
        {
            Random rnd = new Random();

            for (int i = 0; i < standartGrowthRate.Length; i++)
            {
                if (i == 0)
                {
                    standartGrowthRate[0, i] = rnd.Next(0, maxConsumption);
                }
                else
                {
                    //(int)Math.Round()
                    standartGrowthRate[0, i] = rnd.Next((int)Math.Round(standartGrowthRate[0, i - 1] - (standartGrowthRate[0, i - 1] * consumptionRate)),
                        (int)Math.Round((standartGrowthRate[0, i - 1] * (consumptionRate + 1)) - ((standartGrowthRate[0, i - 1] * (consumptionRate + 1)) - maxConsumption)));
                }
            }

            return standartGrowthRate;
        }
    }
}
