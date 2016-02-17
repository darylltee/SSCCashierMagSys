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
    public partial class frmMetroMainMenu : MetroForm
    {
        private frmHome.MsgHandler Selected;
        public string user_type;

        public frmMetroMainMenu(frmHome.MsgHandler s)
        {
            InitializeComponent();
            Selected = s;
        }

   

        private void mtCashier_Click(object sender, EventArgs e)
        {
            Selected("manageOrderOfPayment");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Selected("reports");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Selected("orderOfPayment");
        }

        public void validateUserType()
        {
            switch(user_type)
            {
                case("Cashier"):
                {
                    mtOP.Enabled = false;
                    mtCashier.Enabled = true;
                    mtReports.Enabled = true;
                    break;
                }
                case ("Accounting"):
                {
                    mtOP.Enabled = true;
                    mtCashier.Enabled = false;
                    mtReports.Enabled = false;
                    break;
                }
                    
            }
        }

  

     
    }
}
