﻿namespace Cashier
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.lollipopSmallCard1 = new LollipopSmallCard();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMsc = new System.Windows.Forms.Label();
            this.lbTuition = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lollipopLabel1 = new LollipopLabel();
            this.lbFName = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPaid = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtcHideOP = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.clmPayor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvManageRecord
            // 
            this.lvManageRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.clmPayor,
            this.clmPaid});
            this.lvManageRecord.FullRowSelect = true;
            this.lvManageRecord.Location = new System.Drawing.Point(1, 31);
            this.lvManageRecord.Size = new System.Drawing.Size(347, 346);
            this.lvManageRecord.SmallImageList = this.imageList1;
            this.lvManageRecord.SelectedIndexChanged += new System.EventHandler(this.lvManageRecord_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 16);
            this.btnSearch.Visible = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(5, 18);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(1, 370);
            this.groupBox1.Size = new System.Drawing.Size(347, 45);
            this.groupBox1.Text = "Filter";
            // 
            // lollipopSmallCard1
            // 
            this.lollipopSmallCard1.FontColor = "#33b679";
            this.lollipopSmallCard1.Image = null;
            this.lollipopSmallCard1.Info = "Details";
            this.lollipopSmallCard1.Location = new System.Drawing.Point(365, 38);
            this.lollipopSmallCard1.Name = "lollipopSmallCard1";
            this.lollipopSmallCard1.Size = new System.Drawing.Size(302, 52);
            this.lollipopSmallCard1.TabIndex = 4;
            this.lollipopSmallCard1.ThumbnailColor = "#33b679";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order Of Payment #";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 65;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(366, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 298);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No.";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Particulars";
            this.columnHeader4.Width = 154;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 82;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbMsc);
            this.groupBox2.Controls.Add(this.lbTuition);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(366, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 41);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // lbMsc
            // 
            this.lbMsc.Location = new System.Drawing.Point(122, 14);
            this.lbMsc.Name = "lbMsc";
            this.lbMsc.Size = new System.Drawing.Size(67, 23);
            this.lbMsc.TabIndex = 2;
            // 
            // lbTuition
            // 
            this.lbTuition.Location = new System.Drawing.Point(15, 14);
            this.lbTuition.Name = "lbTuition";
            this.lbTuition.Size = new System.Drawing.Size(87, 23);
            this.lbTuition.TabIndex = 1;
            // 
            // lbTotal
            // 
            this.lbTotal.Location = new System.Drawing.Point(224, 14);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(67, 23);
            this.lbTotal.TabIndex = 0;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.BackColor = System.Drawing.Color.SteelBlue;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel1.Location = new System.Drawing.Point(-2, 0);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lollipopLabel1.Size = new System.Drawing.Size(350, 31);
            this.lollipopLabel1.TabIndex = 9;
            this.lollipopLabel1.Text = "    Order Of Payment List";
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.BackColor = System.Drawing.Color.Transparent;
            this.lbFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFName.Location = new System.Drawing.Point(424, 46);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(63, 16);
            this.lbFName.TabIndex = 10;
            this.lbFName.Text = "[ Name]";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPay.FlatAppearance.BorderSize = 5;
            this.btnPay.Location = new System.Drawing.Point(371, 44);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(33, 32);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbDate.Location = new System.Drawing.Point(603, 67);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(50, 13);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "[ Date ]";
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbPaid.ForeColor = System.Drawing.Color.Firebrick;
            this.lbPaid.Location = new System.Drawing.Point(550, 18);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(70, 13);
            this.lbPaid.TabIndex = 15;
            this.lbPaid.Text = "PAID ( OR # ";
            this.lbPaid.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bill-48.png");
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(366, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(301, 42);
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "Payment Details";
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // mtcHideOP
            // 
            this.mtcHideOP.AutoSize = true;
            this.mtcHideOP.BackColor = System.Drawing.Color.SteelBlue;
            this.mtcHideOP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtcHideOP.Location = new System.Drawing.Point(228, 2);
            this.mtcHideOP.Name = "mtcHideOP";
            this.mtcHideOP.Size = new System.Drawing.Size(93, 15);
            this.mtcHideOP.TabIndex = 17;
            this.mtcHideOP.Text = "Hide Paid OP";
            this.mtcHideOP.UseCustomBackColor = true;
            this.mtcHideOP.UseCustomForeColor = true;
            this.mtcHideOP.UseSelectable = true;
            this.mtcHideOP.CheckedChanged += new System.EventHandler(this.mtcHideOP_CheckedChanged);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.metroCheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroCheckBox1.Location = new System.Drawing.Point(228, 16);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(120, 15);
            this.metroCheckBox1.TabIndex = 18;
            this.metroCheckBox1.Text = "Show Payor Name";
            this.metroCheckBox1.UseCustomBackColor = true;
            this.metroCheckBox1.UseCustomForeColor = true;
            this.metroCheckBox1.UseSelectable = true;
            // 
            // clmPayor
            // 
            this.clmPayor.Text = "Payor";
            this.clmPayor.Width = 119;
            // 
            // clmPaid
            // 
            this.clmPaid.Text = "Is Paid";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 438);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.mtcHideOP);
            this.Controls.Add(this.lbPaid);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lollipopSmallCard1);
            this.Controls.Add(this.metroTile1);
            this.Name = "frmPayment";
            this.Resizable = false;
            this.Text = "frmPayment";
            this.Controls.SetChildIndex(this.metroTile1, 0);
            this.Controls.SetChildIndex(this.lvManageRecord, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lollipopSmallCard1, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lollipopLabel1, 0);
            this.Controls.SetChildIndex(this.lbFName, 0);
            this.Controls.SetChildIndex(this.btnPay, 0);
            this.Controls.SetChildIndex(this.lbDate, 0);
            this.Controls.SetChildIndex(this.lbPaid, 0);
            this.Controls.SetChildIndex(this.mtcHideOP, 0);
            this.Controls.SetChildIndex(this.metroCheckBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopSmallCard lollipopSmallCard1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbMsc;
        private System.Windows.Forms.Label lbTuition;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPaid;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroCheckBox mtcHideOP;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.ColumnHeader clmPayor;
        private System.Windows.Forms.ColumnHeader clmPaid;
    }
}