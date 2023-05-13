using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaDesk
{
    public class Desk
    {
        public int width { get; set; }

        public int depth { get; set; }

        public int drawer_count { get; set; }

        public material material { get; set; } 
    }

    public class FlatQuote
    {
        public string customerName { get; set; }
        public productionTime productionTime { get; set; }
        public float price { get; set; }
        public DateTime date { get; set; }

        public int width { get; set; }
        public int depth { get; set; }
        public int drawer_count { get; set; }
        public material material { get; set; }

    }

}