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
        int balance;

        private ATM() { }

        public ATM(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }

        string Name { get { return name; } }
        public int Balance { get { return balance; } }

        public void AddMoney(int p)
        {
            if(p < 0)
            {
                return;
            }
            balance += p;
        }
        public void RemMoney(int p)
        {
            if(p < 0)
            {
                return ;
            }
            balance -= p;
        }
    }
}
