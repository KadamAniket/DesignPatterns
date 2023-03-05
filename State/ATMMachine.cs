using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ATMMachine : ATMState
    {
        public ATMState atmMachineState { get; set; }
        public ATMMachine()
        {
            atmMachineState = new DebitCardNotInsertedState();
        }
        public void InsertDebitCard()
        {
            atmMachineState.InsertDebitCard();
            
            if (atmMachineState is DebitCardNotInsertedState)
            {
                atmMachineState = new DebitCardInsertedState();
                
            }
        }
        public void EjectDebitCard()
        {
            atmMachineState.EjectDebitCard();
            

            if (atmMachineState is DebitCardInsertedState)
            {
                atmMachineState = new DebitCardNotInsertedState();
                
            }
        }
        public void EnterPin()
        {
            atmMachineState.EnterPin();
        }
        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }
}
