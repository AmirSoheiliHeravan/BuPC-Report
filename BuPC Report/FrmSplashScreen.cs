using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuPC_Report
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        Timer Timer1;
        private void FrmSplashScreen_Shown(object sender, EventArgs e)
        {
            Timer1 = new Timer();
            Timer1.Interval = 5000;
            Timer1.Start();
            Timer1.Tick += tmr_Tick;
        }


        void tmr_Tick(object sender, EventArgs e)
        {
            Timer1.Stop();
            frmlogin F1 = new frmlogin();
            F1.Show();
            this.Hide();
        }

        private void FrmSplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
