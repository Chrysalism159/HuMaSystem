using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuAn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CHRYSALISM\SQLEXPRESS;Initial Catalog=HuMaDatabase;Integrated Security=True");
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CheckLogin";
            cmd.Parameters.AddWithValue("@UserName", user.Text);
            cmd.Parameters.AddWithValue("@Password", password.Text);
            cmd.Connection = conn;
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            if (code == 1)
            {
                MessageBox.Show("Đăng nhập thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Home f = new Home();
                f.Show();
            }
            
            else if (code == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Text = "";
                password.Text = "";
                user.Focus();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Text = "";
                password.Text = "";
                user.Focus();
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
           if(btnClr.Text == "HIDE")
            {
                password.PasswordChar = '*';
                btnClr.Text = "SHOW";
                
            }
            else if (btnClr.Text == "SHOW")
            {
                btnClr.Text = "HIDE";
                password.PasswordChar = (char)0;
            }
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
