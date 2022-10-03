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
    public partial class Form1 : Form
    {
        public List<ATM> ATMs = new List<ATM>();
        public List<Operation> operations = new List<Operation>();
        public Form1()
        {
            InitializeComponent();
            dataATM.ColumnCount = 2;
            numericBalance.Maximum = 99999999;
        }

        private void UpdateData()
        {
            dataATM.Rows.Clear();
            foreach (var item in ATMs)
                dataATM.Rows.Add(item.Name, item.Balance);
        }

        private void buttonAddATM_Click(object sender, EventArgs e)
        {
            if (boxNumber.Text != "")
            {
                ATMs.Add(new ATM(boxNumber.Text, Convert.ToDecimal(numericBalance.Value)));
                UpdateData();
            }
            else
                MessageBox.Show("Введите номер банкомата.");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            foreach (var item in ATMs)
                if (dataATM.Rows[dataATM.CurrentCell.RowIndex].Cells[0].Value.ToString() == item.Name)
                {
                    item.Name = boxNumber.Text;
                    item.Balance = numericBalance.Value;
                    break;
                }
            UpdateData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in ATMs)
            {
                if (dataATM.Rows[dataATM.CurrentCell.RowIndex].Cells[0].Value.ToString() == item.Name)
                {
                    ATMs.Remove(item);
                    break;
                }
            }
            UpdateData();
        }

        private void dataATM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataATM.RowCount - 1)
            {
                boxNumber.Text = dataATM.Rows[e.RowIndex].Cells[0].Value.ToString();
                numericBalance.Value = Convert.ToDecimal(dataATM.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            FormAddOperation form = new FormAddOperation(ATMs, operations);
            form.ShowDialog();
            operations = form.Operations;
            ATMs = form.ATMs;
            UpdateData();
        }

        private void buttonViewHistroriOperation_Click(object sender, EventArgs e)
        {
            FormViewHistoryOperation form = new FormViewHistoryOperation(operations);
            form.ShowDialog();
        }
    }
}
