using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace Minor_Project_MAS
{
    
    public partial class Login : Form
    {
        
        //public SqlCeConnection cn = new SqlCeConnection(@"DataSource=|DataDirectory|cidb13.sdf");
        public Login()
        {
            InitializeComponent();
        }
        
        System.Data.SqlServerCe.SqlCeConnection con;
       
        
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "My Application",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            int WM_NCHITTEST = 0x84;
            if (m.Msg == WM_NCHITTEST)
            {
                int HTCLIENT = 1;
                int HTCAPTION = 2;
                if (m.Result.ToInt32() == HTCLIENT)
                    m.Result = (IntPtr)HTCAPTION;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new System.Data.SqlServerCe.SqlCeConnection();
            con.ConnectionString = "DataSource=|DataDirectory|cidb13.sdf";
            SqlCeCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "SELECT * From Employee_reg ";
            int flag=0,f1=0;
            con.Open();
            cmd2.ExecuteNonQuery();
            SqlCeDataReader readData = cmd2.ExecuteReader();
            if (readData != null)
            {
                while (readData.Read())
                {
                    if(readData.GetString(8)=="Reviewed")
                  {
                    if (readData.GetString(2)== textBox2.Text && (readData.GetString(1)== textBox1.Text ))
                    {
                       /* if (textBox1.Text == "Admin") 
                        {
                            string u1 = readData.GetString(0);
                            this.Hide();
                            adminPanel ad = new adminPanel();
                            LoginInfo.UserID = u1;
                            ad.Show();
                            flag=1;

                        }
                        else*/
                       
                            string u = readData.GetString(0);
                            this.Hide();
                            User_DashBoard er = new User_DashBoard();
                            LoginInfo.UserID = u;
                            er.Show();
                            flag=1;
                        
                    }
                  }
                    else if(readData.GetString(8).Equals("Not Reviewed"))
                    {
                        if (readData.GetString(2) == textBox2.Text && (readData.GetString(1) == textBox1.Text))
                        {
                            f1 = 1;
                            flag = 1;

                        }
                        
                    }
                }
            }

            if(flag==0)
            {
                 MessageBox.Show("Wrong password or username.Try again ");
            }
            
            else if (f1 == 1)
            {
                MessageBox.Show("Login Verfication in process.\nCan't access.\nContact Admin for Login Details");
            }
            //ds1 = new DataSet();
            //string sql = "SELECT * From Employee_reg where UserName='" + textBox1 + "'";
            //da = new System.Data.SqlServerCe.SqlCeDataAdapter(sql, con);
            //da.Fill(ds1, "Employee_reg");
            //DataRow drow = ds1.Tables["Employee_reg"].Rows[0];
            /*foreach (DataRow drow in ds1.Employee_reg)
            {
                if (drow.ItemArray[0].Equals(textBox1.Text) && drow.ItemArray[1].Equals(textBox2.Text))
                {
                    this.Hide();
                    User_DashBoard er = new User_DashBoard();
                    er.str1 = drow.ItemArray.GetValue(1).ToString();
                    er.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password or username.Try again ");
                }
            }*/

            con.Close();
        }
       
    }
}
