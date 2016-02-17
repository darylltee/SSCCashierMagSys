using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Cashier
{
    public partial class frmReportDaily : MetroForm
    {
        public frmReportDaily()
        {
            InitializeComponent();
        }

        private void frmReportDaily_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SCIISDataSet.cashierDailyReport' table. You can move, or remove it, as needed.
            this.cashierDailyReportTableAdapter.Fill(this.SCIISDataSet.cashierDailyReport, dtDailyReportDate.Value.ToShortDateString());
            

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void dtDailyReportDate_ValueChanged(object sender, EventArgs e)
        {
            frmReportDaily_Load(null, null);
        }
    }
}
