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
    public partial class FrmNewRepRotin : Form
    {
        public FrmNewRepRotin()
        {
            InitializeComponent();
        }

        private void FrmNewRepRotin_Load(object sender, EventArgs e)
        {
            comboBoxHoldBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPermitNumber.DropDownStyle= ComboBoxStyle.DropDownList;
            comboBoxUnit.DropDownStyle= ComboBoxStyle.DropDownList;
            comboBoxHoldBy.Enabled = false;
            TextBoxPermitNumber.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDone.Checked)
            {
                checkBoxHoldBy.Enabled = false;
                checkBoxShutDown.Enabled = false;
            }
            else
            {
                checkBoxHoldBy.Enabled = true;
                checkBoxShutDown.Enabled = true;
            }
        }

        private void checkBoxHoldBy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHoldBy.Checked)
            {
                checkBoxDone.Enabled = false;
                checkBoxShutDown.Enabled = false;
                comboBoxHoldBy.Enabled = true;
            }
            else
            {
                checkBoxDone.Enabled = true;
                checkBoxShutDown.Enabled = true;
                comboBoxHoldBy.Enabled = false;
            }
        }

        private void checkBoxShutDown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShutDown.Checked)
            {
                checkBoxHoldBy.Enabled = false;
                checkBoxDone.Enabled = false;
            }
            else
            {
                checkBoxHoldBy.Enabled = true;
                checkBoxDone.Enabled = true;
            }
        }

        private void comboBoxPermitNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPermitNumber.SelectedItem != null)
            {
                TextBoxPermitNumber.Enabled = true;
            }
            else
            {
                TextBoxPermitNumber.Enabled = false;
            }
        }

        private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
