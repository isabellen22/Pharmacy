using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy0.Classes
{
    internal class SalesReturn
    {
        private int SalesReturnID { get; set; }
        private DateTime ReturnDate { get; set; }
        private int CurrencyID { get; set; }
        private decimal Amount { get; set; }
        private List<SalesReturnDetail> SalesReturnDetails { get; set; }

        // Constructor
        public SalesReturn(int salesReturnID, DateTime returnDate, int currencyID, decimal amount)
        {
            SalesReturnID = salesReturnID;
            ReturnDate = returnDate;
            CurrencyID = currencyID;
            Amount = amount;
            SalesReturnDetails = new List<SalesReturnDetail>(); // Initialize the list of details
        }

        // Method to add details to the return
        public void AddSalesReturnDetail(int productID, decimal returnedQuantity, decimal returnedPrice)
        {
            SalesReturnDetails.Add(new SalesReturnDetail(productID, returnedQuantity, returnedPrice));
        }

        // INSERT method for inserting the SalesReturn and its details into the database
        public void INSERT()
        {
            // Code to insert SalesReturn into the database
            // For example: Insert SalesReturn record first

            // Then insert each SalesReturnDetail into the database as well
            foreach (var detail in SalesReturnDetails)
            {
                // Insert each detail into the database
            }
        }

        // UPDATE method to update SalesReturn and its details in the database
        public void UPDATE()
        {
            // Code to update the SalesReturn record
            // Then update the details as needed
        }

        // DELETE method to delete the SalesReturn and its details
        public void DELETE()
        {
            // Code to delete the SalesReturn record
            // Also delete associated details
        }

        // SELECT method to retrieve SalesReturn and its details from the database
        public void SELECT()
        {
            // Code to select the SalesReturn record
            // Then retrieve all related SalesReturnDetails
        }
    }

    // SalesReturnDetail class that holds information about the returned product
    internal class SalesReturnDetail
    {
        public int ProductID { get; set; }
        public decimal ReturnedQuantity { get; set; }
        public decimal ReturnedPrice { get; set; }

        // Constructor for SalesReturnDetail
        public SalesReturnDetail(int productID, decimal returnedQuantity, decimal returnedPrice)
        {
            ProductID = productID;
            ReturnedQuantity = returnedQuantity;
            ReturnedPrice = returnedPrice;
        }
    }
}