using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class FormAddOperation : Form
    {
        public List<Operation> Operations = new List<Operation>();
        public List<ATM> ATMs = new List<ATM>();
        public FormAddOperation(List<ATM> atm, List<Operation> op)
        {
            InitializeComponent();
            ATMs = atm;
            Operations = op;
            foreach (var item in atm)
                comboNumber.Items.Add(item.Name);
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            if (comboNumber.Text != "" && boxAccount.Text != "" && comboTypeOperation.Text != "")
            {
                foreach (var item in ATMs)
                {
                    if (item.Name == comboNumber.Text)
                    {
                        if (comboTypeOperation.Text == "Снятие наличных")
                        {
                            if (item.Balance >= numericSum.Value)
                            {
                                Operations.Add(new Operation(comboNumber.Text, boxAccount.Text, numericSum.Value, comboTypeOperation.Text == "Внесение в банкомат" ? true : false));
                                item.RemMoney(numericSum.Value);
                                this.Close();
                            }
                            else
                                MessageBox.Show("В банкомате не хватает денег.");
                        }
                        else
                        {
                            Operations.Add(new Operation(comboNumber.Text, boxAccount.Text, numericSum.Value, comboTypeOperation.Text == "Внесение в банкомат" ? true : false));
                            item.AddMoney(numericSum.Value);
                            this.Close();
                        }
                    }
                }
            }
            else
                MessageBox.Show("Заполните все поля.");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
