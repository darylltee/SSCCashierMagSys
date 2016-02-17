using System;
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
    public partial class frmOrPayManageData : frmManageRecord
        
    {
        //, IMessageFilter
        // query string ( table name can be orderOfPayment or StudentAccount[in the server]) 
        //string sql = "SELECT * FROM studentAccount JOIN student ON student.StudID = studentAccount.StudID WHERE Balance > 0";
        
        string sql = "SELECT  TOP 50 SA.SemNo, SA.StudID,S.StudNo, SUM(Amount - ISNULL(Payment, 0 )) as Amount ,FName, MName, LName, ProgCode  FROM Student_Account as SA JOIN Student as S ON SA.StudID = S.StudID JOIN StudentCourse as SC ON SC.StudID = SA.StudID WHERE SA.semNo = " + Semester.getCurrentSemester() + " GROUP BY SA.StudID,S.StudNo, SA.SemNo,FName, MName,LName, ProgCode ";
        string opQuery = "SELECT TOP 50 OPNo, OP.Amount, CAST( CASE WHEN OP.Payor IS NULL OR OP.Payor = '' THEN CONCAT(FName,' ',MName,' ',LName) ELSE OP.Payor END AS varchar(100))  as Payor, CAST (CASE WHEN  PAID = 0 THEN 'Not Paid' ELSE 'Paid' END as varchar(50) ) as Paid From tbl_PayOrder as OP  JOIN Student as S ON S.StudID = OP.StudID WHERE Paid = 0 ORDER BY OP.OPNo DESC";
        public frmOrPayManageData()
        {
            InitializeComponent();

            //Application.AddMessageFilter(this);
            RefreshData(" ");

            new clsDB().Con().FillLvw(lvOP, opQuery);
        }

       

        public static frmOrPayManageData CreateInstance()
        {
            frmOrPayManageData f;
            if (thisForm == null)
            {
                thisForm = new frmOrPayManageData();
            }
            else if (thisForm != new frmOrPayManageData())
            {
                thisForm = new frmOrPayManageData();
            }

            f = (frmOrPayManageData)thisForm;

            return f;
        }

        public void RefreshData(string s = "")
        {
            s = (s != "" && s != " " ) ? s : sql;

            new clsDB().Con().FillLvw(lvManageRecord, s);
            new clsDB().Con().FillLvw(lvOP, opQuery);
        }

        public void DbAction(string msg)
        {
            if (msg == "add")
            {
                addPayment();
            }
            else if (msg == "update")
            {

            }
            else if (msg == "delete")
            {

            }
            else if (msg == "view")
            {

            }
            else if (msg == "refresh")
            {
                RefreshData(" ");
            }
            else
                Close();
        }

        // #  --------------------   DBACTIONS ---------------------------
        private void addPayment()
        {
            if (lvManageRecord.CheckedItems.Count < 1)
            {
                frmOrPayDataEntry.show_asAdd(new MsgHandler(RefreshData));
            }
            else
            {
                // instantiate an object of student
                Student st = new Student(lvManageRecord.CheckedItems[0].SubItems[1].Text);

                // pass values to form

                frmOrPayDataEntry.checkedItems = Payor.getCheckedItems(lvManageRecord);
                frmOrPayDataEntry.studentData = st.studentData;


                frmOrPayDataEntry.show_asAdd(new MsgHandler(RefreshData));
            }
            

        }
        // # ---------------   END OF DB ACTIONS --------------------------


        // #EVENT LISTENER
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text;
            if(string.IsNullOrEmpty(searchTerm) || Helper.strIsEmpty(searchTerm))
                RefreshData("");
            else
                RefreshData( StudentAccount.searchAccount(searchTerm));
        }

        public void btnPartialPayment_Click(object sender, EventArgs e)
        {
            if ( lvManageRecord.CheckedItems.Count > 0)
            {
          
                    Student st = new Student(lvManageRecord.CheckedItems[0].SubItems[1].Text);
                    frmPartialPayment f = new frmPartialPayment();
                    f.ControlBox = false;
                    f.studentData = st.studentData;

                    f.ShowDialog();
                    RefreshData(" ");
    
            }
            else
            {
                MessageBox.Show("Please Select/Search a student first ","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        // from : http://stackoverflow.com/questions/6697306/c-sharp-capture-main-form-keyboard-events
       /*
        public bool PreFilterMessage(ref Message m)
        {
            //here you can specify  which key you need to filter

            if (m.Msg == 0x0100 && (Keys)m.WParam.ToInt32() == Keys.L &&  ModifierKeys == Keys.Control)
            {
                
                btnPartialPayment_Click(null, null);
                return true;
            }
            else if (m.Msg == 0x0100 && (Keys)m.WParam.ToInt32() == Keys.Q && ModifierKeys == Keys.Control)
            {
                MessageBox.Show("2");
                tbSearch.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        private void lvManageRecord_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvManageRecord.CheckedItems.Count > 0)
            {
                btnPartialPayment_Click(sender, null);
            }
        }

        private void frmOrPayManageData_FormClosed(object sender, FormClosedEventArgs e)
        {
            thisForm = null;
        }

        private void mtcViewPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (mtcViewPaid.Checked)
                new clsDB().Con().FillLvw(lvOP, "SELECT TOP 50 OPNo, OP.Amount, CAST( CASE WHEN OP.Payor IS NULL OR OP.Payor = '' THEN CONCAT(FName,' ',MName,' ',LName) ELSE OP.Payor END AS varchar(100))  as Payor, CAST (CASE WHEN  PAID = 0 THEN 'Not Paid' ELSE 'Paid' END as varchar(50) ) as Paid From tbl_PayOrder as OP  JOIN Student as S ON S.StudID = OP.StudID  ORDER BY OP.OPNo DESC");
            else
                new clsDB().Con().FillLvw(lvOP, opQuery);
        }

        private void mtcbBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (mtcViewPaid.Checked)
                new clsDB().Con().FillLvw(lvManageRecord, "SELECT  TOP 50 SA.SemNo, SA.StudID,S.StudNo, SUM(Amount - ISNULL(Payment, 0 )) as Amount ,FName, MName, LName, ProgCode  FROM Student_Account as SA JOIN Student as S ON SA.StudID = S.StudID JOIN StudentCourse as SC ON SC.StudID = SA.StudID WHERE SA.semNo = " + Semester.getCurrentSemester() + " AND ISNULL(SA.Balance,0)  >   0 AND Amount >= ISNULL(Payment, 0)   GROUP BY SA.StudID,S.StudNo, SA.SemNo,FName, MName,LName, ProgCode ");
            else
                new clsDB().Con().FillLvw(lvManageRecord, sql);
        }

        private void lvOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOP.SelectedItems.Count > 0)
            {
                mtOPDetails.Enabled = true;
                mtPaymentHistory.Enabled = true;
                mtReissue.Enabled = true;
            }
            else
            {
                mtOPDetails.Enabled = false;
                mtPaymentHistory.Enabled = false;
                mtReissue.Enabled = false;
            }
        }

        private void lvOP_Leave(object sender, EventArgs e)
        {
            mtOPDetails.Enabled = false;
            mtPaymentHistory.Enabled = false;
            mtReissue.Enabled = false;
        }


 
  
     

      

    


     

    


 
        // END OF EVENT LISTENER
     
    }
}
