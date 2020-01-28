using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Configuration;

namespace GoogleHit
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrlEndPoint = ConfigurationManager.AppSettings["GoogleUrl"];
            CSVHandler csv = new CSVHandler();
            var Urlreciver = csv.GetAllData();
            PostRequests(UrlEndPoint,Urlreciver);
            Console.WriteLine("Done");
            Console.ReadKey();
        }

         public static void PostRequests(string UrlEndPoint, List<string> Urlreciver)
         {
            try
            {
                for (int i = 0; i < Urlreciver.Count; i++)
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(UrlEndPoint);
                    request.Method = "POST";
                    byte[] byteArray = Encoding.UTF8.GetBytes(Urlreciver[i]);
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = byteArray.Length;
                    using (Stream dataStream = request.GetRequestStream())
                    {
                        dataStream.Write(byteArray, 0, byteArray.Length);
                        WebResponse response = request.GetResponse();
                        using (HttpWebResponse httpResponse = (HttpWebResponse)response)
                        {
                            if (httpResponse.StatusCode == HttpStatusCode.OK)
                            {
                                WriteOkToText(Urlreciver[i].ToString());
                                Console.WriteLine("Row hit {0}",i);
                            }
                            else { WriteFailToText(Urlreciver[i].ToString()); }
                            Console.WriteLine(httpResponse.StatusCode.ToString());
                        }
                    }
                    
                }

            }
            catch (WebException ex)
            {
                var a = ((HttpWebResponse)ex.Response).StatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :{0}",ex.Message);
            }
        }

        public static void WriteOkToText(string Urlreciver)
        {
            string PostedHistory = "PostedValuesTest.txt";
            using (FileStream fs = new FileStream(PostedHistory, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Yoad.H\Desktop\JP google Hit\LastPosted Value for 3000\PostedValuesTest.txt", append: true))
            {
                sw.WriteLine("Posted " + DateTime.Now+ ":");
                sw.WriteLine(Urlreciver);
            }
        }

        public static void WriteFailToText(string Urlreciver)
        {
            string PostedHistory = "UnPostedValues.txt";
            using (FileStream fs = new FileStream(PostedHistory, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Yoad.H\Desktop\JP google Hit\LastPosted Value for 3000\UnPostedValues.txt", append: true))
            {
                sw.WriteLine("UnPosted " + DateTime.Now + ":");
                sw.WriteLine(Urlreciver);
            }
        }
    }
}


