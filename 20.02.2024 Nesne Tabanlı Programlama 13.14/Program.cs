using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._2024_Nesne_Tabanlı_Programlama_13._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = new int();
            int c = a + b;
            string s = "";
            string e = "Feyza\n";
            string t = "kaya";
            string p = s + t;
            System.Console.WriteLine(c + "\n" + p);
            byte data = 5;
            byte data2 = 9;
            int veri3 = data + data2;

            int veri4 = a;
            int veri5 = veri4 + 8;
            int veri6 = a * veri4;

            bool veri7 = false;

            a = data;

             
            s = a.ToString();
            s = s + "8";

            //operatörler +/-, ++, back and front 
            Console.ReadLine();

        }
    }
}
