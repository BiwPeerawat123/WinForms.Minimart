namespace WinForms.Minimart
{
    partial class frmCategories
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
            dgvCategories = new DataGridView();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClearForm = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(3, 3);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(642, 646);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellClick += dgvCategories_CellClick;
            dgvCategories.CellContentClick += dgvCategories_CellContentClick;
            dgvCategories.CellMouseDoubleClick += dgvCategories_CellMouseDoubleClick;
            // 
            // txtCategoryID
            // 
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Enabled = false;
            txtCategoryID.Location = new Point(831, 35);
            txtCategoryID.Multiline = true;
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(193, 44);
            txtCategoryID.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(831, 108);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(386, 44);
            txtCategoryName.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(831, 189);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(386, 149);
            txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(700, 30);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 3;
            label1.Text = "รหัสหมวดหมู่ : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(704, 108);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 4;
            label2.Text = "ชื่อหมวดหมู่  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(660, 189);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 5;
            label3.Text = "คำอธิบายหมวดหมู่ : ";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(128, 255, 128);
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(769, 376);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(178, 68);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(989, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 68);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(769, 477);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 68);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "แก้ไข";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(128, 255, 255);
            btnClearForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearForm.Location = new Point(989, 477);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(178, 68);
            btnClearForm.TabIndex = 9;
            btnClearForm.Text = "ล้างฟอร์ม";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 128);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(660, 575);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 62);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 649);
            Controls.Add(btnAdd);
            Controls.Add(btnClearForm);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(dgvCategories);
            Name = "frmCategories";
            Text = "frmCategories";
            WindowState = FormWindowState.Maximized;
            Load += frmCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearForm;
        private Button btnAdd;
    }
}