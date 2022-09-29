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
        List<ATM> ATMs = new List<ATM>();
        public Form1()
        {
            InitializeComponent();
            dataATM.ColumnCount = 2;
            numericBalance.Minimum = 0;
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
                ATMs.Add(new ATM(boxNumber.Text, numericBalance.Value));
                UpdateData();
            }
            else
                MessageBox.Show("Введите номер банкомата.");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (boxNumber.Text != "")
            {
                foreach (var item in ATMs)
                    if(item.Name == dataATM.Rows[dataATM.CurrentCell.RowIndex].Cells[0].Value.ToString())
                    {
                        item.Name = boxNumber.Text;
                        item.Balance = numericBalance.Value;
                        break;
                    }
                UpdateData();
            }
            else
                MessageBox.Show("Выберите банкомат из списка.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (boxNumber.Text != "")
            {
                foreach (var item in ATMs)
                    if (item.Name == dataATM.Rows[dataATM.CurrentCell.RowIndex].Cells[0].Value.ToString())
                    {
                        ATMs.Remove(item);
                        break;
                    }
                UpdateData();
            }
            else
                MessageBox.Show("Выберите банкомат из списка.");
        }

        private void dataATM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataATM.Rows[e.RowIndex].Cells[0].Value != null)
            {
                boxNumber.Text = dataATM.Rows[e.RowIndex].Cells[0].Value.ToString();
                numericBalance.Value = Convert.ToDecimal(dataATM.Rows[e.RowIndex].Cells[1].Value);
            }
        }
    }
}
