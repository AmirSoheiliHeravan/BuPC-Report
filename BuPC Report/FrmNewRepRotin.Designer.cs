namespace BuPC_Report
{
    partial class FrmNewRepRotin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewRepRotin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxHoldBy = new System.Windows.Forms.CheckBox();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxPermitNumber = new System.Windows.Forms.ComboBox();
            this.TextBoxPeopleDone = new System.Windows.Forms.TextBox();
            this.TextBoxRotinDiscription = new System.Windows.Forms.TextBox();
            this.TextBoxTagNumber = new System.Windows.Forms.TextBox();
            this.TextBoxWorkOrderNumber = new System.Windows.Forms.TextBox();
            this.TextBoxPermitNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxShutDown = new System.Windows.Forms.CheckBox();
            this.comboBoxHoldBy = new System.Windows.Forms.ComboBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "تاریخ و ساعت جاری سیستم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "کاربر و شیفت جاری سیستم";
            // 
            // checkBoxHoldBy
            // 
            this.checkBoxHoldBy.AutoSize = true;
            this.checkBoxHoldBy.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHoldBy.ForeColor = System.Drawing.Color.White;
            this.checkBoxHoldBy.Location = new System.Drawing.Point(174, 74);
            this.checkBoxHoldBy.Name = "checkBoxHoldBy";
            this.checkBoxHoldBy.Size = new System.Drawing.Size(116, 17);
            this.checkBoxHoldBy.TabIndex = 49;
            this.checkBoxHoldBy.Text = "Hold گردید توسط";
            this.checkBoxHoldBy.UseVisualStyleBackColor = false;
            this.checkBoxHoldBy.CheckedChanged += new System.EventHandler(this.checkBoxHoldBy_CheckedChanged);
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDone.ForeColor = System.Drawing.Color.White;
            this.checkBoxDone.Location = new System.Drawing.Point(216, 53);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDone.TabIndex = 48;
            this.checkBoxDone.Text = "انجام شد";
            this.checkBoxDone.UseVisualStyleBackColor = false;
            this.checkBoxDone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "اتان",
            "کولینگ آف ساید",
            "متانول",
            "ASU",
            "آتشنشانی",
            "حراست",
            "RO",
            "GSP",
            "Utility"});
            this.comboBoxUnit.Location = new System.Drawing.Point(650, 91);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(132, 21);
            this.comboBoxUnit.TabIndex = 47;
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // comboBoxPermitNumber
            // 
            this.comboBoxPermitNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxPermitNumber.FormattingEnabled = true;
            this.comboBoxPermitNumber.Items.AddRange(new object[] {
            "C",
            "H"});
            this.comboBoxPermitNumber.Location = new System.Drawing.Point(650, 50);
            this.comboBoxPermitNumber.Name = "comboBoxPermitNumber";
            this.comboBoxPermitNumber.Size = new System.Drawing.Size(36, 21);
            this.comboBoxPermitNumber.TabIndex = 46;
            this.comboBoxPermitNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxPermitNumber_SelectedIndexChanged);
            // 
            // TextBoxPeopleDone
            // 
            this.TextBoxPeopleDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPeopleDone.Location = new System.Drawing.Point(60, 321);
            this.TextBoxPeopleDone.Multiline = true;
            this.TextBoxPeopleDone.Name = "TextBoxPeopleDone";
            this.TextBoxPeopleDone.Size = new System.Drawing.Size(723, 48);
            this.TextBoxPeopleDone.TabIndex = 44;
            // 
            // TextBoxRotinDiscription
            // 
            this.TextBoxRotinDiscription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxRotinDiscription.Location = new System.Drawing.Point(60, 135);
            this.TextBoxRotinDiscription.Multiline = true;
            this.TextBoxRotinDiscription.Name = "TextBoxRotinDiscription";
            this.TextBoxRotinDiscription.Size = new System.Drawing.Size(722, 155);
            this.TextBoxRotinDiscription.TabIndex = 43;
            // 
            // TextBoxTagNumber
            // 
            this.TextBoxTagNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxTagNumber.Location = new System.Drawing.Point(412, 91);
            this.TextBoxTagNumber.Name = "TextBoxTagNumber";
            this.TextBoxTagNumber.Size = new System.Drawing.Size(161, 21);
            this.TextBoxTagNumber.TabIndex = 41;
            // 
            // TextBoxWorkOrderNumber
            // 
            this.TextBoxWorkOrderNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxWorkOrderNumber.Location = new System.Drawing.Point(412, 51);
            this.TextBoxWorkOrderNumber.Name = "TextBoxWorkOrderNumber";
            this.TextBoxWorkOrderNumber.Size = new System.Drawing.Size(161, 21);
            this.TextBoxWorkOrderNumber.TabIndex = 42;
            // 
            // TextBoxPermitNumber
            // 
            this.TextBoxPermitNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPermitNumber.Location = new System.Drawing.Point(697, 51);
            this.TextBoxPermitNumber.Name = "TextBoxPermitNumber";
            this.TextBoxPermitNumber.Size = new System.Drawing.Size(86, 21);
            this.TextBoxPermitNumber.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(685, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(689, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "نفرات مجری کار";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(583, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "شرح کار انجام شده و مشکلات تجهیز";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(511, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tag تجهیز";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(206, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "وضعیت Permit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(650, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "واحد صادر کننده Permit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(461, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "شماره Work Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(697, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "شماره Permit";
            // 
            // checkBoxShutDown
            // 
            this.checkBoxShutDown.AutoSize = true;
            this.checkBoxShutDown.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShutDown.ForeColor = System.Drawing.Color.White;
            this.checkBoxShutDown.Location = new System.Drawing.Point(165, 97);
            this.checkBoxShutDown.Name = "checkBoxShutDown";
            this.checkBoxShutDown.Size = new System.Drawing.Size(125, 17);
            this.checkBoxShutDown.TabIndex = 49;
            this.checkBoxShutDown.Text = "Shut Down ای شد";
            this.checkBoxShutDown.UseVisualStyleBackColor = false;
            this.checkBoxShutDown.CheckedChanged += new System.EventHandler(this.checkBoxShutDown_CheckedChanged);
            // 
            // comboBoxHoldBy
            // 
            this.comboBoxHoldBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxHoldBy.FormattingEnabled = true;
            this.comboBoxHoldBy.Items.AddRange(new object[] {
            "ایمنی",
            "بهره برداری"});
            this.comboBoxHoldBy.Location = new System.Drawing.Point(60, 70);
            this.comboBoxHoldBy.Name = "comboBoxHoldBy";
            this.comboBoxHoldBy.Size = new System.Drawing.Size(111, 21);
            this.comboBoxHoldBy.TabIndex = 46;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackgroundImage = global::BuPC_Report.Properties.Resources._4910518221598894796_1281;
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSave.Location = new System.Drawing.Point(746, 524);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(44, 45);
            this.ButtonSave.TabIndex = 50;
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackgroundImage = global::BuPC_Report.Properties.Resources.icons8_create_100;
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonEdit.Location = new System.Drawing.Point(696, 524);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(44, 45);
            this.ButtonEdit.TabIndex = 50;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackgroundImage = global::BuPC_Report.Properties.Resources.icons8_back_64;
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBack.Location = new System.Drawing.Point(60, 524);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(44, 45);
            this.ButtonBack.TabIndex = 50;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmNewRepRotin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuPC_Report.Properties.Resources.CRFP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 595);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.checkBoxShutDown);
            this.Controls.Add(this.checkBoxHoldBy);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.comboBoxHoldBy);
            this.Controls.Add(this.comboBoxPermitNumber);
            this.Controls.Add(this.TextBoxPeopleDone);
            this.Controls.Add(this.TextBoxRotinDiscription);
            this.Controls.Add(this.TextBoxTagNumber);
            this.Controls.Add(this.TextBoxWorkOrderNumber);
            this.Controls.Add(this.TextBoxPermitNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewRepRotin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش Rotin جدید";
            this.Load += new System.EventHandler(this.FrmNewRepRotin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxHoldBy;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxPermitNumber;
        private System.Windows.Forms.TextBox TextBoxPeopleDone;
        private System.Windows.Forms.TextBox TextBoxRotinDiscription;
        private System.Windows.Forms.TextBox TextBoxTagNumber;
        private System.Windows.Forms.TextBox TextBoxWorkOrderNumber;
        private System.Windows.Forms.TextBox TextBoxPermitNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxShutDown;
        private System.Windows.Forms.ComboBox comboBoxHoldBy;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonBack;
    }
}