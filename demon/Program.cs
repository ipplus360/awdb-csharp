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
            using (var reader = new Reader("C:\\Users\\fengchuan\\Desktop\\IP_city_single_BD09_WGS84_ipv6_awdb.awdb"))
            {
                var metadata = reader.Metadata;

                
                var ip = IPAddress.Parse("2a03:f80:852:158:255:208:70:ffff");
                var data = reader.Find<Dictionary<string, object>>(ip);

				if (!(data==null) ){
					Console.WriteLine("洲:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["continent"]));
					Console.WriteLine("国家编码:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["areacode"]));
					//Console.WriteLine("行政编码:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["adcode"]));// 试用版无此字段
					
					Console.WriteLine("国家:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["country"]));
					Console.WriteLine("邮编:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["zipcode"]));
					Console.WriteLine("时区:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["timezone"]));
					Console.WriteLine("定位精度:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["accuracy"]));
					Console.WriteLine("定位方式:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["source"]));
				

					Console.WriteLine("省份:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["province"]));
					Console.WriteLine("城市:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["city"]));
					//Console.WriteLine("区县:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["district"]));
					Console.WriteLine("WGS84坐标系经度:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["lngwgs"]));
					Console.WriteLine("WGS84坐标系纬度:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["latwgs"]));
					Console.WriteLine("定位半径:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["radius"]));
			


					Console.WriteLine("运营商:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["isp"]));
					Console.WriteLine("AS号:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["asnumber"]));
					Console.WriteLine("拥有者:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data["owner"]));
					// Console.WriteLine("拥有者:{0}", System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data));
					//输出所有字段
					foreach (string key in data.Keys)
					{
						Console.WriteLine(string.Format("key: {0} value{1}", key, System.Text.UTF8Encoding.UTF8.GetString((System.Byte[])data[key])));
					}
					
				}else{
					Console.WriteLine("no results..没有查到结果");
				}


            }
            
       
        }
    }
}
