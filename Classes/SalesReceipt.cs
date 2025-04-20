using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Pharmacy.Classes
    {
        internal class PaymentMethod
        {
            private int PaymentMethodID { get; set; }
            private string MethodName { get; set; }
            private string PMDescription { get; set; }

            private PaymentMethod(int paymentMethodID, string methodName, string pmDescription)
            {
                PaymentMethodID = paymentMethodID;
                MethodName = methodName;
                PMDescription = pmDescription;
            }

            public void INSERT() { }
            public void UPDATE() { }
            public void DELETE() { }
            public void SELECT() { }
        }

        internal class SalesReceipt
        {
            private int ReceiptID { get; set; }
            private int PaymentMethodID { get; set; }
            private DateTime PaymentDate { get; set; }
            private decimal PaymentAmount { get; set; }
            private int CurrencyID { get; set; }

            private SalesReceipt(int receiptID, int paymentMethodID, DateTime paymentDate, decimal paymentAmount, int currencyID)
            {
                ReceiptID = receiptID;
                PaymentMethodID = paymentMethodID;
                PaymentDate = paymentDate;
                PaymentAmount = paymentAmount;
                CurrencyID = currencyID;
            }

            public void INSERT() { }
            public void UPDATE() { }
            public void DELETE() { }
            public void SELECT() { }
        }
    }

}
