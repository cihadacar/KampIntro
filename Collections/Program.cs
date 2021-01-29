using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "engin", "murat", "kerem", "berkay" };

            //console.writeline(names[0]);
            //console.writeline(names[1]);
            //console.writeline(names[2]);
            //console.writeline(names[3]);

            //names = new string[5];
            //names[4] = "ilker";
            //console.writeline(names[4]);
            //console.writeline(names[0]);

            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
