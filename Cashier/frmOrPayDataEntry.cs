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
    public partial class frmOrPayDataEntry : frmDataEntry
    {
        public static string[] obj;
        public static string[] studentData;
        public static string[][] checkedItems;
        public static string paymentType;

        public static string dbAction;

        private static frmOrPayManageData.MsgHandler modRefreshData;
        private static int[] seqNo;
        private static int tuitionMarker;
       
        public frmOrPayDataEntry()
        {
            InitializeComponent();
            tPaymentOrNo.Text = OrderOfPayment.getLastOPNo();
            new clsDB().Con().FillCombobox(cmbParticular, "SELECT AssessmentName FROM assessment");
        }

        private void showHelp(Form f)
        {
            f.ShowDialog();
        }



        //  "show as" functions

        public static void show_asAdd(frmOrPayManageData.MsgHandler msg)
        {

            dbAction = "add";
            modRefreshData = msg;

            frmOrPayDataEntry f = new frmOrPayDataEntry();

            if (studentData != null && checkedItems != null)
            {
                // hide text boxes

                f.tbFirstname.Visible = false;
                f.tbLastname.Visible = false;
                f.tbMiddlename.Visible = false;

            

            }
      

            f.showHelp(f);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvDataEntryOP.Items.Count > 0)
            {
                float total = float.Parse(lbTotal.Text);

                if (total > 0 && (!string.IsNullOrEmpty(tbFirstname.Text) && !string.IsNullOrEmpty(tbLastname.Text)))
                {
                    OrderOfPayment OP = null;
                    StudentAccount SAccount = new StudentAccount();
                    Dictionary<string, float> amountPerParticular = SAccount.getAmountPerParticular(lvDataEntryOP,2);
                    string payor = tbFirstname.Text + " " + tbMiddlename.Text + " " + tbLastname.Text;

                    int orderOfPaymentType = 0 ;
                    try
                    {
                        orderOfPaymentType = int.Parse((mrbUndergrad.Checked) ? mrbUndergrad.Tag.ToString() : (mrbMasteral.Checked) ? mrbMasteral.Tag.ToString() : (mrbFiduciary.Checked) ? mrbFiduciary.Tag.ToString() : (mrbBtr.Checked) ? mrbBtr.Tag.ToString() : (mrbIGD.Checked) ? mrbIGD.Tag.ToString() : "0" );
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show(ex.Message);
                    }

                    // Check if it a Payor Type
                    if (lbStudID.Text == "[ Student ID ]")
                    {
                        if (Payor.isPayorStudent(tbFirstname.Text, tbMiddlename.Text, tbLastname.Text))
                            MessageBox.Show("Payor is a student : Please load the payor in the list");
                        else
                        {     
                            OP = new OrderOfPayment(float.Parse(tAmount.Text), int.Parse(tPaymentOrNo.Text), dtOrDate.Value.ToShortDateString(), "Tuition Fee/Misc", payor, 0);
                        }
                    }
                    else
                    {
                        OP = new OrderOfPayment(float.Parse(tAmount.Text), int.Parse(tPaymentOrNo.Text), dtOrDate.Value.ToShortDateString(), "Tuition Fee/Misc", null, int.Parse(lbStudID.Text));
                    }
                    
                    // final
                    if (OP.createOP())
                    {
                        OP.addOPItem(int.Parse(tPaymentOrNo.Text), amountPerParticular, orderOfPaymentType);
                        MessageBox.Show("Successful! \n \t Please Proceed to Payment");

                        Dictionary<string, string> OPData = OP.getOPDataWOOR(int.Parse(tPaymentOrNo.Text));
                        ePrinting print = new ePrinting(OPData);
                        print.ePrint("OP");


                        Close();

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input / Missing Field");
                }
            }
            else
            {
                MessageBox.Show("Please add an item");
            }
          /*
            isValid = cStudentAccount.validateAmout(paymentType, totalFee, paymentAmount, tuitionFee, mscFee);

            // ---------------- FINAL PROCEDURE -------------------
            if (isValid)
            {
                OrderOfPayment OP = new OrderOfPayment(paymentAmount, int.Parse(studentData[0]), int.Parse(tPaymentOrNo.Text), dtOrDate.Value.ToShortDateString());

                if (OP.createOP())
                {
                    OP.addOPItem(int.Parse(tPaymentOrNo.Text), amountPerParticular);
                    //StudentAccount.updatePayment(seqNo, tuitionSeqNo, paymentAmount, int.Parse(studentData[0]), mscFee, semNo);
                    
                    MessageBox.Show("Successful! \n \t Please Proceed to Payment");

                    frmOrderOfPaymentPrint OPPrint = new frmOrderOfPaymentPrint(0, int.Parse(tPaymentOrNo.Text));
                    OPPrint.ShowDialog();
                    Close();

                }
           
               
            }
           * 
           * */
           
        }








        private void frmOrPayDataEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Helper.closeOtherForm("frmPartialPayment");  
        }


        private void btnAddParticular_Click(object sender, EventArgs e)
        {
            
            frmParticulars f = new frmParticulars();
            f.ShowDialog();
            string[][] data = f.checkedItems;
            string[] col = new string[f.listView1.Columns.Count];
            for (int i = 0; i < f.listView1.Columns.Count; i++)
            {
                col[i] = f.listView1.Columns[i].Text;
            }
            try
            {
                if (new clsDB().Con().listViewTransferData(data, lvDataEntryOP, col))
                {
                    f.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            float[] account = Payor.computeAccount(lvDataEntryOP);

            lbTotal.Text = Convert.ToString(account[1]);
            tAmount.Text = Convert.ToString(account[1]);

        }

        private void btnAddParticular_Click_1(object sender, EventArgs e)
        {
            string particular = "";
             string query = "Select AssessmentID, AssessmentName, ISNULL(Amount,0) from assessment WHERE AssessmentName = '";
             if (cmbParticular.SelectedIndex > -1)
                 particular = cmbParticular.SelectedItem.ToString();
             else
                 particular = cmbParticular.Text;
           
            try
            {
                if (!string.IsNullOrEmpty(particular))
                {
                    int count = new clsDB().Con().countRecord(query + particular + "'");
                    string[] column = { "No", "Particulars", "Amount"};
                    string[][] data = new string[count][];
                    string[] obj = new string[3];
                    bool hasAmount = false;

                    // if has record in the database - get data for transfer
                    if (count > 0)
                    {
                        if (new clsDB().Con().SelectData(query + particular + "'", obj))
                        {
                            data[0] = obj;
                            // check if the amount is zero and ask for input
                            if (float.Parse(data[0][2]) == 0)
                            {
                                frmParticularAmountDataEntry f = new frmParticularAmountDataEntry(int.Parse(data[0][0]));
                                f.ShowDialog();
                                data[0][2] = Convert.ToString(f.amount);
                                hasAmount = f.hasAmount;
                            }
                            else
                                hasAmount = true;

                            if (hasAmount && new clsDB().Con().listViewTransferData(data, lvDataEntryOP, column))
                            {
                                float[] account = Payor.computeAccount(lvDataEntryOP);

                                lbTotal.Text = Convert.ToString(account[1]);
                                tAmount.Text = Convert.ToString(account[1]);
                            }
                        }

                    }
                    else
                    {
                        pNewParticular.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     


        private void btnDelete_Click(object sender, EventArgs e)
        {
            new clsDB().Con().listViewRemoveSelectedIndex(lvDataEntryOP);
           
            float[] account = Payor.computeAccount(lvDataEntryOP);

            lbTotal.Text = Convert.ToString(account[1]);
            tAmount.Text = Convert.ToString(account[1]);

            lvDataEntryOP.Items[lvDataEntryOP.Items.Count - 1].Focused = true;
            lvDataEntryOP.Items[lvDataEntryOP.Items.Count - 1].Selected = true;
        }

        private void btnPayor_Click(object sender, EventArgs e)
        {
            frmPayorDataEntry f = new frmPayorDataEntry();
            f.ShowDialog();

            if (f.wName.Count() > 0)
            {
                tbFirstname.Text = f.wName["firstname"];
                tbMiddlename.Text = f.wName["middlename"];
                tbLastname.Text = f.wName["lastname"];
                lbStudID.Text = Convert.ToString(f.ID);

                lbStudID.Visible = true;
                tbFirstname.ReadOnly = true;
                tbMiddlename.ReadOnly = true;
                tbLastname.ReadOnly = true;
                btnReset.Visible = true;
            }
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbFirstname.ReadOnly = false;
            tbMiddlename.ReadOnly = false;
            tbLastname.ReadOnly = false;
            lbStudID.Visible = false;

            tbFirstname.Text = "Firstname"; tbMiddlename.Text = "Middlename"; tbLastname.Text = "Lastname";

            btnReset.Visible = false;
        }


  

        

        private void btnNewParticularExit_Click(object sender, EventArgs e)
        {
            pNewParticular.Visible = false;
            tbNewParticularAmount.Text = "";
            tbNewParticularShortDesc.Text = "";
        }

        private void btnNewParticular_Click(object sender, EventArgs e)
        {
            if (Helper.strIsEmpty(tbNewParticularAmount.Text, true) == false && Helper.strIsEmpty(tbNewParticularShortDesc.Text) == false)
            {
                if (Helper.IsNumeric(tbNewParticularAmount.Text))
                {
                    string query = "INSERT INTO particulars (particular, amount,shortDescription) VALUES ('" + cmbParticular.Text + "',  " + tbNewParticularAmount.Text + ",'" + tbNewParticularShortDesc.Text + "')";

                    if (new clsDB().Con().ExecuteSql(query))
                    {
                        MessageBox.Show("Particular Added");
                        btnNewParticularExit_Click(null, null);
                        new clsDB().Con().FillCombobox(cmbParticular, "SELECT particular FROM particulars");
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnNewParticular(
        }








 

   
   

      
   

   






     
    }
}
