namespace WinForms.Minimart
{
    partial class frmProducts
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
            dgvProducts = new DataGridView();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            cmbCategoryID = new ComboBox();
            numUD_UnitPrice = new NumericUpDown();
            numUD_UnitsInStock = new NumericUpDown();
            cmbDiscontinued = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 313);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1094, 301);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(141, 38);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(141, 104);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(296, 27);
            txtProductName.TabIndex = 2;
            // 
            // cmbCategoryID
            // 
            cmbCategoryID.FormattingEnabled = true;
            cmbCategoryID.Location = new Point(470, 38);
            cmbCategoryID.Name = "cmbCategoryID";
            cmbCategoryID.Size = new Size(194, 28);
            cmbCategoryID.TabIndex = 3;
            cmbCategoryID.SelectedIndexChanged += cmbCategoryID_SelectedIndexChanged;
            // 
            // numUD_UnitPrice
            // 
            numUD_UnitPrice.Location = new Point(141, 184);
            numUD_UnitPrice.Name = "numUD_UnitPrice";
            numUD_UnitPrice.Size = new Size(226, 27);
            numUD_UnitPrice.TabIndex = 4;
            // 
            // numUD_UnitsInStock
            // 
            numUD_UnitsInStock.Location = new Point(470, 184);
            numUD_UnitsInStock.Name = "numUD_UnitsInStock";
            numUD_UnitsInStock.Size = new Size(204, 27);
            numUD_UnitsInStock.TabIndex = 5;
            // 
            // cmbDiscontinued
            // 
            cmbDiscontinued.FormattingEnabled = true;
            cmbDiscontinued.Items.AddRange(new object[] { "เลิกจำหน่าย", "พร้อมจำหน่าย" });
            cmbDiscontinued.Location = new Point(141, 257);
            cmbDiscontinued.Name = "cmbDiscontinued";
            cmbDiscontinued.Size = new Size(186, 28);
            cmbDiscontinued.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 7;
            label1.Text = "รหัสสินค้า :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 38);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 8;
            label2.Text = "ประเภทสินค้า :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 107);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 9;
            label3.Text = "ชื่อสินค้า :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 184);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 10;
            label4.Text = "ราคา :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 186);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "จำนวน :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 257);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 12;
            label6.Text = "สถานะจำหน่าย :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(784, 56);
            button1.Name = "button1";
            button1.Size = new Size(135, 48);
            button1.TabIndex = 13;
            button1.Text = "เพิ่ม";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(954, 55);
            button2.Name = "button2";
            button2.Size = new Size(135, 48);
            button2.TabIndex = 14;
            button2.Text = "ลบ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Location = new Point(784, 145);
            button3.Name = "button3";
            button3.Size = new Size(135, 48);
            button3.TabIndex = 15;
            button3.Text = "แก้ไข";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 255);
            button4.Location = new Point(954, 145);
            button4.Name = "button4";
            button4.Size = new Size(135, 48);
            button4.TabIndex = 16;
            button4.Text = "เคลียนร์";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 626);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDiscontinued);
            Controls.Add(numUD_UnitsInStock);
            Controls.Add(numUD_UnitPrice);
            Controls.Add(cmbCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(dgvProducts);
            Name = "frmProducts";
            Text = "frmProducts";
            WindowState = FormWindowState.Maximized;
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private ComboBox cmbCategoryID;
        private NumericUpDown numUD_UnitPrice;
        private NumericUpDown numUD_UnitsInStock;
        private ComboBox cmbDiscontinued;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}