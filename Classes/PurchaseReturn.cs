using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes
{
    internal class PurchaseReturn
    {
        private int PurchaseReturnID { get; set; }
        private int PurchaseID { get; set; }
        private DateTime ReturnDate { get; set; }
        private string ReturnReason { get; set; }
        private int CurrencyID { get; set; }
        private decimal Amount { get; set; }
        private decimal Discount { get; set; }
        private decimal VAT { get; set; }
        private int PaymentMethodID { get; set; }
        private int PReturnedProduct { get; set; }
        private decimal PReturnedQuantity { get; set; }
        private decimal PReturnedPrice { get; set; }
        private decimal PReturnDiscount { get; set; }
        private decimal PReturnVAT { get; set; }
       
        private PurchaseReturn(int purchaseReturnID, int purchaseID, DateTime returnDate, string returnReason, int currencyID, decimal amount, decimal discount, decimal vat, int paymentMethodID, int pReturnedProduct, decimal pReturnedQuantity, decimal pReturnedPrice, decimal pReturnDiscount, decimal pReturnVAT)
        {
            PurchaseReturnID = purchaseReturnID;
            PurchaseID = purchaseID;
            ReturnDate = returnDate;
            ReturnReason = returnReason;
            CurrencyID = currencyID;
            Amount = amount;
            Discount = discount;
            VAT = vat;
            PaymentMethodID = paymentMethodID;
            PReturnedProduct = pReturnedProduct;
            PReturnedQuantity = pReturnedQuantity;
            PReturnedPrice = pReturnedPrice;
            PReturnDiscount = pReturnDiscount;
            PReturnVAT = pReturnVAT;
        }


        public void INSERT() { }
        public void UPDATE() { }
        public void DELETE() { }
        public void SELECT() { }
    }


}
