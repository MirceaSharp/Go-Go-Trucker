using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Go_trucker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is jouw snelheid?");
            double snelheid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel km heb je gereden?");
            double afstand = Convert.ToDouble(Console.ReadLine());

            double aantalUurGereden = afstand / snelheid;
            Console.WriteLine("Je hebt " + aantalUurGereden + " uur gereden");
            Console.ReadLine();


        }
    }
}
