using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Minimart
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
  

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        private void showdata()
        {
            string sql = "Select * from Employees";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dgvEmployees.DataSource = dataSet.Tables[0];

            // ปรับขนาดคอลัมน์ให้ขยายเต็ม DataGridView
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("ชื่อประเภทสินค้าต้องว่าง");
                return;
            }

            string sql = "Insert into Employees values (@Title,@FirstName,@LastName,@Position,@UserName,@Password)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", cmbTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@Position", cmbPosition.Text.Trim());
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

            if (cmd.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าเลือกแถวใน DataGridView หรือยัง
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลพนักงานที่ต้องการลบ");
                return;
            }

            // แสดงข้อความยืนยันก่อนลบ
            if (MessageBox.Show("ต้องการลบข้อมูลพนักงานนี้หรือไม่?", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

       
            string employeeID = dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

            // สร้างคำสั่ง SQL สำหรับการลบข้อมูล
            string sql = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("เลือกพนักงานที่ต้องการแก้ไขก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("ชื่อพนักงานต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return;
            }

            string sql = "Update Employees set Title = @Title, FirstName = @FirstName, LastName = @LastName, Position = @Position, UserName = @UserName, Password = @Password where EmployeeID = @EmployeeID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
            cmd.Parameters.AddWithValue("@Title", cmbTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@Position", cmbPosition.Text.Trim());
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
            if (cmd.ExecuteNonQuery() > 0)
            {
                showdata();//display

            }
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            cmbTitle.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cmbPosition.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Focus();
            txtEmployeeID.Enabled = false;
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showdata();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dgvEmployees.CurrentRow.Cells["EmployeeID"].Value.ToString();
            cmbTitle.Text = dgvEmployees.CurrentRow.Cells["Title"].Value.ToString();
            txtFirstName.Text = dgvEmployees.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastName.Text = dgvEmployees.CurrentRow.Cells["LastName"].Value.ToString();
            cmbPosition.Text = dgvEmployees.CurrentRow.Cells["Position"].Value.ToString();
            txtUserName.Text = dgvEmployees.CurrentRow.Cells["UserName"].Value.ToString();
            txtPassword.Text = dgvEmployees.CurrentRow.Cells["Password"].Value.ToString();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ตรวจสอบว่าผู้ใช้คลิกที่แถวที่ถูกต้อง (ไม่ใช่ header)
            if (e.RowIndex >= 0)
            {
                // เลือกแถวที่คลิก
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                // นำค่าจากแต่ละ Cell ไปใส่ใน TextBox และ ComboBox
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                cmbTitle.Text = row.Cells["Title"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                cmbPosition.Text = row.Cells["Position"].Value.ToString();
                txtUserName.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString(); // ถ้าต้องการแสดง
            }
        }
    }
}
