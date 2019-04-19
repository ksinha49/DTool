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
    public partial class SearchPage : Form
    {
        public SearchPage()
        {
            InitializeComponent();
        }
         public string s1, s2 , s3,s4;
       
     //System.Data.SqlServerCe.SqlCeConnection con;
        
        public SearchPage(string ss2)
        {
            InitializeComponent();
            this.s1 = ss2;
        }
        public SearchPage(string ss3, string ss4, string ss5,string ss7)
        {
            InitializeComponent();
            this.s1 = ss3;
            this.s2 = ss4;
            this.s3 = ss5;
            this.s4 = ss7;
        }

        public void GridData()
        {
            if (String.IsNullOrEmpty(s3))
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                var sqlDataAdapter2 = new SqlCeDataAdapter("Select * from UploadHist where Filename='" + s1 + "'", @"Data Source=|DataDirectory|cidb13.sdf");
                var sqlCommandBuilder2 = new SqlCeCommandBuilder(sqlDataAdapter2);
                var dataTable2 = new DataTable();
                sqlDataAdapter2.Fill(dataTable2);
                var bindingSource2 = new BindingSource();
                bindingSource2.DataSource = dataTable2;
                dataGridView3.DataSource = bindingSource2;
            }



            else
            {
                if (s2.Equals("DocType"))
                {
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = false;
                    var sqlDataAdapter1 = new SqlCeDataAdapter("Select * from UploadHist where Filename='" + s1 + "' AND Doctype='" + s3 + "' ", @"Data Source=|DataDirectory|cidb13.sdf");
                    var sqlCommandBuilder1 = new SqlCeCommandBuilder(sqlDataAdapter1);
                    var dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);
                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = dataTable1;
                    dataGridView1.DataSource = bindingSource1;
                }
                else if (s2.Equals("Userid"))
                {
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = false;
                    var sqlDataAdapter1 = new SqlCeDataAdapter("Select * from UploadHist where Filename='" + s1 + "' and userid='" + s3 + "' ", @"Data Source=|DataDirectory|cidb13.sdf");
                    var sqlCommandBuilder1 = new SqlCeCommandBuilder(sqlDataAdapter1);
                    var dataTable = new DataTable();
                    sqlDataAdapter1.Fill(dataTable);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dataGridView1.DataSource = bindingSource;
                }
                else if (s2.Equals("Timestamp"))
                {
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = false;
                    var sqlDataAdapter1 = new SqlCeDataAdapter("Select * from User_rec where Filename='" + s1 + "' and Time_of_Entry='" + s3 + "' ", @"Data Source=|DataDirectory|cidb13.sdf");
                    var sqlCommandBuilder1 = new SqlCeCommandBuilder(sqlDataAdapter1);
                    var dataTable = new DataTable();
                    sqlDataAdapter1.Fill(dataTable);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dataGridView1.DataSource = bindingSource;
                }
               

            }
        }

            

       
        private void SearchPage_Load(object sender, EventArgs e)
        {
             dataGridView1.AutoGenerateColumns = false;
             dataGridView2.AutoGenerateColumns = false;
            //dataGridView3.AutoGenerateColumns = false;
             GridData();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchHome yp = new SearchHome();
              yp.Show();
              this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
