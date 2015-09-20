using ER.Data;
using ER.DataLayer;
using ER.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new SellerRepository();

            var seller = new Seller { Name = "Flipkart", Url = "http://flipkart.com" };

            seller.Properties = new List<SellerProperty>
                                {
                                    new SellerProperty{Name = "Flipkart Shopping Type new ", Value = "E Commerse site"},
                                    new SellerProperty{Name = "Flipkart Address new asdfasd", Value = "Our favorite address"}
                                };

            s.InsertOrUpdate(seller);

            //var a = s.All;

            //s.Delete(a.FirstOrDefault().SellerId);
        }
    }
}
