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
    public partial class SearchHome : Form
    {
        public SearchHome()
        {
            InitializeComponent();
        }



        private void mainbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.Show();

        }

        private void refbutton_Click(object sender, EventArgs e)
        {
            refpanel.Visible = true;
            closelb.Visible = true;
        }


//refine search first panel
        private void doclb_Click_1(object sender, EventArgs e)
        {
            ppanel.Visible = true;
            placep.Visible = false;
        }

        private void userlb_Click_1(object sender, EventArgs e)
        {
            ppanel.Visible = false;
            placep.Visible = true;
        }

        private void timelb_Click_1(object sender, EventArgs e)
        {

        }//end of main refine search first panel


        //people label on click
        private void mblb_Click(object sender, EventArgs e)
        {
            phpanel.Visible = true;
            addpanel.Visible = false;
            gpanel.Visible =false;
            dobpanel.Visible =false;
            idpanel.Visible = false;
            eidpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = false;
        }

        private void addlb_Click(object sender, EventArgs e)
        {
            addpanel.Visible = true;
            phpanel.Visible = false;            
            gpanel.Visible = false;
            dobpanel.Visible = false;
            idpanel.Visible = false;
            eidpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = false;
        }

        private void glb_Click(object sender, EventArgs e)
        {
            gpanel.Visible = true;
            phpanel.Visible = false;
            addpanel.Visible = false;
            dobpanel.Visible = false;
            idpanel.Visible = false;
            eidpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = false;
        }

        private void doblb_Click(object sender, EventArgs e)
        {
            dobpanel.Visible = true;
            gpanel.Visible = false;
            phpanel.Visible = false;
            addpanel.Visible = false;
            idpanel.Visible = false;
            eidpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = false;
            
        }

        private void idlb_Click(object sender, EventArgs e)
        {
            idpanel.Visible = true;
            gpanel.Visible = false;
            phpanel.Visible = false;
            addpanel.Visible = false;
            dobpanel.Visible = false;
            eidpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = false;
        }

        private void eidlb_Click(object sender, EventArgs e)
        {
            eidpanel.Visible = true;
            gpanel.Visible = false;
            phpanel.Visible = false;
            addpanel.Visible = false;
            dobpanel.Visible = false;
            idpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = false;
           
        }
        //end of people refine tab panel


// buttons for different panels in people tab

        private void gendbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "gender";
            sr.s3 = gtextBox.Text;
            sr.s4 = "people";
            sr.Show();
        }

        private void addbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "address";
            sr.s3 = addtextBox.Text;
            sr.s4 = "people";
            sr.Show();
        }

        private void phbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "phone";
            sr.s3 = phtextBox.Text;
            sr.s4 = "people";
            sr.Show();
        }
        private void dobbt_Click(object sender, EventArgs e)
        {

            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "dob";
            sr.s3 = dobtextBox.Text;
            sr.s4 = "people";
            sr.Show();
        }

        private void emailbt_Click(object sender, EventArgs e)
        {

            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "email";
            sr.s3 = eidtextBox.Text;
            sr.s4 = "people";
            sr.Show();
        }

        private void idbt_Click(object sender, EventArgs e)
        {

            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "id";
            sr.s3 = idtextBox.Text;
            sr.s4 = "people";
            sr.Show();

        }//end of people tab proceed to search

        private void closelb_Click_1(object sender, EventArgs e)
        {
            eidpanel.Visible = false;
            gpanel.Visible = false;
            phpanel.Visible = false;
            addpanel.Visible = false;
            dobpanel.Visible = false;
            idpanel.Visible = false;
            refpanel.Visible = false;
            ppanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = false;
            closelb.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            eidpanel.Visible = false;
            gpanel.Visible = false;
            phpanel.Visible = false;
            addpanel.Visible = false;
            dobpanel.Visible = false;
            idpanel.Visible = false;
            paddpanel.Visible = true;
            cnpanel.Visible = false;
            typepanel.Visible = false;
        }

        private void typelabel_Click(object sender, EventArgs e)
        {
            eidpanel.Visible = false;
            gpanel.Visible = false;
            phpanel.Visible = false;
            addpanel.Visible = false;
            dobpanel.Visible = false;
            idpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = false;
            typepanel.Visible = true;
        }

        private void cnlabel_Click(object sender, EventArgs e)
        {
            eidpanel.Visible = false;
            gpanel.Visible = false;
            phpanel.Visible = false;
            addpanel.Visible = false;
            dobpanel.Visible = false;
            idpanel.Visible = false;
            paddpanel.Visible = false;
            cnpanel.Visible = true;
            typepanel.Visible = false;
        }

        private void paddbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "padd";
            sr.s3 = paddtxt.Text;
            sr.s4 = "place";
            sr.Show();
        }

        private void cnbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "cn";
            sr.s3 = cntxt.Text;
            sr.s4 = "place";
            sr.Show();
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void typebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage sr = new SearchPage();
            sr.s1 = maintextBox.Text;
            sr.s2 = "type";
            sr.s3 = typeBox.SelectedItem.ToString();
            sr.s4 = "place";
            sr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_DashBoard ud = new User_DashBoard();
            ud.Show();
        }

       
        
        

      
    }
}
