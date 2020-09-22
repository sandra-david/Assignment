using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WellBeingCampaign.Models
{
    [Serializable]
    [XmlRoot("WellBeings"), XmlType("Product")]
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public int Featured { get; set; }
        public string Type { get; set; }

        public static List<Products> GetProducts()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/products.xml");
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var products = new List<Products>();
            products = (from rows in ds.Tables[0].AsEnumerable()
                        select new Products
                        {
                            ProductId = Convert.ToInt32(rows[0].ToString()), //Convert row to int  
                            ProductName = rows[1].ToString(),
                            ImageName = rows[2].ToString(),
                            Description = rows[3].ToString(),
                            Featured = Convert.ToInt32(rows[4].ToString()),
                            Type = rows[5].ToString()
                        }).ToList();
            return products;
        }
    }
}