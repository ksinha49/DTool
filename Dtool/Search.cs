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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
         public void GridData()
        {
             var sqlDataAdapter = new SqlCeDataAdapter("Select * from User_rec", @"Data Source=C:\Users\Koushik\Documents\Visual Studio 2010\Projects\Minor Project\Citizen_Interaction\Citizen_Interaction\cidb13.sdf");
                var sqlCommandBuilder = new SqlCeCommandBuilder(sqlDataAdapter);
                var dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                var bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;
         }
}
