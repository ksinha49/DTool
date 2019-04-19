using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minor_Project_MAS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

      
        

        private void display_records_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchHome yp = new SearchHome();
            yp.Show();
        }

      

      

     

        private void complaints_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dbadd pc = new Dbadd();
            pc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentUP du = new DocumentUP();
            du.Show();

        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "Welcome" + " " + LoginInfo.UserID;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User_DashBoard ud = new User_DashBoard();
            ud.Show();
        }

        private void adddb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dbadd ud = new Dbadd();
            ud.Show();
        }

      

       

       
    }
}