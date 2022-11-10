using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace doga
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            StreamReader beolv = new StreamReader("szamok.txt");

            Console.WriteLine("\"szamok.txt\" fájl feldolgozása: ");

            Console.WriteLine();

            while (!beolv.EndOfStream)
            {
                lista.Add(beolv.ReadLine());
            }

            int mind = lista.Sum(Convert.ToInt32);

            Console.WriteLine($"A számok összege: {mind}");

            Console.WriteLine();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine();

            Console.WriteLine("--**--**--");

            Console.WriteLine();

            //2.

            List<string> lista2 = new List<string>();

            StreamReader be2 = new StreamReader("parok.txt");

            while (!be2.EndOfStream)
            {
                lista2.Add(be2.ReadLine());
            }

            string adatok = Convert.ToString(lista2);

            string[] szoveg = adatok.Split(';');

            foreach (string section in szoveg)
            {
                Console.WriteLine(Convert.ToInt32(section.ToString()));
            }



            Console.ReadKey();
        }
    }
}
