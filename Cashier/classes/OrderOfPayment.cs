using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;
using System.Windows.Forms;

namespace Cashier.classes
{
    class OrderOfPayment
    {
        // Fillable 
       private float amountNumeric;
       private string amountWords;
       private int StudID;
       private int orderOfPaymentNo;
       private string orderOfPaymentDate;
       private string payorName;
       private string purpose;
       private string query;
       public int ORNumber;


       public Dictionary<string,string> orderOfPaymentDetails = new Dictionary<string,string>();
      
       // Simple Constructor
       public OrderOfPayment()
       {
           // initialize Details
           orderOfPaymentDetails["tuitionFee"] = "";
           orderOfPaymentDetails["mscFee"] = "";
       }

       public Dictionary<string, string> getOPDataWOOR(int orderOfPaymentNo)
       {
           Dictionary<string, string> data = new Dictionary<string, string>();
           string query = "SELECT DISTINCT OP.SeqNo,OP.OPNo, OP.DateIssued,CONCAT(S.FName,' ', S.MName,' ',S.LName,' ', OP.Payor) as Payor ,S.GAddress,OP.AmtInWords, OP.Amount, OP.OPNo, SC.ProgCode  FROM tbl_PayOrder as OP LEFT JOIN Student_Account as SA ON OP.StudID = SA.StudID LEFT JOIN StudentCourse as SC ON SA.StudID = SC.StudID LEFT JOIN student as S ON SA.StudID = S.StudID WHERE OP.OPNo = "+orderOfPaymentNo+" GROUP BY OP.DateIssued,Payor, OP.AmtInWords,OP.Amount, OP.OPNo, S.FName, S.MName, S.LName, OP.Payor, S.GAddress, OP.OPNo, OP.SeqNo,SC.ProgCode";

           if (!new clsDB().Con().SelectDataDictionary(query, data))
           {

           }
           return data;
       }
       public Dictionary<string, string> getOPData(int orderOfPaymentNo)
       {
           Dictionary<string, string> data = new Dictionary<string, string>();
           string query = "SELECT *,CONCAT(S.FName,' ', S.MName,' ',  S.LName,' ',OP.Payor) as Payor ,OP.Amount FROM tbl_PayOrder as OP JOIN Student as S ON S.StudID = OP.StudID LEFT JOIN Collections as Col on Col.OPNumber = OP.OPNo WHERE OP.OPNo = " + orderOfPaymentNo;

           if (!new clsDB().Con().SelectDataDictionary(query, data))
           {
               
           }
           return data;
       }

       public string[][] getOrderOfPaymentItem(int orderOfPaymentNo)
       {
           string query = "SELECT particular, AcctCode, Amount FROM tbl_PayOrder_Details WHERE OPSeqNo = " + orderOfPaymentNo;
           string[][] obj = new string[new clsDB().Con().countRecord(query)][];

           new clsDB().Con().SelectData(query, obj);

           return obj;
       }

       public OrderOfPayment(float amount, int orderOfPaymentNo, string orderOfPaymentDate, string purpose, string payor = null, int StudID = 0)
       {
           amountWords = NumberTextExtensionMethod.ToText("" + amount);
           amountNumeric = amount;
           this.StudID = StudID;
           this.orderOfPaymentNo = hasNoDuplicate(orderOfPaymentNo) ? 0 : orderOfPaymentNo ;
           this.orderOfPaymentDate = orderOfPaymentDate;
           this.purpose = purpose;
           this.payorName = payor;
       }

       public bool createOP()
       {
           if (orderOfPaymentNo > 0)
           {
               string finalStudID = (StudID == 0) ? "null" : Convert.ToString(StudID);
               query = "INSERT INTO tbl_PayOrder (Amount, SemNo,AmtInWords, StudID, OPNo, DateIssued,Purpose,Payor) VALUES( " + amountNumeric + ","+ Semester.getCurrentSemester()+", '" + amountWords + "'," + finalStudID + "," + orderOfPaymentNo + ",'" + orderOfPaymentDate + "' "+",'" + purpose+"', '"+ payorName+ "') ";
               if (!new clsDB().Con().ExecuteSql(query))
               {
                   MessageBox.Show("There is an error");
                   return false;
               }
           }
           else
           {
               MessageBox.Show(" Duplicate Order of Payment Number ");
               return false;
           }

           return true;
       }

       public bool addOPItem(int orderOfPaymentNo, Dictionary<string,float> amountPerParticular, int OPType = 0)
       {
           string query = "";
           bool isValid = false;

           for(int i = 0 ; i < amountPerParticular.Count; i++)
           {
               query =  "INSERT INTO tbl_PayOrder_Details (OPSeqNo, AcctCode, particular, amount, OPType) VALUES ("+orderOfPaymentNo+","+i+", '"+ amountPerParticular.Keys.ToList()[i] +"',"+ amountPerParticular[amountPerParticular.Keys.ToList()[i]] + "," + OPType +")";
               isValid = new clsDB().Con().ExecuteSql(query);
           }
            

           return isValid;
       }

       public bool createOPItem()
       {
           return true;
       }

       public bool updateOP(int ORNo, int OPNo)
       {
           bool isValid = true;

           string query = "UPDATE collections SET ORNumber = " + ORNo + " WHERE OPNumber = " + OPNo;

           if (new clsDB().Con().ExecuteSql(query))
           {
               isValid = true;
           }
           
           return isValid;
       }

       public void paidOP(int OPNo )
       {
           string query = "UPDATE tbl_PayOrder SET Paid = 1 WHERE OPNo = " + OPNo;

           new clsDB().Con().ExecuteSql(query);
       }

       private bool hasNoDuplicate(int orderOfPaymentNo)
       {
           string[] obj = new string[6];
           bool isValid = new clsDB().Con().SelectData("Select * FROM tbl_PayOrder WHERE OPNo = " + orderOfPaymentNo, obj);

           return isValid;
       }


       public bool hasORNumber(int OPNo)
       {
           bool hasRecord = false;
           string query = "SELECT TOP 1 ORNumber FROM Collections WHERE OPNumber = " + OPNo;

           if (new clsDB().Con().countRecord(query) > 0)
           {
               string[] obj = new string[1];
               new clsDB().Con().SelectData(query, obj);
               this.ORNumber = int.Parse(obj[0]);
               hasRecord = true;
           }

           return hasRecord;
       }



        // static functions
       public static string getLastOPNo()
       {
           string[] obj = new string[2];
           new clsDB().Con().SelectData("SELECT TOP 1 SeqNo, OPNo FROM tbl_PayOrder  ORDER BY OPNo DESC ",obj );
           int newOP = int.Parse((obj[1] == null) ? "100000" : obj[1]) + 1;
           obj[1] = Convert.ToString(newOP);

           return obj[1];
       }

       public static string getLastORNo()
       {
           string[] obj = new string[2];
           new clsDB().Con().SelectData("SELECT TOP 1 OPNumber, ORNumber FROM collections ORDER BY ORNumber DESC", obj);

           int lastORNo = int.Parse((obj[1] == null) ? "100000" : obj[1]) + 1;
    
           return Convert.ToString(lastORNo);
       }



      
    }
}
