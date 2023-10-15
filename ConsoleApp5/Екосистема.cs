using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Екосистема
    {
        public List<Живий_організм> Організми { get; set; }

        public Екосистема()
        {
            Організми = new List<Живий_організм>();
        }

        public void ДодатиОрганізм(Живий_організм організм)
        {
            Організми.Add(організм);
        }

        public void Взаємодія()
        {
            foreach (var організм1 in Організми)
            {
                foreach (var організм2 in Організми)
                {
                    if (організм1 != організм2)
                    {
                        if (організм1 is IPredator && організм2 is Живий_організм)
                        {
                            ((IPredator)організм1).Полювати((Живий_організм)організм2);
                        }
                    }
                }
            }
        }
    }
}


