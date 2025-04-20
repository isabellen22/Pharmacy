using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes
{
    internal class Sales
    {
        private int SalesID { get; set; }
        private DateTime SalesDate { get; set; }
        private int EmployeeID { get; set; }
        private int ClientID { get; set; }
        private int WarehouseID { get; set; }
        private int PaymentStatusID { get; set; }
        private decimal VAT { get; set; }
        private decimal SalesAmount { get; set; }
        private int CurrencyID { get; set; }
        private int ProductID { get; set; }
        private decimal SalesQuantity { get; set; }
        private decimal SalesPrice { get; set; }
        private decimal SalesDiscount { get; set; }
        private decimal SalesVAT { get; set; }
      
        private Sales(int salesID, DateTime salesDate, int employeeID, int clientID, int warehouseID, int paymentStatusID, decimal vat, decimal salesAmount, int currencyID, int productID, decimal salesQuantity, decimal salesPrice, decimal salesDiscount, decimal salesVAT)
        {
            SalesID = salesID;
            SalesDate = salesDate;
            EmployeeID = employeeID;
            ClientID = clientID;
            WarehouseID = warehouseID;
            PaymentStatusID = paymentStatusID;
            VAT = vat;
            SalesAmount = salesAmount;
            CurrencyID = currencyID;
            ProductID = productID;
            SalesQuantity = salesQuantity;
            SalesPrice = salesPrice;
            SalesDiscount = salesDiscount;
            SalesVAT = salesVAT;
        }


        public void INSERT() { }
        public void UPDATE() { }
        public void DELETE() { }
        public void SELECT() { }
    }
}
