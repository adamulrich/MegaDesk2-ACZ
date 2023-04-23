using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaDesk
{
    public class DeskQuote
    {
        readonly Dictionary<material, float> materialCost = new Dictionary<material, float>()
        {
            { material.Laminate, 100 },
            { material.Oak, 200 },
            { material.Pine, 50 },
            { material.Rosewood, 300 },
            { material.Veneer, 125 }
        };

        readonly Dictionary<productionTime, int[]> rushCost = new Dictionary<productionTime, int[]>()
        {
            {productionTime.rush3Days, new int[] {60,70,80 } },
            {productionTime.rush5Days, new int[] {40,50,60 } },
            {productionTime.rush7Days, new int[] {30,35,40 } },
            {productionTime.normal, new int[] {0,0,0 } }

        };

        //new int[] { 60, 70, 80 };



        public string customerName
        {
            get => default;
            set
            {
            }
        }

        public productionTime productionTime
        {
            get => default;
            set
            {
            }
        }

        public float price
        {
            get => default;
            set
            {
            }
        }

        public Desk desk
        {
            get => default;
            set
            {
            }
        }

        public dateTime Date
        {
            get => default;
            set
            {
            }
        }

        public void caclulatePrice()
        {
            throw new System.NotImplementedException();
        }

        public void saveQuote()
        {
            throw new System.NotImplementedException();
        }
    }
}