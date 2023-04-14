using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6_
{
    public class Money
    {
        private int dollars;
        private int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public int Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }

        public int Cents
        {
            get { return cents; }
            set { cents = value; }
        }

        public void Display()
        {
            Console.WriteLine($"{dollars}.{cents}");
        }
    }

    public class Product : Money
    {
        private string name;

        public Product(string name, int dollars, int cents) : base(dollars, cents)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void ReducePrice(int dollars, int cents)
        {
            int newCents = Cents - cents;
            int newDollars = Dollars - dollars;

            if (newCents < 0)
            {
                newCents += 100;
                newDollars--;
            }

            if (newDollars < 0)
            {
                throw new ArgumentException("New price cannot be negative");
            }

            Dollars = newDollars;
            Cents = newCents;
        }

        public void Display()
        {
            Console.WriteLine($"Product: {name}, Price: {Dollars}.{Cents}");
        }
    }
}