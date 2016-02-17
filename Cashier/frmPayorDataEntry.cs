﻿using System;
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
    public partial class frmPayorDataEntry : frmDataEntry 
    {
        public Dictionary<string,string> wName = new Dictionary<string, string>();
        public int ID;

        public string[] queries = {
                                       "SELECT TOP 50 StudID, FName, MName, LName FROM student ",
                                       "SELECT TOP 50 SemNo, Payor FROM (Select DISTINCT SemNo, Payor from tbl_PayOrder WHERE Payor IS NOT NULL OR Payor != '' ) tbl_PayOrder WHERE Payor IS NOT NULL OR Payor != '' "
                                  };

        public frmPayorDataEntry()
        {
            InitializeComponent();
        }

        public void RefreshData(string s = "")
        {
            s = (s != "" && s != " ") ? s : queries[0];

            new clsDB().Con().FillLvw(lvStudents, s);

        }

        private void frmPayorDataEntry_Load(object sender, EventArgs e)
        {
            new clsDB().Con().FillLvw(lvStudents, queries[0]);
            new clsDB().Con().FillLvw(lvOtherPayor, queries[1]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count > 0)
            {
                string firstname = lvStudents.SelectedItems[0].SubItems[1].Text;
                string middlename = lvStudents.SelectedItems[0].SubItems[2].Text;
                string lastname = lvStudents.SelectedItems[0].SubItems[3].Text;

                wName["firstname"] = firstname;
                wName["middlename"] = middlename;
                wName["lastname"] = lastname;
                ID = int.Parse(lvStudents.SelectedItems[0].SubItems[0].Text);
                Close();
            }

            if (lvOtherPayor.SelectedItems.Count > 0)
            {

            }
                
        }

    }
}
