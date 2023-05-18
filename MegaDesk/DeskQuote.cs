using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace MegaDesk
{
    public class DeskQuote
    {
        const string rushOrderPricesFile = "rushOrderPrices.txt";

        int BASE_COST = 200;
        int SURFACE_AREA_COST_INCREASE_SIZE = 1000;
        int EXTRA_SURFACE_AREA_COST = 1;
        int DRAWER_COST = 50;

        Dictionary<material, int> materialCost = new Dictionary<material, int>()
        {
            { material.Laminate, 100 },
            { material.Oak, 200 },
            { material.Pine, 50 },
            { material.Rosewood, 300 },
            { material.Veneer, 125 }
        };

        Dictionary<productionTime, int[]> rushCost = new Dictionary<productionTime, int[]>()
        {
            {productionTime.rush3Days, new int[] {60,70,80 } },
            {productionTime.rush5Days, new int[] {40,50,60 } },
            {productionTime.rush7Days, new int[] {30,35,40 } },
            {productionTime.normal, new int[] {0,0,0 } }

        };

        public string customerName { get; set; } = "";

        public productionTime productionTime { get; set; }

        public float price { get; set; }
        public Desk desk { get; set; } = new Desk();

        public DateTime date { get; set; }

        private void getRushPrices(string fileName = rushOrderPricesFile)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                int[,] rushOrderPrices = new int[3, 3];
                int i = 0;
                int j = 0;
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    foreach (string value in values)
                    {
                        rushOrderPrices[i, j] = int.Parse(value.Trim());
                        j++;
                    }
                    i++;
                    j = 0;
                }
                rushCost[productionTime.rush3Days] = new int[] { rushOrderPrices[0, 0], rushOrderPrices[0, 1], rushOrderPrices[0, 2] };
                rushCost[productionTime.rush5Days] = new int[] { rushOrderPrices[1, 0], rushOrderPrices[1, 1], rushOrderPrices[1, 2] };
                rushCost[productionTime.rush7Days] = new int[] { rushOrderPrices[2, 0], rushOrderPrices[2, 1], rushOrderPrices[2, 2] };
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }


        public void calculatePrice()
        {

            // load rush price data, and replace hardcoded data in Dictionary<productionTime> values with the new values
            getRushPrices();

            // calculate size of desk and drawers and material
            int deskPrice = BASE_COST + 
                            (this.desk.drawer_count * DRAWER_COST ) +
                            materialCost[this.desk.material];

            // if large, then add extra
            int deskSize = this.desk.depth * this.desk.width;
            deskPrice += Math.Max(deskSize - SURFACE_AREA_COST_INCREASE_SIZE,0) * EXTRA_SURFACE_AREA_COST;

            // add production cost based on size
            // should resolve to 0, 1, 2
            int rushIndex = Math.Min((int)(deskSize / 1000), 2);

            deskPrice += rushCost[this.productionTime][rushIndex];

            // set price
            this.price = deskPrice;
        }

        public void saveQuote()
        {
            throw new System.NotImplementedException();
        }
    }
}