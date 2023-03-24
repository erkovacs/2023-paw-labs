using RoLabWinFormsApp.Entities;
using System;

namespace RoLabWinFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.species = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addAnimalBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.animalsLv = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(111, 22);
            this.id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(270, 22);
            this.id.TabIndex = 0;
            this.id.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.id.Validating += new System.ComponentModel.CancelEventHandler(this.id_Validating);
            this.id.Validated += new System.EventHandler(this.id_Validated);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(111, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(270, 22);
            this.name.TabIndex = 1;
            this.name.Validating += new System.ComponentModel.CancelEventHandler(this.name_Validating);
            this.name.Validated += new System.EventHandler(this.name_Validated);
            // 
            // species
            // 
            this.species.FormattingEnabled = true;
            this.species.Location = new System.Drawing.Point(111, 61);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(270, 24);
            this.species.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Species:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // addAnimalBtn
            // 
            this.addAnimalBtn.Location = new System.Drawing.Point(546, 102);
            this.addAnimalBtn.Name = "addAnimalBtn";
            this.addAnimalBtn.Size = new System.Drawing.Size(148, 23);
            this.addAnimalBtn.TabIndex = 6;
            this.addAnimalBtn.Text = "Add Animal";
            this.addAnimalBtn.UseVisualStyleBackColor = true;
            this.addAnimalBtn.Click += new System.EventHandler(this.addAnimalBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // animalsLv
            // 
            this.animalsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colSpecies,
            this.colName});
            this.animalsLv.HideSelection = false;
            this.animalsLv.Location = new System.Drawing.Point(27, 161);
            this.animalsLv.Name = "animalsLv";
            this.animalsLv.Size = new System.Drawing.Size(738, 259);
            this.animalsLv.TabIndex = 7;
            this.animalsLv.UseCompatibleStateImageBehavior = false;
            this.animalsLv.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 68;
            // 
            // colSpecies
            // 
            this.colSpecies.Text = "Species";
            this.colSpecies.Width = 174;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 224;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.animalsLv);
            this.Controls.Add(this.addAnimalBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.species);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox species;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addAnimalBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView animalsLv;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colSpecies;
        private System.Windows.Forms.ColumnHeader colName;
    }
}

