using System;
using ChainOfResponsibility.Dispenser;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IDispensable dispenser = DispenserFactory.GetDispenser();
            dispenser.Dispense(new Currency(238));
        }
    }
}
