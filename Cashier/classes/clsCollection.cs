using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;

namespace Cashier.classes
{
    class clsCollection
    {
        private int orderOfPaymentNo;
        private int officialReceiptNo;
        private string collectionDate;
        private float amount;
        private string payor;

        public clsCollection()
        {

        }

        public clsCollection(int OPNo, int ORNo, string cDate, float amount, string payor)
        {
            orderOfPaymentNo = OPNo;
            officialReceiptNo = ORNo;
            collectionDate = cDate;
            this.amount = amount;
            this.payor = payor;
        }

        public bool create()
        {
            bool isValid = false;
            string query = "INSERT INTO collections (ORNumber, OPNumber, Date_Paid, Payor, Amount) VALUES ("+ officialReceiptNo+","+ orderOfPaymentNo+",'"+ collectionDate + "', '" + payor + "', " + amount +")";

            if (new clsDB().Con().ExecuteSql(query))
            {
                isValid = true;
            }

            return isValid;
        }

        public bool addCollectionItem()
        {
            bool isValid = false;
            string query = "SELECT AcctCode, Particular, Amount, OPType From tbl_PayOrder_Details WHERE OPSeqNo = " + orderOfPaymentNo;
            string[][] obj = new string[new clsDB().Con().countRecord(query)][];

            new clsDB().Con().SelectData(query, obj);
            string insertQuery = "";
            for(int i = 0 ; i < obj.Count(); i++)
            {
                insertQuery = "INSERT INTO Collection_Details (ORNumber, AccoutCode, Particular, Amount, OPType) VALUES ( " +officialReceiptNo +"," + obj[i][0] + ",'" + obj[i][1] + "'," + obj[i][2] + "," + obj[i][3] + ")";
                if (new clsDB().Con().ExecuteSql(insertQuery))
                    isValid = true;
            }


            return isValid;
        }

    }
}
