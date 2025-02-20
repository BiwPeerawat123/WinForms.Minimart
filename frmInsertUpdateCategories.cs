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
    public partial class frmInsertUpdateCategories : Form
    {
        public frmInsertUpdateCategories()
        {
            InitializeComponent();
        }

        //----property---
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public string status { get; set; }  //--- เอาไว้รับสถานะ

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(status == "insert")
            {
                InsertCategory();
            }
            else if(status == "update")
            {
                UpdateCategory();
            }
        }

        private void InsertCategory()
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
            com.ExecuteNonQuery();
            this.Close();
        }
        private void UpdateCategory()
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("เลือกหมวดหมู่ที่ต้องการลบก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ต้องการลบหรือไม่", "โปรดยืนยัน");
                return;
            }

            string sql = "Update Categories set CategoryName = @categoryName,"
                                             + " description = @Description "
                                             + " where CategoryID = @categoryID";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());
            com.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            com.Parameters.AddWithValue("@categoryID", txtCategoryID.Text);
            com.ExecuteNonQuery();
            this.Close();

        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand com;

        private void frmInsertUpdateCategories_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            txtCategoryID.Text =categoryID.ToString();
            txtCategoryName.Text =categoryName;
            txtDescription.Text =description;
            this.Text += "(" + status + ")";
            txtCategoryName.Focus();

        }
    }
}