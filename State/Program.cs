using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMMachine atmMachine = new ATMMachine();

            // atmMachine.InsertDebitCard();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();

            Console.Read();
        }
    }
}
