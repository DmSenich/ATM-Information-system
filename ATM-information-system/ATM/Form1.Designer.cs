namespace ATM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataATM = new System.Windows.Forms.DataGridView();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelBalance = new System.Windows.Forms.Label();
            this.boxNumber = new System.Windows.Forms.TextBox();
            this.numericBalance = new System.Windows.Forms.NumericUpDown();
            this.buttonAddATM = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataATM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataATM
            // 
            this.dataATM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataATM.Location = new System.Drawing.Point(12, 12);
            this.dataATM.Name = "dataATM";
            this.dataATM.RowHeadersWidth = 51;
            this.dataATM.RowTemplate.Height = 24;
            this.dataATM.Size = new System.Drawing.Size(278, 426);
            this.dataATM.TabIndex = 0;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(296, 12);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(53, 16);
            this.LabelNumber.TabIndex = 1;
            this.LabelNumber.Text = "Номер:";
            // 
            // LabelBalance
            // 
            this.LabelBalance.AutoSize = true;
            this.LabelBalance.Location = new System.Drawing.Point(296, 39);
            this.LabelBalance.Name = "LabelBalance";
            this.LabelBalance.Size = new System.Drawing.Size(58, 16);
            this.LabelBalance.TabIndex = 2;
            this.LabelBalance.Text = "Баланс:";
            // 
            // boxNumber
            // 
            this.boxNumber.Location = new System.Drawing.Point(357, 9);
            this.boxNumber.Name = "boxNumber";
            this.boxNumber.Size = new System.Drawing.Size(123, 22);
            this.boxNumber.TabIndex = 3;
            // 
            // numericBalance
            // 
            this.numericBalance.Location = new System.Drawing.Point(357, 37);
            this.numericBalance.Name = "numericBalance";
            this.numericBalance.Size = new System.Drawing.Size(123, 22);
            this.numericBalance.TabIndex = 4;
            // 
            // buttonAddATM
            // 
            this.buttonAddATM.Location = new System.Drawing.Point(296, 65);
            this.buttonAddATM.Name = "buttonAddATM";
            this.buttonAddATM.Size = new System.Drawing.Size(129, 56);
            this.buttonAddATM.TabIndex = 5;
            this.buttonAddATM.Text = "Добавить";
            this.buttonAddATM.UseVisualStyleBackColor = true;
            this.buttonAddATM.Click += new System.EventHandler(this.buttonAddATM_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(431, 65);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 56);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(566, 65);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 56);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAddATM);
            this.Controls.Add(this.numericBalance);
            this.Controls.Add(this.boxNumber);
            this.Controls.Add(this.LabelBalance);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.dataATM);
            this.Name = "Form1";
            this.Text = "ATM-information-system";
            ((System.ComponentModel.ISupportInitialize)(this.dataATM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataATM;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.TextBox boxNumber;
        private System.Windows.Forms.NumericUpDown numericBalance;
        private System.Windows.Forms.Button buttonAddATM;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

