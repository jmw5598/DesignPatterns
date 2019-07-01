using System;

namespace ChainOfResponsibility.Dispenser
{
    public class ATMDispenser : BaseDispenser, IDispensable
    {
        public ATMDispenser(IDispensable next, int value) : base(next, value) {}

        public void Dispense(Currency currency)
        {
            if(currency.Amount >= this.BILL_VALUE) {

                int num = currency.Amount / this.BILL_VALUE;
                int rem = currency.Amount % this.BILL_VALUE;
                this.Print(num);
                
                if(rem > 0) 
                    this.next.Dispense(new Currency(rem));
            
            } else {
                this.next.Dispense(currency);
            }
        }
    }
}