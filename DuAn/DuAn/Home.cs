using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Data dt = new Data();
            dt.Show();
            this.Hide();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            Data dt = new Data();
            dt.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login log = new Login(); 
            log.Show();
            this.Hide();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Views vs = new Views();
            vs.Show();
            this.Hide();
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            Views vs = new Views();
            vs.Show();
            this.Hide();
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.Show();
            this.Hide();
        }
    }
    
}
