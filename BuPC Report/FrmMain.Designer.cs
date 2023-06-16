namespace BuPC_Report
{
    partial class FrmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.فایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشروتینToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشPermitباWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.گزارشToDoListروزبعدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشToDoListشبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشپرمیتهایانجامشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشروتینهایانجامشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشکلپرمیتهایماهجاریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتتفکیکیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.گزارشToDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نمایشToDoListروزگذشتهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نمایشToDoListهایبیشترToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ذخیرهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ذخیرهToDoListشبگذشتهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ذخیرهToDoListروزگذشتهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ذخیرهToDoListهایانتخابیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ذخیرهWorkOrderهایانتخابیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ذخیرهPermitهایاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجازبرنامهToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chartWorkOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRotin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelDateAndTime = new System.Windows.Forms.Label();
            this.rotinانتخابیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشPermitانجامشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWorkOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRotin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فایلToolStripMenuItem,
            this.نمایشToolStripMenuItem,
            this.ذخیرهToolStripMenuItem,
            this.خروجازبرنامهToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Leave += new System.EventHandler(this.menuStrip1_Leave);
            // 
            // فایلToolStripMenuItem
            // 
            this.فایلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشPermitانجامشدهToolStripMenuItem,
            this.گزارشروتینToolStripMenuItem,
            this.گزارشPermitباWorkOrderToolStripMenuItem,
            this.toolStripSeparator1,
            this.گزارشToDoListروزبعدToolStripMenuItem,
            this.گزارشToDoListشبToolStripMenuItem});
            this.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            resources.ApplyResources(this.فایلToolStripMenuItem, "فایلToolStripMenuItem");
            // 
            // گزارشروتینToolStripMenuItem
            // 
            this.گزارشروتینToolStripMenuItem.Name = "گزارشروتینToolStripMenuItem";
            resources.ApplyResources(this.گزارشروتینToolStripMenuItem, "گزارشروتینToolStripMenuItem");
            this.گزارشروتینToolStripMenuItem.Click += new System.EventHandler(this.گزارشروتینToolStripMenuItem_Click_1);
            // 
            // گزارشPermitباWorkOrderToolStripMenuItem
            // 
            this.گزارشPermitباWorkOrderToolStripMenuItem.Name = "گزارشPermitباWorkOrderToolStripMenuItem";
            resources.ApplyResources(this.گزارشPermitباWorkOrderToolStripMenuItem, "گزارشPermitباWorkOrderToolStripMenuItem");
            this.گزارشPermitباWorkOrderToolStripMenuItem.Click += new System.EventHandler(this.گزارشPermitباWorkOrderToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // گزارشToDoListروزبعدToolStripMenuItem
            // 
            this.گزارشToDoListروزبعدToolStripMenuItem.Name = "گزارشToDoListروزبعدToolStripMenuItem";
            resources.ApplyResources(this.گزارشToDoListروزبعدToolStripMenuItem, "گزارشToDoListروزبعدToolStripMenuItem");
            this.گزارشToDoListروزبعدToolStripMenuItem.Click += new System.EventHandler(this.گزارشToDoListروزبعدToolStripMenuItem_Click_1);
            // 
            // گزارشToDoListشبToolStripMenuItem
            // 
            this.گزارشToDoListشبToolStripMenuItem.Name = "گزارشToDoListشبToolStripMenuItem";
            resources.ApplyResources(this.گزارشToDoListشبToolStripMenuItem, "گزارشToDoListشبToolStripMenuItem");
            this.گزارشToDoListشبToolStripMenuItem.Click += new System.EventHandler(this.گزارشToDoListشبToolStripMenuItem_Click_1);
            // 
            // نمایشToolStripMenuItem
            // 
            this.نمایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشپرمیتهایانجامشدهToolStripMenuItem,
            this.گزارشروتینهایانجامشدهToolStripMenuItem,
            this.گزارشاتتفکیکیToolStripMenuItem,
            this.گزارشکلپرمیتهایماهجاریToolStripMenuItem,
            this.toolStripSeparator2,
            this.گزارشToDoListToolStripMenuItem,
            this.نمایشToDoListروزگذشتهToolStripMenuItem,
            this.نمایشToDoListهایبیشترToolStripMenuItem});
            this.نمایشToolStripMenuItem.Name = "نمایشToolStripMenuItem";
            resources.ApplyResources(this.نمایشToolStripMenuItem, "نمایشToolStripMenuItem");
            // 
            // گزارشپرمیتهایانجامشدهToolStripMenuItem
            // 
            this.گزارشپرمیتهایانجامشدهToolStripMenuItem.Name = "گزارشپرمیتهایانجامشدهToolStripMenuItem";
            resources.ApplyResources(this.گزارشپرمیتهایانجامشدهToolStripMenuItem, "گزارشپرمیتهایانجامشدهToolStripMenuItem");
            // 
            // گزارشروتینهایانجامشدهToolStripMenuItem
            // 
            this.گزارشروتینهایانجامشدهToolStripMenuItem.Name = "گزارشروتینهایانجامشدهToolStripMenuItem";
            resources.ApplyResources(this.گزارشروتینهایانجامشدهToolStripMenuItem, "گزارشروتینهایانجامشدهToolStripMenuItem");
            // 
            // گزارشکلپرمیتهایماهجاریToolStripMenuItem
            // 
            this.گزارشکلپرمیتهایماهجاریToolStripMenuItem.Name = "گزارشکلپرمیتهایماهجاریToolStripMenuItem";
            resources.ApplyResources(this.گزارشکلپرمیتهایماهجاریToolStripMenuItem, "گزارشکلپرمیتهایماهجاریToolStripMenuItem");
            // 
            // گزارشاتتفکیکیToolStripMenuItem
            // 
            this.گزارشاتتفکیکیToolStripMenuItem.Name = "گزارشاتتفکیکیToolStripMenuItem";
            resources.ApplyResources(this.گزارشاتتفکیکیToolStripMenuItem, "گزارشاتتفکیکیToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // گزارشToDoListToolStripMenuItem
            // 
            this.گزارشToDoListToolStripMenuItem.Name = "گزارشToDoListToolStripMenuItem";
            resources.ApplyResources(this.گزارشToDoListToolStripMenuItem, "گزارشToDoListToolStripMenuItem");
            // 
            // نمایشToDoListروزگذشتهToolStripMenuItem
            // 
            this.نمایشToDoListروزگذشتهToolStripMenuItem.Name = "نمایشToDoListروزگذشتهToolStripMenuItem";
            resources.ApplyResources(this.نمایشToDoListروزگذشتهToolStripMenuItem, "نمایشToDoListروزگذشتهToolStripMenuItem");
            // 
            // نمایشToDoListهایبیشترToolStripMenuItem
            // 
            this.نمایشToDoListهایبیشترToolStripMenuItem.Name = "نمایشToDoListهایبیشترToolStripMenuItem";
            resources.ApplyResources(this.نمایشToDoListهایبیشترToolStripMenuItem, "نمایشToDoListهایبیشترToolStripMenuItem");
            // 
            // ذخیرهToolStripMenuItem
            // 
            this.ذخیرهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ذخیرهPermitهایاToolStripMenuItem,
            this.rotinانتخابیToolStripMenuItem,
            this.ذخیرهWorkOrderهایانتخابیToolStripMenuItem,
            this.toolStripSeparator4,
            this.ذخیرهToDoListشبگذشتهToolStripMenuItem,
            this.ذخیرهToDoListروزگذشتهToolStripMenuItem,
            this.ذخیرهToDoListهایانتخابیToolStripMenuItem});
            this.ذخیرهToolStripMenuItem.Name = "ذخیرهToolStripMenuItem";
            resources.ApplyResources(this.ذخیرهToolStripMenuItem, "ذخیرهToolStripMenuItem");
            // 
            // ذخیرهToDoListشبگذشتهToolStripMenuItem
            // 
            this.ذخیرهToDoListشبگذشتهToolStripMenuItem.Name = "ذخیرهToDoListشبگذشتهToolStripMenuItem";
            resources.ApplyResources(this.ذخیرهToDoListشبگذشتهToolStripMenuItem, "ذخیرهToDoListشبگذشتهToolStripMenuItem");
            // 
            // ذخیرهToDoListروزگذشتهToolStripMenuItem
            // 
            this.ذخیرهToDoListروزگذشتهToolStripMenuItem.Name = "ذخیرهToDoListروزگذشتهToolStripMenuItem";
            resources.ApplyResources(this.ذخیرهToDoListروزگذشتهToolStripMenuItem, "ذخیرهToDoListروزگذشتهToolStripMenuItem");
            // 
            // ذخیرهToDoListهایانتخابیToolStripMenuItem
            // 
            this.ذخیرهToDoListهایانتخابیToolStripMenuItem.Name = "ذخیرهToDoListهایانتخابیToolStripMenuItem";
            resources.ApplyResources(this.ذخیرهToDoListهایانتخابیToolStripMenuItem, "ذخیرهToDoListهایانتخابیToolStripMenuItem");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // ذخیرهWorkOrderهایانتخابیToolStripMenuItem
            // 
            this.ذخیرهWorkOrderهایانتخابیToolStripMenuItem.Name = "ذخیرهWorkOrderهایانتخابیToolStripMenuItem";
            resources.ApplyResources(this.ذخیرهWorkOrderهایانتخابیToolStripMenuItem, "ذخیرهWorkOrderهایانتخابیToolStripMenuItem");
            // 
            // ذخیرهPermitهایاToolStripMenuItem
            // 
            this.ذخیرهPermitهایاToolStripMenuItem.Name = "ذخیرهPermitهایاToolStripMenuItem";
            resources.ApplyResources(this.ذخیرهPermitهایاToolStripMenuItem, "ذخیرهPermitهایاToolStripMenuItem");
            // 
            // خروجازبرنامهToolStripMenuItem1
            // 
            this.خروجازبرنامهToolStripMenuItem1.Name = "خروجازبرنامهToolStripMenuItem1";
            resources.ApplyResources(this.خروجازبرنامهToolStripMenuItem1, "خروجازبرنامهToolStripMenuItem1");
            this.خروجازبرنامهToolStripMenuItem1.Click += new System.EventHandler(this.خروجازبرنامهToolStripMenuItem1_Click);
            // 
            // chartWorkOrder
            // 
            chartArea1.Name = "ChartAreaWorkOrder";
            this.chartWorkOrder.ChartAreas.Add(chartArea1);
            legend1.Name = "LegendWorkOrder";
            this.chartWorkOrder.Legends.Add(legend1);
            resources.ApplyResources(this.chartWorkOrder, "chartWorkOrder");
            this.chartWorkOrder.Name = "chartWorkOrder";
            series1.ChartArea = "ChartAreaWorkOrder";
            series1.Legend = "LegendWorkOrder";
            series1.Name = "WorkOrders";
            this.chartWorkOrder.Series.Add(series1);
            // 
            // chartRotin
            // 
            chartArea2.Name = "ChartAreaRotin";
            this.chartRotin.ChartAreas.Add(chartArea2);
            legend2.Name = "LegendRotin";
            this.chartRotin.Legends.Add(legend2);
            resources.ApplyResources(this.chartRotin, "chartRotin");
            this.chartRotin.Name = "chartRotin";
            series2.ChartArea = "ChartAreaRotin";
            series2.Legend = "LegendRotin";
            series2.Name = "Rotins";
            this.chartRotin.Series.Add(series2);
            // 
            // labelUser
            // 
            resources.ApplyResources(this.labelUser, "labelUser");
            this.labelUser.Name = "labelUser";
            // 
            // labelDateAndTime
            // 
            resources.ApplyResources(this.labelDateAndTime, "labelDateAndTime");
            this.labelDateAndTime.Name = "labelDateAndTime";
            // 
            // rotinانتخابیToolStripMenuItem
            // 
            this.rotinانتخابیToolStripMenuItem.Name = "rotinانتخابیToolStripMenuItem";
            resources.ApplyResources(this.rotinانتخابیToolStripMenuItem, "rotinانتخابیToolStripMenuItem");
            // 
            // گزارشPermitانجامشدهToolStripMenuItem
            // 
            this.گزارشPermitانجامشدهToolStripMenuItem.Name = "گزارشPermitانجامشدهToolStripMenuItem";
            resources.ApplyResources(this.گزارشPermitانجامشدهToolStripMenuItem, "گزارشPermitانجامشدهToolStripMenuItem");
            this.گزارشPermitانجامشدهToolStripMenuItem.Click += new System.EventHandler(this.گزارشPermitانجامشدهToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDateAndTime);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.chartRotin);
            this.Controls.Add(this.chartWorkOrder);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWorkOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRotin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem فایلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem نمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشپرمیتهایانجامشدهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشروتینهایانجامشدهToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem گزارشکلپرمیتهایماهجاریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتتفکیکیToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWorkOrder;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRotin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelDateAndTime;
        private System.Windows.Forms.ToolStripMenuItem گزارشToDoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نمایشToDoListروزگذشتهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نمایشToDoListهایبیشترToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ذخیرهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ذخیرهToDoListشبگذشتهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ذخیرهToDoListروزگذشتهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ذخیرهToDoListهایانتخابیToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ذخیرهPermitهایاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ذخیرهWorkOrderهایانتخابیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجازبرنامهToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem گزارشروتینToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشPermitباWorkOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشToDoListروزبعدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشToDoListشبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشPermitانجامشدهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotinانتخابیToolStripMenuItem;
    }
}