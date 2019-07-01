using System;

namespace ChainOfResponsibility.Dispenser
{
    public class DispenserFactory
    {
        public static IDispensable GetDispenser()
        {
            IDispensable d1 = new ATMDispenser(null, 1);
            IDispensable d5 = new ATMDispenser(d1, 5);
            IDispensable d10 = new ATMDispenser(d5, 10);
            IDispensable d20 = new ATMDispenser(d10, 20);
            IDispensable d50 = new ATMDispenser(d20, 50);
            return d50;
        }
    }
}