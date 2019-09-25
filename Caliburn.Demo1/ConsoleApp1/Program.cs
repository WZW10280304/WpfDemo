using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(str))
            {
                str = "http://test-api.aecg.com.cn";
            }

            PingIpOrDomainName(str);

            Console.ReadKey();
        }


        /// <summary>
        /// 用于检查IP地址或域名是否可以使用TCP/IP协议访问(使用Ping命令),true表示Ping成功,false表示Ping失败 
        /// </summary>
        /// <param name="strIpOrDName">输入参数,表示IP地址或域名</param>
        /// <returns></returns>

        [DllImport("wininet")]
        private static extern bool InternetGetConnectedState(out int connectionDescription, int reservedValue);
        public static bool PingIpOrDomainName(string strIpOrDName)
        {
            if (!JudgeIsOnline())
            {
                Console.WriteLine("JudgeIsOnline: false");

                return false;
            }

            HttpWebResponse res = null;
            var canCn = true;   //设成可以连接； 
            try
            {
                var req = (HttpWebRequest)WebRequest.Create(strIpOrDName);
                req.Timeout = 5000;
                res = (HttpWebResponse)req.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);

                canCn = false;   //无法连接 
            }
            finally
            {
                res?.Close();
            }

            Console.WriteLine("PingIpOrDomainName:true");

            return canCn;
        }

        public static bool JudgeIsOnline()
        {
            System.Net.NetworkInformation.Ping ping;
            System.Net.NetworkInformation.PingReply res;
            ping = new System.Net.NetworkInformation.Ping();
            try
            {
                var timeout = 1550; // Timeout 时间，单位：毫秒   
                System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
                options.DontFragment = true;
                string data = "Test Data";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                res = ping.Send("www.baidu.com", timeout, buffer, options);

                Console.WriteLine("JudgeIsOnline:" + res.Status+",");

                if (res.Status != System.Net.NetworkInformation.IPStatus.Success)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
