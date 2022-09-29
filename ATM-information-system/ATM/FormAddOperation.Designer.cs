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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.comboBoxtTypeOperation = new System.Windows.Forms.ComboBox();
            this.comboBoxNumberATM = new System.Windows.Forms.ComboBox();
            this.numericSum = new System.Windows.Forms.NumericUpDown();
            this.boxAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericSum)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(142, 134);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 64);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.Location = new System.Drawing.Point(9, 134);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(127, 64);
            this.buttonAddOperation.TabIndex = 18;
            this.buttonAddOperation.Text = "Добавить операцию";
            this.buttonAddOperation.UseVisualStyleBackColor = true;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // comboBoxtTypeOperation
            // 
            this.comboBoxtTypeOperation.FormattingEnabled = true;
            this.comboBoxtTypeOperation.Location = new System.Drawing.Point(139, 65);
            this.comboBoxtTypeOperation.Name = "comboBoxtTypeOperation";
            this.comboBoxtTypeOperation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxtTypeOperation.TabIndex = 17;
            // 
            // comboBoxNumberATM
            // 
            this.comboBoxNumberATM.FormattingEnabled = true;
            this.comboBoxNumberATM.Location = new System.Drawing.Point(138, 7);
            this.comboBoxNumberATM.Name = "comboBoxNumberATM";
            this.comboBoxNumberATM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumberATM.TabIndex = 16;
            // 
            // numericSum
            // 
            this.numericSum.Location = new System.Drawing.Point(140, 95);
            this.numericSum.Name = "numericSum";
            this.numericSum.Size = new System.Drawing.Size(120, 20);
            this.numericSum.TabIndex = 15;
            // 
            // boxAccount
            // 
            this.boxAccount.Location = new System.Drawing.Point(138, 37);
            this.boxAccount.Name = "boxAccount";
            this.boxAccount.Size = new System.Drawing.Size(120, 20);
            this.boxAccount.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Сумма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тип операции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер счета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер банкомата:";
            // 
            // FormAddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 208);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddOperation);
            this.Controls.Add(this.comboBoxtTypeOperation);
            this.Controls.Add(this.comboBoxNumberATM);
            this.Controls.Add(this.numericSum);
            this.Controls.Add(this.boxAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddOperation";
            this.Text = "FormAddOperation";
            ((System.ComponentModel.ISupportInitialize)(this.numericSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.ComboBox comboBoxtTypeOperation;
        private System.Windows.Forms.ComboBox comboBoxNumberATM;
        private System.Windows.Forms.NumericUpDown numericSum;
        private System.Windows.Forms.TextBox boxAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}