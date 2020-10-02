using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Model;

namespace Assignment.Factory
{
    public class FactoryProductType
    {
        public static ProductType InsProdType(String prodtype, String desc)
        {
            ProductType pt = new ProductType();
            pt.ProductTypeName = prodtype;
            pt.Descript = desc;
            return pt;
        }
    }
}