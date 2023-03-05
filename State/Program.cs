using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initially ATM Machine in DebitCardNotInsertedState
            ATMMachine atmMachine = new ATMMachine();

            atmMachine.InsertDebitCard();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();

            //Trying to move to another state
            atmMachine.InsertDebitCard();

            atmMachine.EjectDebitCard();
           
            Console.Read();
        }
    }
}
