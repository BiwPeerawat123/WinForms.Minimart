namespace WinForms.Minimart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            minimartToolStripMenuItem = new ToolStripMenuItem();
            จดการขอมลหมวดหมสนคาToolStripMenuItem = new ToolStripMenuItem();
            pOSToolStripMenuItem = new ToolStripMenuItem();
            จดการขอมลพนกงานToolStripMenuItem = new ToolStripMenuItem();
            จดการขอมลสนคาToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { minimartToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1236, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // minimartToolStripMenuItem
            // 
            minimartToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { จดการขอมลหมวดหมสนคาToolStripMenuItem, pOSToolStripMenuItem, จดการขอมลพนกงานToolStripMenuItem, จดการขอมลสนคาToolStripMenuItem });
            minimartToolStripMenuItem.Name = "minimartToolStripMenuItem";
            minimartToolStripMenuItem.Size = new Size(83, 24);
            minimartToolStripMenuItem.Text = "Minimart";
            // 
            // จดการขอมลหมวดหมสนคาToolStripMenuItem
            // 
            จดการขอมลหมวดหมสนคาToolStripMenuItem.Name = "จดการขอมลหมวดหมสนคาToolStripMenuItem";
            จดการขอมลหมวดหมสนคาToolStripMenuItem.Size = new Size(247, 26);
            จดการขอมลหมวดหมสนคาToolStripMenuItem.Text = "จัดการข้อมูลหมวดหมู่สินค้า";
            จดการขอมลหมวดหมสนคาToolStripMenuItem.Click += จดการขอมลหมวดหมสนคาToolStripMenuItem_Click;
            // 
            // pOSToolStripMenuItem
            // 
            pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            pOSToolStripMenuItem.Size = new Size(247, 26);
            pOSToolStripMenuItem.Text = "POS";
            pOSToolStripMenuItem.Click += pOSToolStripMenuItem_Click;
            // 
            // จดการขอมลพนกงานToolStripMenuItem
            // 
            จดการขอมลพนกงานToolStripMenuItem.Name = "จดการขอมลพนกงานToolStripMenuItem";
            จดการขอมลพนกงานToolStripMenuItem.Size = new Size(247, 26);
            จดการขอมลพนกงานToolStripMenuItem.Text = "จัดการข้อมูลพนักงาน";
            จดการขอมลพนกงานToolStripMenuItem.Click += จดการขอมลพนกงานToolStripMenuItem_Click;
            // 
            // จดการขอมลสนคาToolStripMenuItem
            // 
            จดการขอมลสนคาToolStripMenuItem.Name = "จดการขอมลสนคาToolStripMenuItem";
            จดการขอมลสนคาToolStripMenuItem.Size = new Size(247, 26);
            จดการขอมลสนคาToolStripMenuItem.Text = "จัดการข้อมูลสินค้า";
            จดการขอมลสนคาToolStripMenuItem.Click += จดการขอมลสนคาToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 579);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "เมนูหลัก";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem minimartToolStripMenuItem;
        private ToolStripMenuItem จดการขอมลหมวดหมสนคาToolStripMenuItem;
        private ToolStripMenuItem pOSToolStripMenuItem;
        private ToolStripMenuItem จดการขอมลพนกงานToolStripMenuItem;
        private ToolStripMenuItem จดการขอมลสนคาToolStripMenuItem;
    }
}
