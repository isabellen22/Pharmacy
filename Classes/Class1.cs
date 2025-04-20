using System;

namespace Pharmacy.Classes
{
    internal class ProductDetails
    {
        public int ProductDetailsID { get; set; }
        public DateTime ProductProdDate { get; set; }
        public DateTime ProductExpDate { get; set; }
        public decimal ProductQuantity { get; set; }

        // Constructor
        public ProductDetails(int productDetailsID, DateTime productProdDate, DateTime productExpDate, decimal productQuantity)
        {
            ProductDetailsID = productDetailsID;
            ProductProdDate = productProdDate;
            ProductExpDate = productExpDate;
            ProductQuantity = productQuantity;
        }

        // Method to insert Product Details into the database
        public void INSERT()
        {
            // Similar database logic for inserting product details
        }

        // Method to update Product Details in the database
        public void UPDATE()
        {
            // Similar database logic for updating product details
        }

        // Method to delete Product Details from the database
        public void DELETE()
        {
            // Similar database logic for deleting product details
        }

        // Method to retrieve Product Details from the database
        public void SELECT()
        {
            // Similar database logic for selecting product details
        }
    }
}

