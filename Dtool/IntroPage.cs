using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Minor_Project_MAS
{
    public partial class IntroPage : Form
    {
        public IntroPage()
        {
            Thread t = new Thread(new ThreadStart(Citizen_Interaction));
            t.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            t.Abort();
            
            
        }
        public void Citizen_Interaction()
        {
            Application.Run(new splash());
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IntroPage_Load(object sender, EventArgs e)
        {

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
    }
}
