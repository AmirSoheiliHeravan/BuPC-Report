using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BuPC_Report
{
    public partial class FrmNewRepWorkOrder : Form
    {
        public FrmNewRepWorkOrder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmNewRepWorkOrder_Load(object sender, EventArgs e)
        {
            ComboBoxPermitNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            TextBoxPercentFollow.Enabled = false;
            TextBoxPermitNumber.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDone.Checked)
            {
                checkBoxFollow.Enabled = false;
            }
            else
            {
                checkBoxFollow.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFollow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFollow.Checked)
            {
                checkBoxDone.Enabled = false;
                TextBoxPercentFollow.Enabled = true;
            }
            else
            {
                checkBoxDone.Enabled = true;
                TextBoxPercentFollow.Enabled = false;
            }
        }

        private void TextBoxPermitNumber_TextChanged(object sender, EventArgs e)
        {

        }

        //private void ComboBoxPermitNumber_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ComboBoxPermitNumber.SelectedItem != null)
        //    {
        //        TextBoxPermitNumber.Enabled = true;
        //    }
        //    else
        //    {
        //        TextBoxPermitNumber.Enabled = false;
        //    }
        //}

        private void ComboBoxPermitNumber_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
