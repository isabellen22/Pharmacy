using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes
{
    internal class UnitOfMeasurement
    {
        private int UnitID { get; set; }
        private string UnitName { get; set; }
        private string UnitSymbol { get; set; }
        private int ConversionUnitID { get; set; }

        private UnitOfMeasurement(int unitID, string unitName, string unitSymbol, int conversionUnitID)
        {
            UnitID = unitID;
            UnitName = unitName;
            UnitSymbol = unitSymbol;
            ConversionUnitID = conversionUnitID;
        }

        public void INSERT() { }
        public void UPDATE() { }
        public void DELETE() { }
        public void SELECT() { }
    }
}
