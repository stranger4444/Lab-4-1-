using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Рослина : Живий_організм, IReproducible
    {
        public string Вид { get; set; }

        public Рослина(double енергія, int вік, double розмір, string вид)
            : base(енергія, вік, розмір)
        {
            Вид = вид;
        }

        public void Розмножитися()
        {
            Console.WriteLine($"Рослина виду {Вид} розмножується.");
        }
    }
}
