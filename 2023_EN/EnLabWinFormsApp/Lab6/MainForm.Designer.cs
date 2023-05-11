using EnLabWinFormsApp.Entities;
using System;

namespace EnLabWinFormsApp
{
    partial class MainForm
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
            this.displacement = new System.Windows.Forms.NumericUpDown();
            this.topSpeed = new System.Windows.Forms.NumericUpDown();
            this.manufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.carsLv = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDisplacement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTopSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialization = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarDialogBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.serialization.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displacement
            // 
            this.displacement.Location = new System.Drawing.Point(130, 37);
            this.displacement.Maximum = new decimal(new int[] {
            100000,
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
            this.displacement.Validating += new System.ComponentModel.CancelEventHandler(this.displacement_Validating);
            this.displacement.Validated += new System.EventHandler(this.displacement_Validated);
            // 
            // topSpeed
            // 
            this.topSpeed.Location = new System.Drawing.Point(130, 80);
            this.topSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.topSpeed.Name = "topSpeed";
            this.topSpeed.Size = new System.Drawing.Size(324, 22);
            this.topSpeed.TabIndex = 1;
            this.topSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.topSpeed_Validating);
            this.topSpeed.Validated += new System.EventHandler(this.topSpeed_Validated);
            // 
            // manufacturer
            // 
            this.manufacturer.FormattingEnabled = true;
            this.manufacturer.Location = new System.Drawing.Point(130, 121);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(324, 24);
            this.manufacturer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Displacement:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Top speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manufacturer:";
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(583, 38);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(132, 23);
            this.addCarBtn.TabIndex = 6;
            this.addCarBtn.Text = "Add Car";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // carsLv
            // 
            this.carsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colDisplacement,
            this.colTopSpeed,
            this.colManufacturer});
            this.carsLv.FullRowSelect = true;
            this.carsLv.HideSelection = false;
            this.carsLv.Location = new System.Drawing.Point(29, 172);
            this.carsLv.MultiSelect = false;
            this.carsLv.Name = "carsLv";
            this.carsLv.Size = new System.Drawing.Size(741, 270);
            this.carsLv.TabIndex = 7;
            this.carsLv.UseCompatibleStateImageBehavior = false;
            this.carsLv.View = System.Windows.Forms.View.Details;
            this.carsLv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.carsLv_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colDisplacement
            // 
            this.colDisplacement.Text = "Displacement";
            this.colDisplacement.Width = 187;
            // 
            // colTopSpeed
            // 
            this.colTopSpeed.Text = "Top speed";
            this.colTopSpeed.Width = 165;
            // 
            // colManufacturer
            // 
            this.colManufacturer.Text = "Manufacturer";
            this.colManufacturer.Width = 173;
            // 
            // serialization
            // 
            this.serialization.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.serialization.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.serialization.Name = "serialization";
            this.serialization.Size = new System.Drawing.Size(120, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 24);
            this.toolStripMenuItem1.Text = "XML";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 24);
            this.toolStripMenuItem2.Text = "Binary";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 24);
            this.toolStripMenuItem3.Text = "CSV";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // addCarDialogBtn
            // 
            this.addCarDialogBtn.Location = new System.Drawing.Point(583, 77);
            this.addCarDialogBtn.Name = "addCarDialogBtn";
            this.addCarDialogBtn.Size = new System.Drawing.Size(132, 23);
            this.addCarDialogBtn.TabIndex = 10;
            this.addCarDialogBtn.Text = "Add Car (Dialog)";
            this.addCarDialogBtn.UseVisualStyleBackColor = true;
            this.addCarDialogBtn.Click += new System.EventHandler(this.addCarDialogBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(583, 115);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 23);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete Car";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.ContextMenuStrip = this.serialization;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addCarDialogBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.carsLv);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.topSpeed);
            this.Controls.Add(this.displacement);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.displacement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.serialization.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView carsLv;
        private System.Windows.Forms.ColumnHeader colDisplacement;
        private System.Windows.Forms.ColumnHeader colTopSpeed;
        private System.Windows.Forms.ColumnHeader colManufacturer;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ContextMenuStrip serialization;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.Button addCarDialogBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

