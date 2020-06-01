using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Ziemia ziemia = new Ziemia();
            ziemia.Atmosfera();
            ziemia.PoraDniaNocy();
            ziemia.Ruch();
            Console.ReadKey();
        }
    }

    abstract class CialoNiebieskie
    {
        public string Nazwa { get; set; }
        public void Ruch()
        {
            Console.WriteLine("Kazdemu cialu niebieskiemu towarzyszy ruch.");
        }
    }
    abstract class Planeta: CialoNiebieskie
    {
        public void PoraDniaNocy()
        {
            Console.WriteLine("Pora dnia i nocy.");
        }
    }
    class Ziemia: Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera ziemska.");
        }
    }
}
