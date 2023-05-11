namespace Lab10
{
    partial class DatabaseApp
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
            this.idTb = new System.Windows.Forms.TextBox();
            this.seriesTb = new System.Windows.Forms.TextBox();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invoicesLv = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Series = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addInvoiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(81, 43);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(172, 22);
            this.idTb.TabIndex = 0;
            // 
            // seriesTb
            // 
            this.seriesTb.Location = new System.Drawing.Point(81, 83);
            this.seriesTb.Name = "seriesTb";
            this.seriesTb.Size = new System.Drawing.Size(172, 22);
            this.seriesTb.TabIndex = 1;
            // 
            // amountTb
            // 
            this.amountTb.Location = new System.Drawing.Point(81, 127);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(172, 22);
            this.amountTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Series:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount:";
            // 
            // invoicesLv
            // 
            this.invoicesLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Series,
            this.Amount});
            this.invoicesLv.HideSelection = false;
            this.invoicesLv.Location = new System.Drawing.Point(12, 171);
            this.invoicesLv.Name = "invoicesLv";
            this.invoicesLv.Size = new System.Drawing.Size(404, 176);
            this.invoicesLv.TabIndex = 6;
            this.invoicesLv.UseCompatibleStateImageBehavior = false;
            this.invoicesLv.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Series
            // 
            this.Series.Text = "Series";
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // addInvoiceBtn
            // 
            this.addInvoiceBtn.Location = new System.Drawing.Point(289, 46);
            this.addInvoiceBtn.Name = "addInvoiceBtn";
            this.addInvoiceBtn.Size = new System.Drawing.Size(127, 23);
            this.addInvoiceBtn.TabIndex = 7;
            this.addInvoiceBtn.Text = "Add Invoice";
            this.addInvoiceBtn.UseVisualStyleBackColor = true;
            this.addInvoiceBtn.Click += new System.EventHandler(this.addInvoiceBtn_Click);
            // 
            // DatabaseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.addInvoiceBtn);
            this.Controls.Add(this.invoicesLv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.seriesTb);
            this.Controls.Add(this.idTb);
            this.Name = "DatabaseApp";
            this.Text = "Database App";
            this.Load += new System.EventHandler(this.DatabaseApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.TextBox seriesTb;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView invoicesLv;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Series;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Button addInvoiceBtn;
    }
}

