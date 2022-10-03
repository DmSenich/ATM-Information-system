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
    public partial class FormViewHistoryOperation : Form
    {
        public FormViewHistoryOperation(List<Operation> op)
        {
            InitializeComponent();
            dataOperation.ColumnCount = 4;
            dataOperation.Columns[0].HeaderText = "Номер банкомата";
            dataOperation.Columns[1].HeaderText = "Номер счета";
            dataOperation.Columns[2].HeaderText = "Сумма операции";
            dataOperation.Columns[3].HeaderText = "Тип операции";
            foreach (var item in op)
                dataOperation.Rows.Add(item.NumBank, item.Person, item.MoneyTransfer, item.Doing ? "Внесение в банкомат" : "Снятие наличных");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
