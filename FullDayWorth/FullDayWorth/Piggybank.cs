using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_01
{
    internal class Piggybank
    {
        public double Money { get; set; }

        public void AddMoney(double input)
        {
            Console.WriteLine($"Beløb indsat: {input}");
            Money += input;
        }

        public void AnnounceMoney()
        {
            Console.WriteLine($"Saldo: {Math.Round(Money, 2)}");
        }
    }
}
