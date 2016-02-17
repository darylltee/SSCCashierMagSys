namespace Cashier
{
    partial class frmReportDaily
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cashierDailyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCIISDataSet = new Cashier.SCIISDataSet();
            this.dtDailyReportDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cashierDailyReportTableAdapter = new Cashier.SCIISDataSetTableAdapters.cashierDailyReportTableAdapter();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDailyReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCIISDataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashierDailyReportBindingSource
            // 
            this.cashierDailyReportBindingSource.DataMember = "cashierDailyReport";
            this.cashierDailyReportBindingSource.DataSource = this.SCIISDataSet;
            // 
            // SCIISDataSet
            // 
            this.SCIISDataSet.DataSetName = "SCIISDataSet";
            this.SCIISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtDailyReportDate
            // 
            this.dtDailyReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDailyReportDate.Location = new System.Drawing.Point(7, 32);
            this.dtDailyReportDate.Name = "dtDailyReportDate";
            this.dtDailyReportDate.Size = new System.Drawing.Size(126, 20);
            this.dtDailyReportDate.TabIndex = 1;
            this.dtDailyReportDate.ValueChanged += new System.EventHandler(this.dtDailyReportDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Date";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportViewer1.DocumentMapWidth = 150;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.cashierDailyReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cashier.Reports.DailyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(166, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(843, 413);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.ZoomPercent = 120;
            // 
            // cashierDailyReportTableAdapter
            // 
            this.cashierDailyReportTableAdapter.ClearBeforeFill = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTile3);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.dtDailyReportDate);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(142, 358);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(7, 69);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(126, 42);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Daily Report";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(7, 136);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(126, 42);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Weekly Report";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(7, 203);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(126, 42);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Monthly Report";
            this.metroTile3.UseSelectable = true;
            // 
            // frmReportDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 444);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDaily";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReportDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashierDailyReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCIISDataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDailyReportDate;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cashierDailyReportBindingSource;
        private SCIISDataSet SCIISDataSet;
        private SCIISDataSetTableAdapters.cashierDailyReportTableAdapter cashierDailyReportTableAdapter;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}