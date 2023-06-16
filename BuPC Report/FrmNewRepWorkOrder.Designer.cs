namespace BuPC_Report
{
    partial class FrmNewRepWorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewRepWorkOrder));
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.TextBoxPeopleDone = new System.Windows.Forms.TextBox();
            this.TextBoxPermitReport = new System.Windows.Forms.TextBox();
            this.TextBoxWorkOrderNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxPermitSubject = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TextBoxPermitWhyNot = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxPercentFollow = new System.Windows.Forms.TextBox();
            this.checkBoxFollow = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxUnit = new System.Windows.Forms.ComboBox();
            this.ComboBoxPermitNumber = new System.Windows.Forms.ComboBox();
            this.TextBoxPermitNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDone.ForeColor = System.Drawing.Color.White;
            this.checkBoxDone.Location = new System.Drawing.Point(777, 290);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDone.TabIndex = 7;
            this.checkBoxDone.Text = "انجام شد";
            this.checkBoxDone.UseVisualStyleBackColor = false;
            this.checkBoxDone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TextBoxPeopleDone
            // 
            this.TextBoxPeopleDone.Location = new System.Drawing.Point(170, 289);
            this.TextBoxPeopleDone.Multiline = true;
            this.TextBoxPeopleDone.Name = "TextBoxPeopleDone";
            this.TextBoxPeopleDone.Size = new System.Drawing.Size(390, 48);
            this.TextBoxPeopleDone.TabIndex = 10;
            // 
            // TextBoxPermitReport
            // 
            this.TextBoxPermitReport.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPermitReport.Location = new System.Drawing.Point(170, 52);
            this.TextBoxPermitReport.Multiline = true;
            this.TextBoxPermitReport.Name = "TextBoxPermitReport";
            this.TextBoxPermitReport.Size = new System.Drawing.Size(390, 200);
            this.TextBoxPermitReport.TabIndex = 6;
            this.TextBoxPermitReport.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TextBoxWorkOrderNumber
            // 
            this.TextBoxWorkOrderNumber.ForeColor = System.Drawing.Color.Black;
            this.TextBoxWorkOrderNumber.Location = new System.Drawing.Point(678, 94);
            this.TextBoxWorkOrderNumber.Name = "TextBoxWorkOrderNumber";
            this.TextBoxWorkOrderNumber.Size = new System.Drawing.Size(140, 21);
            this.TextBoxWorkOrderNumber.TabIndex = 3;
            this.TextBoxWorkOrderNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(721, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(466, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "نفرات مجری کار";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(360, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "شرح کار انجام شده و مشکلات تجهیز";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(763, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "وضعیت Permit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(686, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "واحد صادر کننده Permit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(706, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "شماره Work Order";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(733, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "شماره Permit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "تاریخ و ساعت جاری سیستم";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "کاربر و شیفت جاری سیستم";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(762, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "موضوع Permit";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TextBoxPermitSubject
            // 
            this.TextBoxPermitSubject.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPermitSubject.Location = new System.Drawing.Point(579, 185);
            this.TextBoxPermitSubject.Multiline = true;
            this.TextBoxPermitSubject.Name = "TextBoxPermitSubject";
            this.TextBoxPermitSubject.Size = new System.Drawing.Size(271, 67);
            this.TextBoxPermitSubject.TabIndex = 5;
            this.TextBoxPermitSubject.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(727, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "دلایل ناتمامی Permit";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // TextBoxPermitWhyNot
            // 
            this.TextBoxPermitWhyNot.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPermitWhyNot.Location = new System.Drawing.Point(170, 372);
            this.TextBoxPermitWhyNot.Multiline = true;
            this.TextBoxPermitWhyNot.Name = "TextBoxPermitWhyNot";
            this.TextBoxPermitWhyNot.Size = new System.Drawing.Size(681, 46);
            this.TextBoxPermitWhyNot.TabIndex = 11;
            this.TextBoxPermitWhyNot.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BuPC_Report.Properties.Resources.icons8_back_64;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(37, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 45);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BuPC_Report.Properties.Resources.icons8_create_100;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(804, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 45);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BuPC_Report.Properties.Resources._4910518221598894796_1281;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(854, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TextBoxPercentFollow
            // 
            this.TextBoxPercentFollow.Location = new System.Drawing.Point(733, 311);
            this.TextBoxPercentFollow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPercentFollow.Name = "TextBoxPercentFollow";
            this.TextBoxPercentFollow.Size = new System.Drawing.Size(29, 21);
            this.TextBoxPercentFollow.TabIndex = 9;
            // 
            // checkBoxFollow
            // 
            this.checkBoxFollow.AutoSize = true;
            this.checkBoxFollow.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFollow.ForeColor = System.Drawing.Color.White;
            this.checkBoxFollow.Location = new System.Drawing.Point(762, 313);
            this.checkBoxFollow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFollow.Name = "checkBoxFollow";
            this.checkBoxFollow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFollow.Size = new System.Drawing.Size(90, 17);
            this.checkBoxFollow.TabIndex = 8;
            this.checkBoxFollow.Text = "ادامه دارد و ";
            this.checkBoxFollow.UseVisualStyleBackColor = false;
            this.checkBoxFollow.CheckedChanged += new System.EventHandler(this.checkBoxFollow_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(576, 314);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "درصد از کار انجام شده است.";
            // 
            // ComboBoxUnit
            // 
            this.ComboBoxUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxUnit.FormattingEnabled = true;
            this.ComboBoxUnit.Items.AddRange(new object[] {
            "اتان",
            "کولینگ آف ساید",
            "متانول",
            "ASU",
            "آتشنشانی",
            "حراست",
            "RO",
            "GSP",
            "Utility"});
            this.ComboBoxUnit.Location = new System.Drawing.Point(678, 134);
            this.ComboBoxUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxUnit.Name = "ComboBoxUnit";
            this.ComboBoxUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxUnit.Size = new System.Drawing.Size(141, 21);
            this.ComboBoxUnit.TabIndex = 4;
            // 
            // ComboBoxPermitNumber
            // 
            this.ComboBoxPermitNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxPermitNumber.FormattingEnabled = true;
            this.ComboBoxPermitNumber.Items.AddRange(new object[] {
            "C",
            "H"});
            this.ComboBoxPermitNumber.Location = new System.Drawing.Point(678, 51);
            this.ComboBoxPermitNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxPermitNumber.Name = "ComboBoxPermitNumber";
            this.ComboBoxPermitNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxPermitNumber.Size = new System.Drawing.Size(41, 21);
            this.ComboBoxPermitNumber.TabIndex = 1;
            this.ComboBoxPermitNumber.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPermitNumber_SelectedIndexChanged_1);
            // 
            // TextBoxPermitNumber
            // 
            this.TextBoxPermitNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPermitNumber.Location = new System.Drawing.Point(733, 52);
            this.TextBoxPermitNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPermitNumber.Name = "TextBoxPermitNumber";
            this.TextBoxPermitNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPermitNumber.Size = new System.Drawing.Size(86, 21);
            this.TextBoxPermitNumber.TabIndex = 2;
            this.TextBoxPermitNumber.TextChanged += new System.EventHandler(this.TextBoxPermitNumber_TextChanged);
            // 
            // FrmNewRepWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BuPC_Report.Properties.Resources.CRFP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 655);
            this.Controls.Add(this.ComboBoxPermitNumber);
            this.Controls.Add(this.TextBoxPermitNumber);
            this.Controls.Add(this.ComboBoxUnit);
            this.Controls.Add(this.TextBoxPercentFollow);
            this.Controls.Add(this.checkBoxFollow);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.TextBoxPeopleDone);
            this.Controls.Add(this.TextBoxPermitReport);
            this.Controls.Add(this.TextBoxPermitWhyNot);
            this.Controls.Add(this.TextBoxPermitSubject);
            this.Controls.Add(this.TextBoxWorkOrderNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewRepWorkOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "گزارش Work Order جدید";
            this.Load += new System.EventHandler(this.FrmNewRepWorkOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.TextBox TextBoxPeopleDone;
        private System.Windows.Forms.TextBox TextBoxPermitReport;
        private System.Windows.Forms.TextBox TextBoxWorkOrderNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxPermitSubject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextBoxPermitWhyNot;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxPercentFollow;
        private System.Windows.Forms.CheckBox checkBoxFollow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboBoxUnit;
        private System.Windows.Forms.ComboBox ComboBoxPermitNumber;
        private System.Windows.Forms.TextBox TextBoxPermitNumber;
    }
}