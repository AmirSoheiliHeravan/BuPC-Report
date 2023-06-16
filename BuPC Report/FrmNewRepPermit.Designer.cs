namespace BuPC_Report
{
    partial class FrmNewRepPermit
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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.checkBoxFollo = new System.Windows.Forms.CheckBox();
            this.checkBoxHoldBy = new System.Windows.Forms.CheckBox();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.ComboBoxUnit = new System.Windows.Forms.ComboBox();
            this.ComboBoxHoldBy = new System.Windows.Forms.ComboBox();
            this.ComboBoxPermitNumber = new System.Windows.Forms.ComboBox();
            this.TextBoxPermitPeopleDone = new System.Windows.Forms.TextBox();
            this.TextBoxPermitDiscription = new System.Windows.Forms.TextBox();
            this.TextBoxPermitSubject = new System.Windows.Forms.TextBox();
            this.TextBoxPermitNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPercentFollo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackgroundImage = global::BuPC_Report.Properties.Resources.icons8_back_64;
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBack.Location = new System.Drawing.Point(74, 527);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonBack.Size = new System.Drawing.Size(45, 45);
            this.ButtonBack.TabIndex = 14;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackgroundImage = global::BuPC_Report.Properties.Resources.icons8_create_100;
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonEdit.Location = new System.Drawing.Point(816, 527);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonEdit.Size = new System.Drawing.Size(43, 45);
            this.ButtonEdit.TabIndex = 13;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackgroundImage = global::BuPC_Report.Properties.Resources._4910518221598894796_1281;
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSave.Location = new System.Drawing.Point(874, 527);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSave.Size = new System.Drawing.Size(43, 45);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // checkBoxFollo
            // 
            this.checkBoxFollo.AutoSize = true;
            this.checkBoxFollo.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFollo.ForeColor = System.Drawing.Color.White;
            this.checkBoxFollo.Location = new System.Drawing.Point(294, 105);
            this.checkBoxFollo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFollo.Name = "checkBoxFollo";
            this.checkBoxFollo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFollo.Size = new System.Drawing.Size(90, 17);
            this.checkBoxFollo.TabIndex = 8;
            this.checkBoxFollo.Text = "ادامه دارد و ";
            this.checkBoxFollo.UseVisualStyleBackColor = false;
            this.checkBoxFollo.CheckedChanged += new System.EventHandler(this.checkBoxFollo_CheckedChanged);
            // 
            // checkBoxHoldBy
            // 
            this.checkBoxHoldBy.AutoSize = true;
            this.checkBoxHoldBy.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHoldBy.ForeColor = System.Drawing.Color.White;
            this.checkBoxHoldBy.Location = new System.Drawing.Point(268, 80);
            this.checkBoxHoldBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxHoldBy.Name = "checkBoxHoldBy";
            this.checkBoxHoldBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxHoldBy.Size = new System.Drawing.Size(116, 17);
            this.checkBoxHoldBy.TabIndex = 6;
            this.checkBoxHoldBy.Text = "Hold گردید توسط";
            this.checkBoxHoldBy.UseVisualStyleBackColor = false;
            this.checkBoxHoldBy.CheckedChanged += new System.EventHandler(this.checkBoxHoldBy_CheckedChanged);
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDone.ForeColor = System.Drawing.Color.White;
            this.checkBoxDone.Location = new System.Drawing.Point(310, 57);
            this.checkBoxDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDone.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDone.TabIndex = 5;
            this.checkBoxDone.Text = "انجام شد";
            this.checkBoxDone.UseVisualStyleBackColor = false;
            this.checkBoxDone.CheckedChanged += new System.EventHandler(this.checkBoxDone_CheckedChanged);
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
            this.ComboBoxUnit.Location = new System.Drawing.Point(517, 53);
            this.ComboBoxUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxUnit.Name = "ComboBoxUnit";
            this.ComboBoxUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxUnit.Size = new System.Drawing.Size(153, 21);
            this.ComboBoxUnit.TabIndex = 3;
            // 
            // ComboBoxHoldBy
            // 
            this.ComboBoxHoldBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxHoldBy.FormattingEnabled = true;
            this.ComboBoxHoldBy.Items.AddRange(new object[] {
            "ایمنی",
            "بهره برداری"});
            this.ComboBoxHoldBy.Location = new System.Drawing.Point(132, 76);
            this.ComboBoxHoldBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxHoldBy.Name = "ComboBoxHoldBy";
            this.ComboBoxHoldBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxHoldBy.Size = new System.Drawing.Size(129, 21);
            this.ComboBoxHoldBy.TabIndex = 7;
            // 
            // ComboBoxPermitNumber
            // 
            this.ComboBoxPermitNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxPermitNumber.FormattingEnabled = true;
            this.ComboBoxPermitNumber.Items.AddRange(new object[] {
            "C",
            "H"});
            this.ComboBoxPermitNumber.Location = new System.Drawing.Point(762, 53);
            this.ComboBoxPermitNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxPermitNumber.Name = "ComboBoxPermitNumber";
            this.ComboBoxPermitNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxPermitNumber.Size = new System.Drawing.Size(41, 21);
            this.ComboBoxPermitNumber.TabIndex = 1;
            this.ComboBoxPermitNumber.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPermitNumber_SelectedIndexChanged);
            // 
            // TextBoxPermitPeopleDone
            // 
            this.TextBoxPermitPeopleDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPermitPeopleDone.Location = new System.Drawing.Point(74, 295);
            this.TextBoxPermitPeopleDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPermitPeopleDone.Multiline = true;
            this.TextBoxPermitPeopleDone.Name = "TextBoxPermitPeopleDone";
            this.TextBoxPermitPeopleDone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPermitPeopleDone.Size = new System.Drawing.Size(843, 48);
            this.TextBoxPermitPeopleDone.TabIndex = 11;
            // 
            // TextBoxPermitDiscription
            // 
            this.TextBoxPermitDiscription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPermitDiscription.Location = new System.Drawing.Point(74, 170);
            this.TextBoxPermitDiscription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPermitDiscription.Multiline = true;
            this.TextBoxPermitDiscription.Name = "TextBoxPermitDiscription";
            this.TextBoxPermitDiscription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPermitDiscription.Size = new System.Drawing.Size(842, 103);
            this.TextBoxPermitDiscription.TabIndex = 10;
            // 
            // TextBoxPermitSubject
            // 
            this.TextBoxPermitSubject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPermitSubject.Location = new System.Drawing.Point(517, 95);
            this.TextBoxPermitSubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPermitSubject.Multiline = true;
            this.TextBoxPermitSubject.Name = "TextBoxPermitSubject";
            this.TextBoxPermitSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPermitSubject.Size = new System.Drawing.Size(400, 49);
            this.TextBoxPermitSubject.TabIndex = 4;
            // 
            // TextBoxPermitNumber
            // 
            this.TextBoxPermitNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPermitNumber.Location = new System.Drawing.Point(817, 54);
            this.TextBoxPermitNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPermitNumber.Name = "TextBoxPermitNumber";
            this.TextBoxPermitNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPermitNumber.Size = new System.Drawing.Size(100, 21);
            this.TextBoxPermitNumber.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(803, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(817, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "نفرات مجری کار";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(799, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "شرح کار انجام شده";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(831, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "موضوع Permit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(301, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "وضعیت Permit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(533, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "واحد صادر کننده Permit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(834, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "شماره Permit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "تاریخ و ساعت جاری سیستم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "کاربر و شیفت جاری سیستم";
            // 
            // TextBoxPercentFollo
            // 
            this.TextBoxPercentFollo.Location = new System.Drawing.Point(253, 103);
            this.TextBoxPercentFollo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPercentFollo.Name = "TextBoxPercentFollo";
            this.TextBoxPercentFollo.Size = new System.Drawing.Size(41, 21);
            this.TextBoxPercentFollo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "درصد از کار انجام شده است.";
            // 
            // FrmNewRepPermit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuPC_Report.Properties.Resources.CRFP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 597);
            this.Controls.Add(this.TextBoxPercentFollo);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.checkBoxFollo);
            this.Controls.Add(this.checkBoxHoldBy);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.ComboBoxUnit);
            this.Controls.Add(this.ComboBoxHoldBy);
            this.Controls.Add(this.ComboBoxPermitNumber);
            this.Controls.Add(this.TextBoxPermitPeopleDone);
            this.Controls.Add(this.TextBoxPermitDiscription);
            this.Controls.Add(this.TextBoxPermitSubject);
            this.Controls.Add(this.TextBoxPermitNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewRepPermit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش Permit جدید";
            this.Load += new System.EventHandler(this.FrmNewRepPermit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.CheckBox checkBoxFollo;
        private System.Windows.Forms.CheckBox checkBoxHoldBy;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.ComboBox ComboBoxUnit;
        private System.Windows.Forms.ComboBox ComboBoxHoldBy;
        private System.Windows.Forms.ComboBox ComboBoxPermitNumber;
        private System.Windows.Forms.TextBox TextBoxPermitPeopleDone;
        private System.Windows.Forms.TextBox TextBoxPermitDiscription;
        private System.Windows.Forms.TextBox TextBoxPermitSubject;
        private System.Windows.Forms.TextBox TextBoxPermitNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPercentFollo;
        private System.Windows.Forms.Label label4;
    }
}