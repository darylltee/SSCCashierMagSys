using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace Cashier.classes
{
    class ePrinting
    {
        public Dictionary<string, string> printData = new Dictionary<string, string>();
        public string[][] particularsAmount; 

        public ePrinting(Dictionary<string, string> data = null, string[][] pAmount = null)
        {
            printData = data;
            particularsAmount = pAmount;
        }
        public void ePrint(string printPage = "OR")
        {
            PrintDialog printDioalog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDioalog.Document = printDocument;

            switch (printPage)
            {
                case "OR":
                {
                    printDocument.PrintPage += new PrintPageEventHandler(ePrint_officialReceipt);
                    break;
                }
                case "OP":
                {
                    printDocument.PrintPage += new PrintPageEventHandler(ePrint_orderOfPayment);
                    break;
                }
               
            }
            DialogResult result = printDioalog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        void ePrint_orderOfPayment(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            //string strDestination;
            string Remarks;
            int startX = 10;
            int startY = 100;
            int offset = 40;

            int CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["DateIssued"], new Font("Courier New", 10)).Width) ;

            // Date Line
            graphic.DrawString(printData["DateIssued"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage + offset * 2, startY + (offset - 10));
            offset += (int)fontHeight + 90;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Address", new Font("Courier New", 10)).Width) / 4;

            // Address Line
            graphic.DrawString("Address", new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage - 20, (startY + (offset / 2)) + 10);
            offset += (int)fontHeight - 60;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["Payor"], new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

            // Payor Line
            graphic.DrawString(printData["Payor"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage - 20, (startY + (offset / 2)) + 8);
            offset += (int)fontHeight - 10;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["AmtInWords"], new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

            // Amount Line
            graphic.DrawString(printData["AmtInWords"].PadRight(printData["AmtInWords"].Length) + printData["Amount"].PadLeft(printData["AmtInWords"].Length / 4), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset - 2);
            offset = offset + (int)fontHeight + 5;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

            // Course Line
            graphic.DrawString(printData["ProgCode"].PadLeft(40) , new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset  - 2);
            offset = offset + (int)fontHeight + 110;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;


            // Last Line
            graphic.DrawString(printData["OPNo"], new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset - 10);
            offset = offset + (int)fontHeight ;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;



        }

        void ePrint_officialReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            //string strDestination;
            string Remarks;
            int startX = 10;
            int startY = 175;
            int offset = 40;

            int CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["ORNumber"], new Font("Courier New", 10)).Width ) / 4;

            // First Line
            graphic.DrawString(printData["ORNumber"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage + offset * 2, startY + (offset - 10));
            offset +=   (int)fontHeight +  70;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["collectionDate"], new Font("Courier New", 10)).Width) / 4;

            // Second Line
            graphic.DrawString(printData["collectionDate"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage * 2, (startY + (offset / 2)) - 10);
            offset += (int)fontHeight - 45;
            
            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Sorsogon State College", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;
          
            // Third Line
            graphic.DrawString("Sorsogon State College", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset - 10 );
            offset = offset + (int)fontHeight + 5;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

            // Payor
            string studentName = printData["LName"] + ", " + printData["FName"] + " " + printData["MName"] ;
            string payor = String.IsNullOrEmpty(printData["Payor"]) ? studentName : printData["Payor"];

            // Fourth Line
            graphic.DrawString(payor, new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset);
            offset = offset + (int)fontHeight + 5;

            // add more offset for particular items 
            offset += (int)fontHeight + 25;

            int tempDiff = 0;
            int particularLength = 0;
            for (int i = 0; i < particularsAmount.Length; i++)
            {
                if (particularLength > 0)
                    tempDiff = particularLength;

                // measure nature of collection name
                particularLength = Convert.ToInt16(e.Graphics.MeasureString(particularsAmount[i][0], new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

                if (tempDiff > 0 && tempDiff != particularLength && i != particularsAmount.Length -1)
                    tempDiff = tempDiff - particularLength;

                int tempFinal = particularLength + tempDiff;

                graphic.DrawString(particularsAmount[i][0].PadRight(28) + particularsAmount[i][1].PadRight(10) + particularsAmount[i][2].PadRight(tempFinal),
                   new Font("Courier New", 8), new SolidBrush(Color.Black), startX + 10, startY + offset );
               
                offset = offset + (int)fontHeight + 5;
            }

            // For Total
            int totalPosY = 550;
            offset += 60;
            graphic.DrawString(printData["Amount"], new Font("Courier New", 8), new SolidBrush(Color.Black), CenterPage * 3 - 40 , totalPosY);
           
            totalPosY = totalPosY + (int)fontHeight + 10;

            // For Amount in Words
            graphic.DrawString(printData["AmtInWords"], new Font("Courier New", 8), new SolidBrush(Color.Black), CenterPage / 4, totalPosY);
       


        }



    }
}
