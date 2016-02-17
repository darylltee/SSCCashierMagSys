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
    public partial class frmParticulars : frmDataEntry
    {
        public string[][] checkedItems;
        public string query = "SELECT * FROM particulars";
        public frmParticulars()
        {
            InitializeComponent();
        }



        private void frmParticulars_Load(object sender, EventArgs e)
        {

            new clsDB().Con().FillLvw(listView1, query);
        }

        public void RefreshData(string s = "")
        {
            s = (s != "" && s != " ") ? s : query;

            new clsDB().Con().FillLvw(listView1, s);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                checkedItems = Payor.getCheckedItems(listView1);
               
                
                Close();
            }
            else
                MessageBox.Show("Please Select a particular");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text;

            string query = "SELECT * FROM particulars WHERE particular LIKE '%"+searchTerm+"%'";

            RefreshData(query);

        }

    }
}
