using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes
{
    internal class Purchase
    {
        private int PurchaseID { get; set; }
        private DateTime PurchaseDate { get; set; }
        private int SupplierID { get; set; }
        private int CurrencyID { get; set; }
        private decimal PurchaseAmount { get; set; }
        private decimal Discount { get; set; }
        private decimal VAT { get; set; }
        private int PaymentMethodID { get; set; }
        private int ProductID { get; set; }
        private decimal PurchasePrice { get; set; }
        private decimal PurchaseQuantity { get; set; }
        private decimal PurchaseDiscount { get; set; }
        private decimal PurchaseVAT { get; set; }
        
        private Purchase(int purchaseID, DateTime purchaseDate, int supplierID, int currencyID, decimal purchaseAmount, decimal discount, decimal vat, int paymentMethodID, int productID, decimal purchasePrice, decimal purchaseQuantity, decimal purchaseDiscount, decimal purchaseVAT)
        {
            PurchaseID = purchaseID;
            PurchaseDate = purchaseDate;
            SupplierID = supplierID;
            CurrencyID = currencyID;
            PurchaseAmount = purchaseAmount;
            Discount = discount;
            VAT = vat;
            PaymentMethodID = paymentMethodID;
            ProductID = productID;
            PurchasePrice = purchasePrice;
            PurchaseQuantity = purchaseQuantity;
            PurchaseDiscount = purchaseDiscount;
            PurchaseVAT = purchaseVAT;

        }


        public void INSERT() { }
        public void UPDATE() { }
        public void DELETE() { }
        public void SELECT() { }
    }

}
