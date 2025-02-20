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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinForms.Minimart
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public bool Discontinued { get; set; }
        public string status { get; set; }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        private void showdata()
        {
            // คำสั่ง SQL สำหรับดึงข้อมูลจาก Products
            string sql = "Select * from Products";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dgvProducts.DataSource = dataSet.Tables[0];  // แสดงข้อมูลใน DataGridView
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            ConfigureNumericControls();
            LoadCategories();
            showdata();
        }
        private void ConfigureNumericControls()
        {
            numUD_UnitPrice.Minimum = 0;
            numUD_UnitPrice.Maximum = 1000000;
            numUD_UnitsInStock.Minimum = 0;
            numUD_UnitsInStock.Maximum = 10000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการลบ");
                return;
            }

            if (MessageBox.Show("ต้องการลบสินค้านี้หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string productID = dgvProducts.SelectedRows[0].Cells["ProductID"].Value.ToString();
            string sql = "DELETE FROM Products WHERE ProductID = @ProductID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ProductID", productID);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    showdata();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ไม่สามารถลบข้อมูลได้");
            }

        }
        private void LoadCategories()
        {
            // ดึงข้อมูลจากตาราง Categories
            string sql = "SELECT CategoryID, CategoryName FROM Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ตั้งค่า DataSource ให้กับ ComboBox
            cmbCategoryID.DataSource = dt;
            cmbCategoryID.DisplayMember = "CategoryName";  // แสดงชื่อหมวดหมู่ใน ComboBox
            cmbCategoryID.ValueMember = "CategoryID";  // เก็บค่า CategoryID ที่เลือกไว้
            cmbCategoryID.SelectedIndex = -1;  // ตั้งค่าเริ่มต้นให้ ComboBox ไม่มีการเลือกใดๆ
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการแก้ไข");
                return;
            }

            string sql = "UPDATE Products SET ProductName = @ProductName, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, CategoryID = @CategoryID, Discontinued = @Discontinued WHERE ProductID = @ProductID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
            cmd.Parameters.AddWithValue("@UnitPrice", numUD_UnitPrice.Value);
            cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
            cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);
            cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);

            if (cmd.ExecuteNonQuery() > 0)
            {
                showdata();
                ClearForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("ชื่อสินค้าต้องไม่ว่าง");
                return;
            }

            int newProductID = GetNextProductID();  // ดึงค่า ProductID ถัดไป

            string sql = "INSERT INTO Products (ProductID, ProductName, UnitPrice, UnitsInStock, CategoryID, Discontinued) " +
                         "VALUES (@ProductID, @ProductName, @UnitPrice, @UnitsInStock, @CategoryID, @Discontinued)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ProductID", newProductID);  // กำหนดค่า ProductID อัตโนมัติ
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
            cmd.Parameters.AddWithValue("@UnitPrice", numUD_UnitPrice.Value);
            cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
            cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);
            cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);

            if (cmd.ExecuteNonQuery() > 0)  // เช็คว่าเพิ่มข้อมูลสำเร็จหรือไม่
            {
                showdata();
                ClearForm();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        void ClearForm()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            numUD_UnitPrice.Value = 0;
            numUD_UnitsInStock.Value = 0;
            cmbCategoryID.SelectedIndex = -1;
            cmbDiscontinued.SelectedIndex = 0;
            txtProductID.Enabled = false;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex == dgvProducts.Rows.Count - 1) // ถ้าคลิกที่แถวสุดท้าย
                {
                    txtProductID.Text = GetNextProductID().ToString();  // กำหนดค่า ProductID อัตโนมัติ
                    txtProductName.Clear();
                    numUD_UnitPrice.Value = 0;
                    numUD_UnitsInStock.Value = 0;
                    cmbCategoryID.SelectedIndex = -1;
                    cmbDiscontinued.SelectedIndex = 0;
                    txtProductID.Enabled = false;
                }
                else
                {
                    DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                    txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                    txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                    numUD_UnitPrice.Value = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    numUD_UnitsInStock.Value = Convert.ToInt32(row.Cells["UnitsInStock"].Value);
                    cmbCategoryID.SelectedValue = row.Cells["CategoryID"].Value;
                    cmbDiscontinued.SelectedIndex = Convert.ToBoolean(row.Cells["Discontinued"].Value) ? 1 : 0;
                }
            }
        }

        private void cmbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ดึงข้อมูลจากตาราง Categories
            string sql = "SELECT CategoryID, CategoryName FROM Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ตั้งค่า DataSource ให้กับ ComboBox
            cmbCategoryID.DataSource = dt;
            cmbCategoryID.DisplayMember = "CategoryName";  // แสดงชื่อหมวดหมู่ใน ComboBox
            cmbCategoryID.ValueMember = "CategoryID";  // เก็บค่า CategoryID ที่เลือกไว้

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProducts f = new frmProducts();
            f.status = "update";
            var dgv = dgvProducts.CurrentRow.Cells;
            f.ProductID = dgv["ProductID"].Value.ToString();  // ใช้ ProductID เป็น string
            f.ProductName = dgv["ProductName"].Value.ToString();
            f.UnitPrice = Convert.ToDecimal(dgv["UnitPrice"].Value);
            f.UnitsInStock = Convert.ToInt32(dgv["UnitsInStock"].Value);
            f.CategoryID = Convert.ToInt32(dgv["CategoryID"].Value);
            f.Discontinued = Convert.ToBoolean(dgv["Discontinued"].Value);
            f.ShowDialog();
            showdata();  // รีเฟรชข้อมูล
        }
        private int GetNextProductID()
        {
            string sql = "SELECT ISNULL(MAX(ProductID), 0) + 1 FROM Products";
            SqlCommand cmd = new SqlCommand(sql, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());  // คืนค่า ProductID ถัดไป
        }

    }

}
