using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes
{
    internal class StockTransfer
    {
        private int StockTransferID { get; set; }
        private DateTime TransferDate { get; set; }
        private int TransferFrom { get; set; }
        private int TransferTo { get; set; }
        private int ProductID { get; set; }
        private decimal TransferQuantity { get; set; }
        
        private StockTransfer(int stockTransferID, DateTime transferDate, int transferFrom, int transferTo, int productID, decimal transferQuantity)
        {
            StockTransferID = stockTransferID;
            TransferDate = transferDate;
            TransferFrom = transferFrom;
            TransferTo = transferTo;
            ProductID = productID;
            TransferQuantity = transferQuantity;
        }


        public void INSERT() { }
        public void UPDATE() { }
        public void DELETE() { }
        public void SELECT() { }
    }


}
