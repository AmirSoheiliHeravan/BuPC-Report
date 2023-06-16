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
    public partial class FrmNewRepPermit : Form
    {
        public FrmNewRepPermit()
        {
            InitializeComponent();
        }

        private void checkBoxHoldBy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHoldBy.Checked)
            {
                checkBoxDone.Enabled = false;
                checkBoxFollo.Enabled = false;
                ComboBoxHoldBy.Enabled = true;
            }
            else
            {
                checkBoxDone.Enabled = true;
                checkBoxFollo.Enabled = true;
                ComboBoxHoldBy.Enabled = false;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBoxDone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDone.Checked)
            {
                checkBoxHoldBy.Enabled = false;
                checkBoxFollo.Enabled = false;
            }
            else
            {
                checkBoxHoldBy.Enabled = true;
                checkBoxFollo.Enabled = true;
            }
        }

        private void checkBoxFollo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFollo.Checked)
            {
                checkBoxDone.Enabled = false;
                checkBoxHoldBy.Enabled = false;
                TextBoxPercentFollo.Enabled = true;
            }
            else
            {
                checkBoxDone.Enabled = true;
                checkBoxHoldBy.Enabled = true;
                TextBoxPercentFollo.Enabled = false;
            }
        }

        private void ComboBoxPermitNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPermitNumber.SelectedItem != null)
            {
                TextBoxPermitNumber.Enabled = true;
            }
            else
            {
                TextBoxPermitNumber.Enabled = false;
            }
        }

        private void FrmNewRepPermit_Load(object sender, EventArgs e)
        {
            ComboBoxHoldBy.Enabled = false;
            TextBoxPercentFollo.Enabled = false;
            TextBoxPermitNumber.Enabled=false;
        }
    }
}
