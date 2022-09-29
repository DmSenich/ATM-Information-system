using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Operation
    {
        string person, numBank;
        decimal moneyTransfer;
        bool doing;

        private Operation() { }
        public Operation(string numBank, string person, decimal moneyTransfer, bool d)
        {
            this.numBank = numBank;
            this.person = person;
            this.moneyTransfer = moneyTransfer;
            this.doing = d;
        }
        public string Person { get { return person; } }
        public string NumBank { get { return numBank; } }
        public decimal MoneyTransfer { get { return moneyTransfer; } }
        public bool Doing { get { return doing; } }

        public string DoingSt()
        {
            string st;
            if (Doing)
            {
                st = "Внести в банкомант";
            }
            else
            {
                st = "Снять наличные";
            }
            return st;
        }
    }
}
