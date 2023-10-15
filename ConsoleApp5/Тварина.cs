using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Тварина : Живий_організм, IReproducible, IPredator
    {
        public string Вид { get; set; }
        public bool Хижацтво { get; set; }

        public Тварина(double енергія, int вік, double розмір, string вид, bool хижацтво)
            : base(енергія, вік, розмір)
        {
            Вид = вид;
            Хижацтво = хижацтво;
        }

        public void Розмножитися()
        {
            Console.WriteLine($"Тварина виду {Вид} розмножується.");
        }

        public void Полювати(Живий_організм жертва)
        {
            if (Хижацтво)
            {
                Console.WriteLine($"Тварина виду {Вид} полює на інший організм.");

            }
            else
            {
                Console.WriteLine($"Тварина виду {Вид} не є хижаком.");
            }
        }
    }
}