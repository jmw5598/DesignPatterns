using System;

namespace ChainOfResponsibility.Dispenser
{
    public class Currency
    {

        public Currency(int amount)
        {
            this.Amount = amount;
        }
        public int Amount { get; }
    }
}