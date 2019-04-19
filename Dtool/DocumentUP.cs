using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Minor_Project_MAS
{
    public partial class DocumentUP : Form
    {
        public SqlCeConnection cn3 = new SqlCeConnection(@"DataSource=|DataDirectory|cidb13.sdf");

        public DocumentUP()
        {
            InitializeComponent();
        }
        //panel1=main,panel2=upload//panle3=view//panle4=gridview//panel5=webbrowser
        private void DocumentUP_Load(object sender, EventArgs e)
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
            count();
        }
        public void count()
        {
            SqlCeCommand cm2 = new SqlCeCommand("SELECT COUNT(*) FROM UploadHist", cn3);
            Int32 count = (Int32)cm2.ExecuteScalar();
            count++;
            string s = "UP00" + count.ToString();
            label8.Text = s.ToUpper();
        }



        //upload button click
        public string Destination, j;
        private void button1_Click(object sender, EventArgs e)
        {
                OpenFileDialog filedailog = new OpenFileDialog();
                filedailog.CheckFileExists = true;
                filedailog.AddExtension = true;
                filedailog.Title = "Upload File";
                filedailog.Filter = "CSV files (*.csv)|*.csv";
                string s;
                filedailog.ShowDialog();
                s = filedailog.FileName;
                if (comboBox1.SelectedItem.ToString().Equals("Agent"))
                {
                    Destination = "C:\\Users\\Koushik\\Documents\\upload\\Agent\\";
                    j = Destination;

                }
                else if (comboBox1.SelectedItem.ToString().Equals("Rates"))
                {
                    Destination = "C:\\Users\\Koushik\\Documents\\upload\\Rates\\";
                    j = Destination;
                }
                else if (comboBox1.SelectedItem.ToString().Equals("Policy"))
                {
                    Destination = "C:\\Users\\Koushik\\Documents\\upload\\Policy\\";
                    j = Destination;
                }
                else if (String.IsNullOrEmpty(this.comboBox1.SelectedText))
                {
                    MessageBox.Show("Complete all input feilds");

                }
                
                var kl = s.Split('\\');
                string fname = kl[kl.Length - 1];
                // label17.Text = j+fname;
                SqlCeCommand cm2 = new SqlCeCommand("INSERT INTO UploadHIst (FileID,FileName,DocType,Time_of_Entry,userid)" + "VALUES (@upid,@name,@type,@cn,@des)", cn3);
                cm2.Parameters.AddWithValue("@name", label8.Text);
                cm2.Parameters.AddWithValue("@cn", textBox3.Text);
                cm2.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());
                cm2.Parameters.AddWithValue("@upid", "2016-01-01");
                cm2.Parameters.AddWithValue("@des", j + fname);
                try
                {
                    int afRow1 = cm2.ExecuteNonQuery();
                    if (afRow1 > 0)
                    {
                        System.IO.File.Copy(s, Destination + fname, true);
                        MessageBox.Show("File Uploaded");
                        textBox3.Clear();
                        comboBox1.ResetText();
                        count();

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

       


        //backto dashboard
        
        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User_DashBoard ud = new User_DashBoard();
            ud.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
       
       

    }
}