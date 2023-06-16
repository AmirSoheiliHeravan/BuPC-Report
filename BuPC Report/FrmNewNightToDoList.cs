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
    public partial class FrmNewNightToDoList : Form
    {
        public FrmNewNightToDoList()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmNewNightToDoList_Load(object sender, EventArgs e)
        {
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
