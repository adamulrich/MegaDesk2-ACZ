using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaDesk
{
    public class DeskQuote
    {

        int BASE_COST = 200;
        int SURFACE_AREA_COST_INCREASE_SIZE = 1000;
        int EXTRA_SURFACE_AREA_COST = 1;
        int DRAWER_COST = 50;
        int SMALL_SIZE = 0;
        int MEDIUM_SIZE = 1;
        int LARGE_SIZE = 2;


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

        public DateTime Date { get; set; }

        public void calculatePrice()
        {
            // calculate size of desk and drawers and material
            int deskPrice = BASE_COST + 
                            this.desk.drawer_count * DRAWER_COST +
                            materialCost[this.desk.material];

            // if large, then add extra
            int deskSize = this.desk.depth * this.desk.width;
            if (deskSize > SURFACE_AREA_COST_INCREASE_SIZE)
            {
                deskPrice += (deskSize - SURFACE_AREA_COST_INCREASE_SIZE) * EXTRA_SURFACE_AREA_COST;
            }

            // add production cost based on size
            int rushIndex = SMALL_SIZE;
            if (deskSize > 2000)
            {
                rushIndex = LARGE_SIZE;
            }
            else if (deskSize > 1000)
            {
                rushIndex = MEDIUM_SIZE;
            }

            deskPrice += rushCost[this.productionTime][rushIndex];

            this.price = deskPrice;

        }

        public void saveQuote()
        {
            throw new System.NotImplementedException();
        }
    }
}