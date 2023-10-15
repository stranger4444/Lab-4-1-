using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Живий_організм
    {
        public double Енергія { get; set; }
        public int Вік { get; set; }
        public double Розмір { get; set; }

        public Живий_організм(double енергія, int вік, double розмір)
        {
            Енергія = енергія;
            Вік = вік;
            Розмір = розмір;
        }
    }
}