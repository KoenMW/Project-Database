using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class VATCalculation
    {
        public float LowTariff { get; set; }
        public float HighTariff { get; set; } 
        public float TotalTariff { get { return LowTariff + HighTariff; } }
        public int AmountLowTariff { get; set; }
        public int AmountHighTariff { get; set; } 
        public int AmountTotalTariff { get { return AmountLowTariff + AmountHighTariff; } }

    }
}
