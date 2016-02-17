using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cashier.classes;

namespace Cashier
{
    public partial class frmHome : MetroForm
    {

        public delegate void MsgHandler(string msg);
        MsgHandler modDbAction;

        private Form currForm;
        private frmLogin loginForm;

        private bool isLoggedIn = false;

        public frmHome()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 8);
            this.Height = Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 8); 
            showOptions();
        }

        private void showMenu()
        {
            frmMetroMainMenu f = new frmMetroMainMenu(new MsgHandler(showSelected) );
            f.Width = this.Width;
            f.Height = this.Height - ( fileToolStripMenuItem.Height + toolStrip1.Height );

            f.ControlBox = false;
            f.MdiParent = this;
            f.Show();

            // validate user type
            User s = new User(loginForm.userID);
            f.user_type = s.userData["userDept"];
            f.validateUserType();
            // set user details
            this.btnUser.Text = s.userData["fullname"];
            this.btnUser.Width += s.userData["fullname"].Length;
            this.lbDept.Text = s.userData["userDept"];

            f.WindowState = FormWindowState.Maximized;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showLogin();
            showOptions();
        }

        private void showSelected(string msg)
        {
            if (msg == "orderOfPayment")
            {
                showManageOrderOfPayment();
            }
            else if (msg == "manageOrderOfPayment")
            {
                showPaymentProcess();
            }
            else if (msg == "reports")
            {
                showReports();
            }
            else if (msg == "home")
            {
                btnUser.Tag = loginForm.userID;
               
                this.ActiveMdiChild.Close();
                isLoggedIn = true;
                showMenu();
                showOptions(true);

            }
            else
            {
                for (int i = 0; i < this.MdiChildren.Count(); i++)
                {
                    this.MdiChildren[i].Close();
                }

                if (isLoggedIn)
                {
                    showOptions(true);
                    showMenu();
                }
                else
                {
                    showLogin();
                    showOptions();
                }
            }
  
        }

        private void showManaged(Form f)
        {
            currForm = f;
            f.ControlBox = false;
            f.Show();
            showOptions(true);
            f.WindowState = FormWindowState.Maximized;
        }




        // View Forms

        private void showLogin()
        {
            frmLogin f = new frmLogin(new MsgHandler(showSelected));
            f.ControlBox = false;
            f.MdiParent = this;
            loginForm = f;
            showManaged(f);
        }

        private void showManageOrderOfPayment()
        {
            
            frmOrPayManageData f = frmOrPayManageData.CreateInstance();
            MsgHandler dbAction = new MsgHandler(f.DbAction);

            modDbAction = dbAction;
            f.MdiParent = this;

          //  f.lvManageRecord.Width = this.Width / 2;
            f.lvManageRecord.Height = this.Height - 295;
            showManaged(f);
            
        }

        private void showReports()
        {
            frmReportDaily f = new frmReportDaily();
            f.MdiParent = this;

            showManaged(f);
        }

        private void showPaymentProcess()
        {
            frmPayment f =  frmPayment.CreateInstance();
            MsgHandler dbAction = new MsgHandler(f.DbAction);

            modDbAction = dbAction;
            f.MdiParent = this;

            showManaged(f);

        }


        // ToolStrip Action Events

        private void tspAdd_Click(object sender, EventArgs e)
        {
            try
            {
                modDbAction("add");
            }
            catch { Console.Beep(); }
        }

        private void showOptions(bool show = false)
        {
            toolStrip1.Items[2].Visible = show;
            toolStrip1.Items[3].Visible = show;
            toolStrip1.Items[4].Visible = show;
            toolStrip1.Items[5].Visible = show;
            toolStrip1.Items[6].Visible = show;
            btnLogout.Visible = show;
            btnUser.Visible = show;
        }

        private void tspHome_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                this.MdiChildren[i].Close();
            }
           
            showSelected("");
          
          
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
            btnUser.Tag = "";
            this.lbDept.Text = "";
            showSelected("");
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ShadowType = MetroFormShadowType.Flat;
        }




       



        
    }
}
