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
    public partial class frmPaymentDataEntry : frmDataEntry
    {
        private bool isValid = false;
        public float total;
        public int orderOfPaymentNo;
        public int listLength;


        public frmPaymentDataEntry()
        {
            InitializeComponent();
            tbORNo.Text = OrderOfPayment.getLastORNo();
            
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (Helper.IsNumeric(tbAmount.Text))
            {
                tbAmount.BackColor = Color.White;

                // Compute Change After amount > total
                if (float.Parse(tbAmount.Text) >= total)
                {
                    float temp = float.Parse(tbAmount.Text) - total;
                    lbChange.Text = Convert.ToString(temp);
                }

                isValid = true;
            }
            else
            {
                tbAmount.BackColor = Color.Maroon;
                isValid = false;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasPayment = false;
            if (float.Parse(tbAmount.Text) < float.Parse(lblAmountToPay.Text))
            {
                MessageBox.Show(" Invalid Amount");
            }
            else
            {
               
                string query = "SELECT SA.SeqNo, SA.StudID, SA.SemNo, SA.Particular, SA.Amount, ISNULL(SA.Payment,0), ISNULL(SA.Balance,0),OP.Amount FROM Student_Account as SA JOIN tbl_PayOrder as OP ON SA.StudID = OP.StudID WHERE OP.OPNo = ";
                int recordCount = new clsDB().Con().countRecord(query + orderOfPaymentNo);
                string[][] data = new string[recordCount][];

                // if it is for Student Account 
                if (recordCount > 0)
                {
                    new clsDB().Con().SelectData(query + orderOfPaymentNo, data);


                    StudentAccount sa = new StudentAccount();
                    Dictionary<string, string> studentAccountData = sa.getData(data);

                    int tuitionSeqNo = int.Parse(studentAccountData["tuitionSeqNo"]);
                    float mFee = float.Parse(studentAccountData["mFee"]);
                    int StudID = int.Parse(studentAccountData["StudID"]);
                    int semNo = int.Parse(studentAccountData["SemNo"]);



                    if (StudentAccount.updatePayment(sa.seqNo, tuitionSeqNo, float.Parse(studentAccountData["amountNumeric"]), StudID, mFee, semNo))
                    {
                        hasPayment = true;
                    }
                    else
                    {
                        MessageBox.Show("There was an error!");
                    }

                }
                // if for Misc Fees and other payments
                else
                {
                    hasPayment = true;
                }
               
            }
           
            // Final Procedure
            if (hasPayment)
            {
               
                OrderOfPayment OP = new OrderOfPayment();
                Dictionary<string, string> OPData = OP.getOPData(orderOfPaymentNo);
                clsCollection col = new clsCollection(orderOfPaymentNo, int.Parse(OrderOfPayment.getLastORNo()), dtORDate.Value.ToShortDateString(),float.Parse(OPData["Amount"]),OPData["Payor"]);

                if (OP.updateOP(int.Parse(tbORNo.Text), orderOfPaymentNo))
                    if (col.create())
                    {
                        OP.paidOP(orderOfPaymentNo);
                        col.addCollectionItem();

                        string[][] particularsAmount = OP.getOrderOfPaymentItem(orderOfPaymentNo);

                        OPData["collectionDate"] = dtORDate.Value.ToShortDateString();
                        int currOrNumber = int.Parse(OrderOfPayment.getLastORNo()) - 1;
                        OPData["ORNumber"] = ""+currOrNumber;
                        
                        ePrinting print = new ePrinting(OPData, particularsAmount);
                        print.ePrint("OR");
                        MessageBox.Show(" Account Updated!", " Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }
            }
        }

        private void tbORNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPaymentDataEntry_Load(object sender, EventArgs e)
        {
            lblAmountToPay.Text = total.ToString();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnSave_Click(null, null);
        }

  



   
    }
}
