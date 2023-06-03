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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=CHRYSALISM\SQLEXPRESS;Initial Catalog=HuMaDatabase;Integrated Security=True");
        private void FletchData()
        {

            if(id.Text == "")
            {
                MessageBox.Show("Enter ID data");
            }
            else
            {
                con.Open();
                string querry = "select * from EmployeeTbl where EmID ='" + id.Text + "';";
                SqlCommand cmd = new SqlCommand(querry, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    name.Text = dr["EmName"].ToString();
                    Pos.Text = dr["EmPosition"].ToString();
                    name.Visible = true;
                    Pos.Visible = true;


                }
                con.Close();
            }
            
        }
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            FletchData();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Dailybase,total;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=============EMPLOYEE SALARIES=============", new Font("Segoe UI", 20, FontStyle.Bold), Brushes.Black, new Point(30));
            e.Graphics.DrawString("ID:   " + id.Text + "\n" + "Name:    " + name.Text + "\n" + "Position: " + Pos.Text + "\n" + "Worked Days:   " + Days.Text + "\n" + "Total Salaries:   " + total.ToString(), new Font("Segoe UI", 20, FontStyle.Bold), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("==========================================", new Font("Segoe UI", 20, FontStyle.Bold), Brushes.Black, new Point(30, 500));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Pos.Text=="")
            {
                MessageBox.Show("Select an Employee");
            }
            else if(Days.Text =="" || Convert.ToInt32(Days.Text) > 30)
            {
                MessageBox.Show("Enter an valid number of day");
            }
            else
            {
                if (Pos.Text == "Manager")
                {
                    Dailybase = 250;
                }
                else if (Pos.Text == "Fresher Developer")
                {
                    Dailybase = 200;
                }
                else if (Pos.Text == "Senior Developer")
                {
                    Dailybase = 150;
                }
                else
                    Dailybase = 100;
                total = Dailybase * Convert.ToInt32(Days.Text);
                SalarySlip.Text ="ID:   "+ id.Text + "\n"+"Name:    " + name.Text + "\n"+"Position: " + Pos.Text + "\n"+"Worked Days:   " + Days.Text + "\n"+"Total Salaries:   " + total.ToString();

            }
        }
    }
}


