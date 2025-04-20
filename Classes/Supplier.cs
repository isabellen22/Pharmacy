using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes
{
    internal class Supplier
    {
        private int SupplierID { get; set; }
        private string SupplierName { get; set; }
        private string SupplierEmail { get; set; }
        private string SupplierContactNB { get; set; }
        private int CountryID { get; set; }


        private Supplier(int supplierID, string supplierName, string supplierEmail, string supplierContactNB, int countryID)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            SupplierEmail = supplierEmail;
            SupplierContactNB = supplierContactNB;
            CountryID = countryID;
        }

        public void INSERT() { }
        public void UPDATE() { }
        public void DELETE() { }
        public void SELECT() { }
    }

}
