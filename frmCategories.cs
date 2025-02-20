using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Minimart
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = dgvCategories.CurrentRow.Cells["categoryID"].Value.ToString();
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells["categoryName"].Value.ToString();
            txtDescription.Text = dgvCategories.CurrentRow.Cells["description"].Value.ToString();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand com;

        private void showdata()
        {
            string sql = "Select * from Categories";
            com = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCategories.DataSource = ds.Tables[0];
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showdata();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCategoryName.Focus();
            txtCategoryID.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ชื่อหมวดหมู่ต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return;
            }

            string sql = "Insert into Categories values(@categoryName, @Description)";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());
            com.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            if (com.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            //Update
            //check Name is not null
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("เลือกหมวดหมู่ที่ต้องการแก้ไขก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ชื่อหมวดหมู่ต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return;
            }
            //insert data in database
            string sql = "Update Categories set CategoryName = @categoryName,description = @Description Where CategoryID = @categoryID";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());
            com.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            com.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            if (com.ExecuteNonQuery() > 0)
            {
                showdata();//display

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("เลือกหมวดหมู่ที่ต้องการลบก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            //ask 
            if (MessageBox.Show("ต้องการลบหรือไม่", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            //delete value from database
            string sql = "delete From Categories where CategoryID = @categoryID";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            try
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    showdata();
                    btnClearForm.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด :" + Environment.NewLine + ex.Message, "ไม่สามารถลบข้อมูลได้");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInsertUpdateCategories f = new frmInsertUpdateCategories();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void dgvCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmInsertUpdateCategories f = new frmInsertUpdateCategories();
            f.status = " update";
            var dgv = dgvCategories.CurrentRow.Cells;
            f.categoryID = Convert.ToInt16(dgv["CategoryID"].Value);
            f.categoryName = dgv["CategoryName"].Value.ToString();
            f.description = dgv["Description"].Value.ToString();
            f.ShowDialog();
            showdata();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ตรวจสอบว่าผู้ใช้คลิกที่แถวที่มีข้อมูล (ไม่ใช่ Header)
            if (e.RowIndex >= 0)
            {
                // เลือกแถวที่ถูกคลิก
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];

                // นำค่าจากแต่ละ Cell ไปใส่ใน TextBox
                txtCategoryID.Text = row.Cells["categoryID"].Value.ToString();
                txtCategoryName.Text = row.Cells["categoryName"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
            }
        }
    }
}
