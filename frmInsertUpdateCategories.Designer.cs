namespace WinForms.Minimart
{
    partial class frmInsertUpdateCategories
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 166);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 11;
            label3.Text = "คำอธิบายหมวดหมู่ : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 85);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 10;
            label2.Text = "ชื่อหมวดหมู่  : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 7);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 9;
            label1.Text = "รหัสหมวดหมู่ : ";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(180, 166);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(386, 149);
            txtDescription.TabIndex = 7;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(180, 85);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(386, 44);
            txtCategoryName.TabIndex = 8;
            // 
            // txtCategoryID
            // 
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Enabled = false;
            txtCategoryID.Location = new Point(180, 12);
            txtCategoryID.Multiline = true;
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(193, 44);
            txtCategoryID.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(122, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 61);
            btnSave.TabIndex = 12;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(368, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(172, 61);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmInsertUpdateCategories
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(782, 511);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Name = "frmInsertUpdateCategories";
            Text = "เพิ่มและปรับปรุง ข้อมูลหมวดหมู่สินค้า";
            Load += frmInsertUpdateCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Button btnSave;
        private Button btnCancel;
    }
}