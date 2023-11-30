using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhthoigian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime ngaybd, ngaykt;
            Console.WriteLine("nhap ngay bd: ");
            ngaybd = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);
            Console.WriteLine("nhap ngay kt: ");
            ngaykt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy;hh:mm:ss", null);
            Console.WriteLine(" thoi gian: ");
            Console.WriteLine("ngay bd :" + ngaybd.ToString("dd/mm/yyyy"));
            Console.WriteLine("ngay kt: "+ngaykt.ToString("dd/MM/yyyy;hh:mm:ss"));
            TimeSpan tinhTG = ngaykt - ngaybd;
            Console.WriteLine(tinhTG.ToString());
            Console.ReadKey();
        }
    }
}
