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
    public partial class Views : Form
    {
        public Views()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=CHRYSALISM\SQLEXPRESS;Initial Catalog=HuMaDatabase;Integrated Security=True");
        private void FletchData()
        {
            con.Open();
            string querry = "select * from EmployeeTbl where EmID ='" + id.Text + "';";
            SqlCommand cmd = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach( DataRow dr in dt.Rows)
            {
                EmpID.Text = dr["EmID"].ToString();
                EmpName.Text = dr["EmName"].ToString();
                EmpAdd.Text = dr["EmAdd"].ToString();
                EmpGender.Text = dr["EmGender"].ToString();
                EmpEdu.Text = dr["EmCollage"].ToString();
                EmpPhone.Text = dr["EmPhone"].ToString();
                EmpPos.Text = dr["EmPosition"].ToString();
                EmpDob.Text = dr["EmDoB"].ToString();

                EmpID.Visible = true;
                EmpName.Visible = true;
                EmpAdd.Visible = true;
                EmpGender.Visible = true;
                EmpEdu.Visible = true;
                EmpPhone.Visible = true;
                EmpPos.Visible = true;
                EmpDob.Visible = true;
            }
            con.Close();
        }
        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FletchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=============EMPLOYEE DETAILS=============", new Font("Segoe UI", 20, FontStyle.Bold), Brushes.Black, new Point(30));
            e.Graphics.DrawString("Employee ID: " + EmpID.Text + "\n" + "Employee Name:    " + EmpName.Text + "\n"+ "Employee Gender: " + EmpGender.Text +  "\nEmployee Phone:   " + EmpPhone.Text  + "\n" + "Employee Add:   " + EmpAdd.Text + "\n" + "Employee Date of Birth:   " + EmpDob.Text + "\n"+ "Employee Education: " + EmpEdu.Text + "\n Employee Position: " + EmpPos.Text, new Font("Segoe UI", 20, FontStyle.Bold), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("==========================================", new Font("Segoe UI", 20, FontStyle.Bold), Brushes.Black, new Point(30,500));
        }
    }
}
