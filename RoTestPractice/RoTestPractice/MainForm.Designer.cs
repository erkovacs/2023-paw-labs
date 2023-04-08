namespace RoTestPractice
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
            this.doctorsTv = new System.Windows.Forms.TreeView();
            this.addBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorsTv
            // 
            this.doctorsTv.Location = new System.Drawing.Point(29, 166);
            this.doctorsTv.Name = "doctorsTv";
            this.doctorsTv.Size = new System.Drawing.Size(738, 206);
            this.doctorsTv.TabIndex = 0;
            this.doctorsTv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.doctorsTv_MouseDoubleClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(633, 403);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add doctor";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem,
            this.serializeXMLToolStripMenuItem,
            this.deserializeXMLToolStripMenuItem,
            this.serializeCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // serializeXMLToolStripMenuItem
            // 
            this.serializeXMLToolStripMenuItem.Name = "serializeXMLToolStripMenuItem";
            this.serializeXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializeXMLToolStripMenuItem.Text = "Serialize (XML)";
            this.serializeXMLToolStripMenuItem.Click += new System.EventHandler(this.serializeXMLToolStripMenuItem_Click);
            // 
            // deserializeXMLToolStripMenuItem
            // 
            this.deserializeXMLToolStripMenuItem.Name = "deserializeXMLToolStripMenuItem";
            this.deserializeXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializeXMLToolStripMenuItem.Text = "Deserialize (XML)";
            this.deserializeXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializeXMLToolStripMenuItem_Click);
            // 
            // serializeCSVToolStripMenuItem
            // 
            this.serializeCSVToolStripMenuItem.Name = "serializeCSVToolStripMenuItem";
            this.serializeCSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializeCSVToolStripMenuItem.Text = "Serialize (CSV)";
            this.serializeCSVToolStripMenuItem.Click += new System.EventHandler(this.serializeCSVToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.doctorsTv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Operating Room";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView doctorsTv;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeCSVToolStripMenuItem;
    }
}

