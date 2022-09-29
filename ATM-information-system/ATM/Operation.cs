using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Operation
    {
        string addressee, recipient;
        int moneyTransfer;

        private Operation() { }
        public Operation(string recipient, string addressee, int moneyTransfer)
        {
            this.recipient = recipient;
            this.addressee = addressee;
            this.moneyTransfer = moneyTransfer;
        }
    }
}
