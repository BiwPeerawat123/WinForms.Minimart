namespace WinForms.Minimart
{
    partial class frmEmployees
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
            dgvEmployees = new DataGridView();
            txtEmployeeID = new TextBox();
            cmbTitle = new ComboBox();
            txtFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClearForm = new Button();
            cmbPosition = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(6, 27);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(1078, 310);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(143, 361);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(160, 27);
            txtEmployeeID.TabIndex = 1;
            txtEmployeeID.TextChanged += txtEmployeeID_TextChanged;
            // 
            // cmbTitle
            // 
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Items.AddRange(new object[] { "นาย", "นางสาว", "นาง" });
            cmbTitle.Location = new Point(395, 360);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(160, 28);
            cmbTitle.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(650, 360);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(334, 27);
            txtFirstName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 368);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "คำนำหน้า :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 364);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 7;
            label2.Text = "รหัสพนักงาน :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(611, 363);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 8;
            label3.Text = "ชื่อ :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(650, 411);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(334, 27);
            txtLastName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 411);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "นามสกุล :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 442);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 11;
            label5.Text = "ตำแหน่ง :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(143, 492);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(215, 27);
            txtUserName.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 547);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(215, 27);
            txtPassword.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 492);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 14;
            label6.Text = "ชื่อผู้ใช้ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 554);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 15;
            label7.Text = "รหัสผ่าน :";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(128, 255, 128);
            btnInsert.Font = new Font("Segoe UI", 12F);
            btnInsert.Location = new Point(646, 492);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 58);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(824, 492);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 58);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(646, 587);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 58);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "แก้ไข";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(128, 255, 255);
            btnClearForm.Font = new Font("Segoe UI", 12F);
            btnClearForm.Location = new Point(824, 587);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(146, 58);
            btnClearForm.TabIndex = 19;
            btnClearForm.Text = "เคลียร์";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Sale Manager", "Sale Representative" });
            cmbPosition.Location = new Point(143, 442);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(160, 28);
            cmbPosition.TabIndex = 20;
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 658);
            Controls.Add(cmbPosition);
            Controls.Add(btnClearForm);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(cmbTitle);
            Controls.Add(txtEmployeeID);
            Controls.Add(dgvEmployees);
            Name = "frmEmployees";
            Text = "frmEmployees";
            WindowState = FormWindowState.Maximized;
            Load += frmEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private TextBox txtEmployeeID;
        private ComboBox cmbTitle;
        private TextBox txtFirstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label6;
        private Label label7;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearForm;
        private ComboBox cmbPosition;
    }
}