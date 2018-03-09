using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _15dh110315
{
    class Program
    {
        static void Main(string[] args)
        {
            //BT1
            String strtenmay = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strtenmay);

            // tim host 
            IPHostEntry iphostentry = Dns.GetHostByName(strtenmay);

            // ip local
            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + ++nIP + ": " +
                                  ipaddress.ToString());
            }

            //bt2

            Console.Write("Nhap ten mien hoac ip: ");
            string host = Console.ReadLine();

            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("Hostname: {0}", e.HostName);

            // In tên miền hoặc bí danh
            foreach (string s in e.Aliases)
                Console.WriteLine("\t+ Alias: {0} \n", s);

            // Danh sách điạ chỉ IP
            foreach (IPAddress i in e.AddressList)
                Console.WriteLine("\t+ IP: {0}", i);
        }
    }
}