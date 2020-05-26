using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "yazilimdelisicom", donenmetin = "", bosluk = "";
            int uzunluk = metin.Length, i = metin.Length - 1, a = 0;
            while (i >= 0)
            {
                donenmetin += metin[i];
                i--;
            }
            int b = donenmetin.Length - 1;
            while (uzunluk >= 0)
            {
                bosluk = bosluk.Insert(a, " ");

                Console.WriteLine(bosluk + donenmetin.Substring(a, uzunluk) + metin.Substring(1, b));

                uzunluk--;
                b--;
                a++;
                if (b == 0)
                {
                    break;
                }
            }
            Console.WriteLine(bosluk.Insert((metin.Length - 1), " ") + metin.Substring(0, 1));

            Console.ReadKey();
        }
    }
}
