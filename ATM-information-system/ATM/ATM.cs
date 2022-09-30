using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        string name;
        decimal balance;

        private ATM() { }

        public ATM(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public string Name { get { return name; } set { name = value; } }
        public decimal Balance { get { return balance; } set { balance = value; } }

        public void AddMoney(decimal p)
        {
            if(p < 0)
            {
                return;
            }
            balance += p;
        }
        public void RemMoney(decimal p)
        {
            if(p < 0)
            {
                return ;
            }
            balance -= p;
        }
    }
}
