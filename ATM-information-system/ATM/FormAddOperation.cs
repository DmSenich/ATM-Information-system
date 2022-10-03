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
        public FormAddOperation(List<ATM> atm)
        {
            InitializeComponent();
            foreach (var item in atm)
                comboNumber.Items.Add(item.Name);
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            if (comboNumber.Text != "" && boxAccount.Text != "" && comboTypeOperation.Text != "")
            {
                Operations.Add(new Operation(comboNumber.Text, boxAccount.Text, numericSum.Value, comboTypeOperation.Text == "Внесение в банкомат" ? true : false));
                this.Close();
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
