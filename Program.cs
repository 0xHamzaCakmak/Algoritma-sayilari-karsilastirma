using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_syaıdan_buyugu_kucugu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından girilen 4 sayıdan en büyüğünü ve en küçüğünü bulan kod...
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int s3= Convert.ToInt32(Console.ReadLine());
            int s4 = Convert.ToInt32(Console.ReadLine());
            int enbuyuk = s1;
            int enkucuk = s1;
            if (s2 > enbuyuk)
                enbuyuk = s2;
            if (s3 > enbuyuk)
                enbuyuk = s3;
            if (s4 > enbuyuk)
                enbuyuk = s4;
            if (s2 < enkucuk)
                enkucuk = s2;
            if (s3 < enkucuk)
                enkucuk = s3;
            if (s4 < enkucuk)
                enkucuk = s4;
            Console.WriteLine("en buyuk sayı : " + enbuyuk);
            Console.WriteLine("en kucuk sayı : " + enkucuk);
        }
    }
}
