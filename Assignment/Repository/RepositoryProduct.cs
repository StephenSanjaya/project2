using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Model;
using Assignment.Factory;

namespace Assignment.Repository
{
    public class RepositoryProduct
    {
        static DatabaseTokobediaEntities1 db = new DatabaseTokobediaEntities1();

        public static List<Product> GetAll()
        {
            return (from x
                    in db.Products
                    select x).ToList();
        }

        public static void InsertProduct(String productName, Int32 prodtypeid, Int32 stock, Int32 price)
        {
            db.Products.Add(FactoryProduct.InsProduct(productName, prodtypeid, stock, price));
            db.SaveChanges();
        }

        public static Product FindID(Int32 id)
        {
            return (from x
                    in db.Products
                    where x.ProductID == id
                    select x).FirstOrDefault();
        }

        public static void UpdateProduct(Int32 id, Int32 producttypeid, String productname, Int32 price, Int32 stock)
        {
            Product prod = FindID(id);
            prod.ProductTypeID = producttypeid;
            prod.ProductName = productname;
            prod.Price = price;
            prod.Stock = stock;
            db.SaveChanges();
        }

        public static void DeleteProduct(Int32 id)
        {
            Product prod = FindID(id);
            db.Products.Remove(prod);
            db.SaveChanges();
        }

        public static bool CekID(Int32 id)
        {
            Product prod = FindID(id);
            if (prod != null)
                return true;
            return false;
        }

        public static Product FindProductTypeID(Int32 id)
        {
            return (from x
                    in db.Products
                    where x.ProductTypeID == id
                    select x).FirstOrDefault();
        }

        public static bool CekProductTypeID(Int32 id)
        {
            Product prod = FindProductTypeID(id);
            if (prod != null)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public static List<Product> GetFiveProduct()
        {
            var prod =  (from x
                        in db.Products
                        orderby Guid.NewGuid()
                        select x).Take(5);
            return prod.ToList();
        }
    }
}