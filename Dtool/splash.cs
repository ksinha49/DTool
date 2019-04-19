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
    public partial class splash : Form
    {
      
        public splash()
        {
           this.TransparencyKey = Color.Turquoise;
           this.BackColor = Color.Turquoise; 
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar2.Value == 100) 
                timer1.Stop();
            
        }


        private void splash_Load(object sender, EventArgs e)
        {

        }

       
       

        
    }
}
