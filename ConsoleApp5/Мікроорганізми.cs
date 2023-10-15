using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Мікроорганізм : Живий_організм, IReproducible
    {
        public string Вид { get; set; }

        public Мікроорганізм(double енергія, int вік, double розмір, string вид)
            : base(енергія, вік, розмір)
        {
            Вид = вид;
        }

        public void Розмножитися()
        {
            Console.WriteLine($"Мікроорганізм виду {Вид} розмножується.");
        }
    }
}
