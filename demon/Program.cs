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
            using (var reader = new Reader("C:\\Users\\Administrator\\Desktop\\awdb.awdb"))
            {
                var metadata = reader.Metadata;

                
                var ip = IPAddress.Parse("166.111.4.100");
                var data = reader.Find<Dictionary<string, object>>(ip);


                Console.WriteLine("洲:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["continent"]));
                Console.WriteLine("国家编码:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["areacode"]));
                Console.WriteLine("国家:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["country"]));
                Console.WriteLine("邮编:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["zipcode"]));
                Console.WriteLine("时区:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["timezone"]));
                Console.WriteLine("定位精度:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["accuracy"]));
                Console.WriteLine("定位方式:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["source"]));
            

                List<object> array = (List<object>)data["multiAreas"];
                var prov = ((Dictionary<string, object>)array[0])["prov"];
                var city = ((Dictionary<string, object>)array[0])["city"];
                var district = ((Dictionary<string, object>)array[0])["district"];
                var lat = ((Dictionary<string, object>)array[0])["latwgs"];
                var lng = ((Dictionary<string, object>)array[0])["lngwgs"];
                var radius = ((Dictionary<string, object>)array[0])["radius"];
                Console.WriteLine("省:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])prov));
                Console.WriteLine("城市:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])city));
                Console.WriteLine("区县:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])district));
                Console.WriteLine("纬度:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])lat));
                Console.WriteLine("经度:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])lng));
                Console.WriteLine("半经:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])radius));


                Console.WriteLine("运营商{0}:", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["isp"]));
                Console.WriteLine("AS号{0}:", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["asnumber"]));
                Console.WriteLine("拥有者{0}:", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["owner"]));


            }
            
       
        }
    }
}
