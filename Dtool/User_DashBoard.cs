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
    public partial class User_DashBoard : Form
    {
       
        
        public User_DashBoard()
        {
            InitializeComponent();

        }

       
           
       

        private void User_DashBoard_Load(object sender, EventArgs e)
        {
            
            label3.Visible = true;
            label3.Text = "Welcome" + " " + LoginInfo.UserID;
        }

        private void display_records_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchHome yp = new SearchHome();
            yp.Show();
        }

        
        

        private void set_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings gs = new Settings();
            gs.Show();
        }

        private void complaints_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dbadd pc = new Dbadd();
            pc.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

       
        private void dbie_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DBIE ur = new DBIE();
            ur.Show();
        }

        private void tt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentUP du = new DocumentUP();
            du.Show();
        }

       
    }
}
