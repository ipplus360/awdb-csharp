using System;
using AiWen.Db;
using System.Net;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace demon
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new Reader("C:\\Users\\Administrator\\Desktop\\IP_city_2020W16_single_WGS84.awdb"))
            {
                var metadata = reader.Metadata;

                
                var ip = IPAddress.Parse("166.111.4.100");
                var data = reader.Find<Dictionary<string, object>>(ip);

                Console.WriteLine("精度:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["accuracy"]));
                Console.WriteLine("areacode:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["areacode"]));
                Console.WriteLine("asnumber:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["asnumber"]));

                Console.WriteLine("continent:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["continent"]));
                Console.WriteLine("country:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["country"]));
                Console.WriteLine("isp{0}:", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["isp"]));
                Console.WriteLine("timezone:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["timezone"]));

                Console.WriteLine("zipcode:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["zipcode"]));

               


            }
            
       
        }
    }
}
