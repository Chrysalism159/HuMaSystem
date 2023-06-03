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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=CHRYSALISM\SQLEXPRESS;Initial Catalog=HuMaDatabase;Integrated Security=True");
        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //add btn
            if (id.Text == "" || name.Text == "" || add.Text == "" || phone.Text =="")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    con.Open();
                    string querry = "insert into EmployeeTbl values ('"+id.Text+"', '"+name.Text+"', '" +add.Text +"', '" +gender.SelectedItem.ToString()+"', '" +EDU.SelectedItem.ToString() +"', '" +phone.Text +"', '" +position.SelectedItem.ToString() +"', '" +DoB.Value.ToShortDateString()+"')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data add successfuly!");
                    con.Close();
                    populate();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            con.Open();
            string querry = " select * from EmployeeTbl";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgridview.DataSource = dt;


            con.Close();
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Data_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(id.Text =="")
            {
                MessageBox.Show("Enter the employ id");

            }
            else
            {
                try
                {
                    con.Open();
                    string querry = "delete from EmployeeTbl where EmId = '"+id.Text+"';";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data delete successfully");
                    con.Close();
                    populate();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DataTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || add.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string querry = "update EmployeeTbl set EmID ='" + id.Text + "', EmName = '" + name.Text + "',EmAdd = '" + add.Text + "',EmGender= '" + gender.SelectedItem.ToString() + "',EmCollage = '" + EDU.SelectedItem.ToString() + "',  EmPhone='" + phone.Text + "',EmPosition = '" + position.SelectedItem.ToString() + "',EmDoB = '" + DoB.Value.ToShortDateString() + "' where EmID = '"+id.Text+"'";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee update success");
                    con.Close();
                    populate();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DoB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void DataTable_SelectionChanged(object sender, EventArgs e)
        {
            int choose = -1;
            choose = dtgridview.CurrentRow.Index;
            if(choose > 0)
            {
                id.Text = dtgridview.Rows[choose].Cells["EmID"].Value.ToString();
                name.Text = dtgridview.Rows[choose].Cells["EmName"].Value.ToString();
                add.Text = dtgridview.Rows[choose].Cells["EmAdd"].Value.ToString();
                gender.Text = dtgridview.Rows[choose].Cells["EmGender"].Value.ToString();
                EDU.Text = dtgridview.Rows[choose].Cells["EmCollage"].Value.ToString();
                phone.Text = dtgridview.Rows[choose].Cells["EmPhone"].Value.ToString();
                position.Text = dtgridview.Rows[choose].Cells["EmPos"].Value.ToString();
                DoB.Text = dtgridview.Rows[choose].Cells["EmDoB"].Value.ToString();
            }
        }

        private void dtgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgridview_SelectionChanged(object sender, EventArgs e)
        {
            int choose = -1;
            choose = dtgridview.CurrentRow.Index;
            if (choose >= 0)
            {
                id.Text = dtgridview.Rows[choose].Cells["EmID"].Value.ToString();
                name.Text = dtgridview.Rows[choose].Cells["EmName"].Value.ToString();
                add.Text = dtgridview.Rows[choose].Cells["EmAdd"].Value.ToString();
                gender.Text = dtgridview.Rows[choose].Cells["EmGender"].Value.ToString();
                EDU.Text = dtgridview.Rows[choose].Cells["EmCollage"].Value.ToString();
                phone.Text = dtgridview.Rows[choose].Cells["EmPhone"].Value.ToString();
                position.Text = dtgridview.Rows[choose].Cells["EmPosition"].Value.ToString();
                DoB.Text = dtgridview.Rows[choose].Cells["EmDoB"].Value.ToString();
            }
        }
    }
}
