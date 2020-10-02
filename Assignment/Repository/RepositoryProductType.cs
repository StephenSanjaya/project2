using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Model;
using Assignment.Factory;

namespace Assignment.Repository
{
    public class RepositoryProductType
    {
        static DatabaseTokobediaEntities1 db = new DatabaseTokobediaEntities1();

        public static List<ProductType> GetAll()
        {
            return (from x
                    in db.ProductTypes
                    select x).ToList();
        }

        public static void InsertProductType(String prodtype, String desc)
        {
            db.ProductTypes.Add(FactoryProductType.InsProdType(prodtype,desc));
            db.SaveChanges();
        }

        public static ProductType FindID(Int32 id)
        {
            return (from x
                    in db.ProductTypes
                    where x.ProductTypeID == id
                    select x).FirstOrDefault();
        }

        public static void DeleteProductType(Int32 id)
        {
            ProductType prodtype = FindID(id);
            db.ProductTypes.Remove(prodtype);
            db.SaveChanges();
        }

        public static void UpdateProductType(Int32 id, String producttype, String desc)
        {
            ProductType prodtype = FindID(id);
            prodtype.ProductTypeName = producttype;
            prodtype.Descript = desc;
            db.SaveChanges();
        }

        public static bool CekID(Int32 id)
        {
            ProductType prodtype = FindID(id);
            if (prodtype != null)
                return true;
            return false;
        }

    }
}