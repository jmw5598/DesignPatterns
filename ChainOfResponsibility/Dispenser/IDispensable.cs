using System;

namespace ChainOfResponsibility.Dispenser
{
    public interface IDispensable
    {
        void Dispense(Currency currency);
    }
}