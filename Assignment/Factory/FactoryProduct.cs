using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Model;

namespace Assignment.Factory
{
    public class FactoryProduct
    {
        
        public static Product InsProduct(String productName, Int32 prodtypeid, Int32 stock, Int32 price)
        {
            Product prod = new Product();
            prod.ProductName = productName;
            prod.ProductTypeID = prodtypeid;
            prod.Stock = stock;
            prod.Price = price;

            return prod;
        }

    }
}