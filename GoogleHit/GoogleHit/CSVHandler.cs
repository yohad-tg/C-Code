using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace GoogleHit
{

    class CSVHandler
    {
        
        
        public List<string> GetAllData()
        {
            List<string> UrlsLists = new List<string>();
            UrlHandler UrlHandler = new UrlHandler();
            // path of the file :
            string filename = @"C:\Users\Yoad.H\Desktop\JP google Hit\JP_GA_MP_DS.csv";
            var lines = File.ReadAllLines(filename); 
            for (int row = 1; row < lines.Length; row++)
            {
                string[] line_r = lines[row].Split(',');
                string GaTid = line_r[0];
                string Cid = line_r[1];
                string ShippingName = line_r[2];
                string Orderdate = line_r[3];
                string TotalOrders = line_r[4];
                string Ltv = line_r[5];
                string Gender = line_r[6];
                UrlsLists.Add(UrlHandler.UrlCreator(GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, Gender));
            }
            return UrlsLists;
        }
    }
}

