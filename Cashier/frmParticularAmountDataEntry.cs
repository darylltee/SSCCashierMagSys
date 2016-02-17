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
    public partial class frmParticularAmountDataEntry : frmDataEntry
    {
        public float amount;
        private int assessmentID;
        public bool hasAmount = false;

        public frmParticularAmountDataEntry()
        {
            InitializeComponent();
        }
        public frmParticularAmountDataEntry(int assessmentID)
        {
            this.assessmentID = assessmentID;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string amount = tbAmount.Text;

            if (!Helper.strIsEmpty(amount, true) && Helper.IsNumeric(amount))
            {
                string query = "UPDATE Assessment SET Amount = " + float.Parse(amount) + " WHERE AssessmentID = " + assessmentID;

                if (new clsDB().Con().ExecuteSql(query))
                {
                    this.amount = float.Parse(amount);
                    hasAmount = true;
                   
                }
            }
            Close();
        }

 
    }
}
