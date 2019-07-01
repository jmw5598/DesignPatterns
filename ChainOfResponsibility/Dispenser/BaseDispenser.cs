using System;

namespace ChainOfResponsibility.Dispenser
{
    public abstract class BaseDispenser
    {
        protected readonly IDispensable next;
        protected readonly int BILL_VALUE;

        public BaseDispenser(IDispensable next, int value)
        {
            this.BILL_VALUE = value;
            this.next = next;
        }

        public void Print(int count)
        {
            Console.WriteLine("Dispensing " + count + " $" + this.BILL_VALUE + " dollar bills");
        }
    }

    
}