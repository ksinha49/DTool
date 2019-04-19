using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Minor_Project_MAS
{
    public partial class DBIE : Form
    {
        public SqlCeConnection cn1 = new SqlCeConnection(@"DataSource=|DataDirectory|cidb13.sdf");
        public DBIE()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_DashBoard er = new User_DashBoard();
            er.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn1 = new System.Data.SqlServerCe.SqlCeConnection();
            cn1.ConnectionString = "DataSource=|DataDirectory|cidb13.sdf";
            SqlCeCommand cmd2 = cn1.CreateCommand();
            cmd2.CommandText = "SELECT * From DataBaseid ";
            cn1.Open();
            cmd2.ExecuteNonQuery();
            SqlCeDataReader readData = cmd2.ExecuteReader();
            if (readData != null)
            {
                while (readData.Read())
                {

                    if (readData.GetString(0) == comboBox1.Text)
                    {

                        string dbname = readData.GetString(0);
                        string user   = readData.GetString(1);
                        string pass   = readData.GetString(2);
                        string schema = readData.GetString(3);


                    }
                }
            }


            cn1.Close();
            Import_Exportjob();

        }
        public void Import_Exportjob()
        {  
            Process objProcess = new Process();
            objProcess.StartInfo.UseShellExecute = false;
            objProcess.StartInfo.RedirectStandardOutput = true;
            objProcess.StartInfo.CreateNoWindow = true;
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;   
           //file location
            
            if (activity1.Text == "import")
                objProcess.StartInfo.FileName = string.Format(@"D:\programs\Batch\import.bat");
            else
                if (activity1.Text == "export")
                    objProcess.StartInfo.FileName = string.Format(@"D:\programs\Batch\import.bat");
                else
                    if (String.IsNullOrEmpty(this.activity1.Text))
                    {
                        MessageBox.Show("Chooose action Import/Export");
                        
                    }
          
          //any argument  
            if (!String.IsNullOrEmpty(this.activity1.Text))
            {
                objProcess.StartInfo.Arguments = string.Format("");
                try
                {
                    objProcess.Start();
                }
                catch
                {
                    throw new Exception("Error");
                }
                StreamReader strmReader = objProcess.StandardOutput;
                string strTempRow = string.Empty;
                while ((strTempRow = strmReader.ReadLine()) != null)
                {
                    Console.WriteLine(strTempRow);
                }
                if (!objProcess.HasExited)
                {
                    objProcess.Kill();
                }

            }
        }
        
        private void DBIE_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'cidb13DataSet.Databaseid' table. You can move, or remove it, as needed.
            this.databaseidTableAdapter.Fill(this.cidb13DataSet.Databaseid);
            try
            {
                cn1.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Successful");
                Application.ExitThread();
            }
            cn1 = new System.Data.SqlServerCe.SqlCeConnection();
            cn1.ConnectionString = "DataSource=|DataDirectory|cidb13.sdf";
            SqlCeCommand cmd3 = cn1.CreateCommand();
            cmd3.CommandText = "SELECT DBName From DataBaseid ";
            cn1.Open();
            cmd3.ExecuteNonQuery();
            SqlCeDataReader drd = cmd3.ExecuteReader();
            while (drd.Read())
            {
                comboBox1.Items.Add(new{DBName=(drd["DBName"].ToString())});
            }
            comboBox1.ValueMember = "DBName";
            comboBox1.DisplayMember = "DBName";
            cn1.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            activity1.Text = "import";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            activity1.Text = "export";
        }
    }
}
