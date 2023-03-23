using Lab4.Entities;
using System;

namespace Lab4
{
    partial class Form1
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
            this.displacement = new System.Windows.Forms.NumericUpDown();
            this.topSpeed = new System.Windows.Forms.NumericUpDown();
            this.manufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // displacement
            // 
            this.displacement.Location = new System.Drawing.Point(130, 23);
            this.displacement.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.displacement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.displacement.Name = "displacement";
            this.displacement.Size = new System.Drawing.Size(324, 22);
            this.displacement.TabIndex = 0;
            this.displacement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // topSpeed
            // 
            this.topSpeed.Location = new System.Drawing.Point(130, 66);
            this.topSpeed.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.topSpeed.Name = "topSpeed";
            this.topSpeed.Size = new System.Drawing.Size(324, 22);
            this.topSpeed.TabIndex = 1;
            // 
            // manufacturer
            // 
            this.manufacturer.FormattingEnabled = true;
            this.manufacturer.Location = new System.Drawing.Point(130, 107);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(324, 24);
            this.manufacturer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Displacement:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Top speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manufacturer:";
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(606, 105);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(75, 23);
            this.addCarBtn.TabIndex = 6;
            this.addCarBtn.Text = "Add Car";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.topSpeed);
            this.Controls.Add(this.displacement);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.displacement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown displacement;
        private System.Windows.Forms.NumericUpDown topSpeed;
        private System.Windows.Forms.ComboBox manufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCarBtn;
    }
}

