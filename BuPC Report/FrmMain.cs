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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void گزارشروتینToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FrmNewRepRotin().ShowDialog();
        }

        private void گزارشPermitباWorkOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FrmNewRepWorkOrder().ShowDialog();
        }

        private void گزارشToDoListروزبعدToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FrmNewTomorrowToDoList().ShowDialog();
        }

        private void گزارشToDoListشبToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FrmNewNightToDoList().ShowDialog();
        }

        private void خروجازبرنامهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void گزارشPermitانجامشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewRepPermit().ShowDialog();
        }
    }
}
