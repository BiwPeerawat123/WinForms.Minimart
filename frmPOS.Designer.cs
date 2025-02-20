namespace WinForms.Minimart
{
    partial class frmPOS
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
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            lblNetPrice = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtTotal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lsvProducts = new ListView();
            groupBox1 = new GroupBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtEmployeeID.Location = new Point(211, 46);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(111, 23);
            txtEmployeeID.TabIndex = 0;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(542, 46);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(284, 27);
            txtEmployeeName.TabIndex = 1;
            // 
            // lblNetPrice
            // 
            lblNetPrice.BackColor = Color.RoyalBlue;
            lblNetPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNetPrice.Location = new Point(905, 49);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(355, 88);
            lblNetPrice.TabIndex = 2;
            lblNetPrice.Text = "....";
            lblNetPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 49);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "รหัสพนักงาน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 49);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "ชื่อ - สกุล";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(20, 51);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(227, 27);
            txtProductID.TabIndex = 5;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(270, 51);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(154, 27);
            txtProductName.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(444, 51);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(121, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(582, 51);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(115, 27);
            txtQuantity.TabIndex = 8;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(721, 51);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(110, 27);
            txtTotal.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 28);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "รหัสสินค้า";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 28);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 11;
            label5.Text = "ชื่อสินค้า";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(444, 28);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 12;
            label6.Text = "ราคาขาย";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(582, 28);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "จำนวน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(721, 23);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 14;
            label8.Text = "รวมเป็นเงิน";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(940, 234);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 43);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(940, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 43);
            btnClear.TabIndex = 16;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(940, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 43);
            btnSave.TabIndex = 17;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(940, 471);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 43);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "ยกเลิกรายการสั่งซื้อ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lsvProducts
            // 
            lsvProducts.Location = new Point(20, 98);
            lsvProducts.Name = "lsvProducts";
            lsvProducts.Size = new Size(782, 386);
            lsvProducts.TabIndex = 19;
            lsvProducts.UseCompatibleStateImageBehavior = false;
            lsvProducts.DoubleClick += lsvProducts_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvProducts);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 538);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการสั่งซื้อสินค้า";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(905, 19);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 21;
            label9.Text = "รวมเป็นเงิน";
            // 
            // frmPOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 657);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNetPrice);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Name = "frmPOS";
            Text = "จำหน่ายสินค้า";
            Load += frmPOS_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private Label lblNetPrice;
        private Label label2;
        private Label label3;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtTotal;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private ListView lsvProducts;
        private GroupBox groupBox1;
        private Label label9;
    }
}