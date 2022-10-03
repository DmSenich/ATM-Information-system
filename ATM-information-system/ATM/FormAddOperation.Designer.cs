namespace ATM
{
    partial class FormAddOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNumber = new System.Windows.Forms.ComboBox();
            this.comboTypeOperation = new System.Windows.Forms.ComboBox();
            this.numericSum = new System.Windows.Forms.NumericUpDown();
            this.boxAccount = new System.Windows.Forms.TextBox();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер банкомата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер счета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма операции:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип операции:";
            // 
            // comboNumber
            // 
            this.comboNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNumber.FormattingEnabled = true;
            this.comboNumber.Location = new System.Drawing.Point(145, 6);
            this.comboNumber.Name = "comboNumber";
            this.comboNumber.Size = new System.Drawing.Size(121, 24);
            this.comboNumber.TabIndex = 4;
            // 
            // comboTypeOperation
            // 
            this.comboTypeOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeOperation.FormattingEnabled = true;
            this.comboTypeOperation.Items.AddRange(new object[] {
            "Внесение в банкомат",
            "Снятие наличных"});
            this.comboTypeOperation.Location = new System.Drawing.Point(145, 92);
            this.comboTypeOperation.Name = "comboTypeOperation";
            this.comboTypeOperation.Size = new System.Drawing.Size(121, 24);
            this.comboTypeOperation.TabIndex = 5;
            // 
            // numericSum
            // 
            this.numericSum.Location = new System.Drawing.Point(146, 64);
            this.numericSum.Name = "numericSum";
            this.numericSum.Size = new System.Drawing.Size(120, 22);
            this.numericSum.TabIndex = 6;
            // 
            // boxAccount
            // 
            this.boxAccount.Location = new System.Drawing.Point(146, 36);
            this.boxAccount.Name = "boxAccount";
            this.boxAccount.Size = new System.Drawing.Size(120, 22);
            this.boxAccount.TabIndex = 7;
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.Location = new System.Drawing.Point(12, 131);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(127, 66);
            this.buttonAddOperation.TabIndex = 8;
            this.buttonAddOperation.Text = "Добавить операцию";
            this.buttonAddOperation.UseVisualStyleBackColor = true;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(146, 131);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 66);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Закрыть";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 202);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddOperation);
            this.Controls.Add(this.boxAccount);
            this.Controls.Add(this.numericSum);
            this.Controls.Add(this.comboTypeOperation);
            this.Controls.Add(this.comboNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddOperation";
            this.Text = "Добавить операцию";
            ((System.ComponentModel.ISupportInitialize)(this.numericSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboNumber;
        private System.Windows.Forms.ComboBox comboTypeOperation;
        private System.Windows.Forms.NumericUpDown numericSum;
        private System.Windows.Forms.TextBox boxAccount;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.Button buttonBack;
    }
}