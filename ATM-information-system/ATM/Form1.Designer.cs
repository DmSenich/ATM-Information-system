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
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.buttonViewHistroriOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataATM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataATM
            // 
            this.dataATM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataATM.Location = new System.Drawing.Point(12, 12);
            this.dataATM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataATM.Name = "dataATM";
            this.dataATM.RowHeadersWidth = 51;
            this.dataATM.RowTemplate.Height = 24;
            this.dataATM.Size = new System.Drawing.Size(277, 426);
            this.dataATM.TabIndex = 0;
            this.dataATM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataATM_CellClick);
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
            this.boxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxNumber.Name = "boxNumber";
            this.boxNumber.Size = new System.Drawing.Size(123, 22);
            this.boxNumber.TabIndex = 3;
            // 
            // numericBalance
            // 
            this.numericBalance.Location = new System.Drawing.Point(357, 37);
            this.numericBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericBalance.Name = "numericBalance";
            this.numericBalance.Size = new System.Drawing.Size(123, 22);
            this.numericBalance.TabIndex = 4;
            // 
            // buttonAddATM
            // 
            this.buttonAddATM.Location = new System.Drawing.Point(296, 65);
            this.buttonAddATM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddATM.Name = "buttonAddATM";
            this.buttonAddATM.Size = new System.Drawing.Size(129, 57);
            this.buttonAddATM.TabIndex = 5;
            this.buttonAddATM.Text = "Добавить";
            this.buttonAddATM.UseVisualStyleBackColor = true;
            this.buttonAddATM.Click += new System.EventHandler(this.buttonAddATM_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(431, 65);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 57);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(565, 65);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 57);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.Location = new System.Drawing.Point(299, 220);
            this.buttonAddOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(129, 57);
            this.buttonAddOperation.TabIndex = 8;
            this.buttonAddOperation.Text = "Добавить операцию";
            this.buttonAddOperation.UseVisualStyleBackColor = true;
            // 
            // buttonViewHistroriOperation
            // 
            this.buttonViewHistroriOperation.Location = new System.Drawing.Point(435, 220);
            this.buttonViewHistroriOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewHistroriOperation.Name = "buttonViewHistroriOperation";
            this.buttonViewHistroriOperation.Size = new System.Drawing.Size(129, 57);
            this.buttonViewHistroriOperation.TabIndex = 9;
            this.buttonViewHistroriOperation.Text = "Посмотреть историю опериций";
            this.buttonViewHistroriOperation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewHistroriOperation);
            this.Controls.Add(this.buttonAddOperation);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAddATM);
            this.Controls.Add(this.numericBalance);
            this.Controls.Add(this.boxNumber);
            this.Controls.Add(this.LabelBalance);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.dataATM);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.Button buttonViewHistroriOperation;
    }
}

