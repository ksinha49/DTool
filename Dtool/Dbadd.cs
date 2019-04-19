using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.IO;
namespace Minor_Project_MAS
{
    public partial class Dbadd : Form
    {
        public Dbadd()
        {
            InitializeComponent();
        }
        public SqlCeConnection cn3 = new SqlCeConnection(@"DataSource=|DataDirectory|cidb13.sdf");
             

       

        private void Dbadd_Load(object sender, EventArgs e)
        {
            try
            {
                cn3.Open();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Connection failed");
                Application.ExitThread();
                
            }
           
        }
        
//back to dashboard label
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            cn3.Close();
            User_DashBoard ud = new User_DashBoard();
            ud.Show();
        }

      

       
        private void button3_Click(object sender, EventArgs e)
        {
             string s;
             DateTime dateTime = DateTime.UtcNow.Date;
             s = dateTime.ToString("dd MMMM, yyyy");
             SqlCeCommand cm2 = new SqlCeCommand("INSERT INTO databaseid(DBName,Username,Password,Schema)" + "VALUES (@dbid,@unam,@pass,@sch)", cn3);
             cm2.Parameters.AddWithValue("@dbid", dbn.Text);
             cm2.Parameters.AddWithValue("@unam", name.Text); 
             cm2.Parameters.AddWithValue("@pass", pass.Text);
             cm2.Parameters.AddWithValue("@sch", schma.Text);
          
             try
            {
                int afRow1 = cm2.ExecuteNonQuery();
                if (afRow1 > 0)
                {
                    MessageBox.Show("Database added");

                    dbn.Clear();
                    name.Clear();
                    pass.Clear();
                    schma.ResetText();

                }
                else
                {
                    MessageBox.Show("Please Fill all the details Properly");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        

        
        
        
    }
}
