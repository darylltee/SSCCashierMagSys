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
    public partial class frmPartialPayment : frmDataEntry
    {
        public string[] studentData;
        bool isFullPayment = false;
        StudentAccount SAccount = new StudentAccount();

        public frmPartialPayment()
        {
            InitializeComponent();
  
        }

        private void frmPartialPayment_Load(object sender, EventArgs e)
        {
            tPaymentOrNo.Text = OrderOfPayment.getLastOPNo();
            lbStudentName.Text = studentData[2] + ", " + studentData[3] + " " + studentData[4];
            lbStudNo.Text = "[" + studentData[1] + "]";
            new clsDB().Con().FillCombobox(cmbSem, "SELECT SemYr From SemesterYr");
            cmbSem.SelectedItem = Semester.getCurrentSemesterString();
            tbSemNo.Text = ""+Semester.getCurrentSemester(cmbSem.SelectedItem.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           string semNo = tbSemNo.Text;
           isFullPayment = rbtnFull.Checked;

           if (int.Parse(semNo) == 0)
               MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

           semNo = (!String.IsNullOrEmpty(tbSemNo.Text.Trim())) ? semNo : ""+0;
                new clsDB().Con().FillLvw(listView1, StudentAccount.searchBySemester(semNo, studentData[0]));   
            
            // for Payment summary
            float[] accountData = null;
            accountData =  Payor.computeAccount(listView1);

            float tuitionFee = accountData[0];
            float mscFee = accountData[1];


            // Compute Tuition Fee Based on payment type
            tuitionFee = (isFullPayment) ? tuitionFee : tuitionFee / 2;

            lbTuitionFee.Text = ""+ tuitionFee;
            lbMscFee.Text = "" + mscFee;

            // Total
            float total = tuitionFee + mscFee;
            lbTotal.Text = "" + total;




            new clsDB().Con().checkAllListView(listView1);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // instantiate student object
            try
            {
                if (listView1.CheckedItems.Count > 0 && !Helper.strIsEmpty(tAmount.Text, true))
                {
                    Student st = new Student(listView1.CheckedItems[0].SubItems[1].Text);

                    string course = st.course();

                    // temporary conditioning to check if a student is masteral or undergrad
                    int OPType = (course.StartsWith("B")) ? 2 : 3;

                    Dictionary<string,float> amountPerParticular = SAccount.getAmountPerParticular(listView1,3);

                    if (amountPerParticular["Tuition Fee"] > 0 && amountPerParticular["Tuition Fee"] > float.Parse(tAmount.Text))
                    {
                        amountPerParticular["Tuition Fee"] = float.Parse(tAmount.Text) - float.Parse(lbMscFee.Text);

                    }
                  

                    // validation
                    string paymentType = (isFullPayment) ? "full" : "partial";
                    bool isValid = StudentAccount.validateAmout(paymentType, float.Parse(lbTotal.Text), float.Parse(tAmount.Text), float.Parse(lbTuitionFee.Text), float.Parse(lbMscFee.Text));

                    if (isValid)
                    {
                        // ---------------- FINAL PROCEDURE -------------------
                        if (isValid)
                        {
                            OrderOfPayment OP = new OrderOfPayment(float.Parse(tAmount.Text), int.Parse(tPaymentOrNo.Text), dtOrDate.Value.ToShortDateString(), "Tuition Fee/Misc", null,int.Parse(studentData[0]));

                            if (OP.createOP())
                            {
                                OP.addOPItem(int.Parse(tPaymentOrNo.Text), amountPerParticular,OPType);
                                MessageBox.Show("Successful! \n \t Please Proceed to Payment");

                                 Dictionary<string, string> OPData = OP.getOPDataWOOR(int.Parse(tPaymentOrNo.Text));
                                 ePrinting print = new ePrinting(OPData);
                                 print.ePrint("OP");

                                
                                 Close();

                            }


                        }
           
                    }
                }
                else
                {
                    MessageBox.Show("Please select ");
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show("There are some fields missing", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void tbSemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave_Click(sender,e);
            }
        }

        private void rbtnFull_CheckedChanged_2(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            tbSemNo.Text = "" + Semester.getCurrentSemester(cmbSem.SelectedItem.ToString());
        }

        private void tAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave_Click(null, null);
            }
        }
   
    }
}
