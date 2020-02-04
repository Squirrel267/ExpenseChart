using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Models
{
    public class Costs
    {
        public double PerFood { get; set; }
        public double PerCar { get; set; }
        public double PerTransport { get; set; }
        public double PerLoans { get; set; }
        public double PerUtilities { get; set; }
        public double PerOther { get; set; }

        public int Food { get; set; }
        public int Car { get; set; }
        public int Transport { get; set; }
        public int Loans { get; set; }
        public int Utilities { get; set; }
        public int Other { get; set; }

    }
}
