namespace Cashier
{
    partial class frmOrPayManageData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrPayManageData));
            this.clmSeqNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPartialPayment = new System.Windows.Forms.Button();
            this.clmAmountx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lollipopLabel1 = new LollipopLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lollipopLabel2 = new LollipopLabel();
            this.lvOP = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtOPDetails = new MetroFramework.Controls.MetroTile();
            this.mtReissue = new MetroFramework.Controls.MetroTile();
            this.mtPaymentHistory = new MetroFramework.Controls.MetroTile();
            this.mtcViewPaid = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtcbBalance = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvManageRecord
            // 
            this.lvManageRecord.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvManageRecord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvManageRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvManageRecord.CheckBoxes = true;
            this.lvManageRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSeqNo,
            this.clmStudID,
            this.clmStudNo,
            this.clmAmountx,
            this.clmFName,
            this.clmMName,
            this.clmLName,
            this.columnHeader1});
            this.lvManageRecord.FullRowSelect = true;
            this.lvManageRecord.Location = new System.Drawing.Point(0, 25);
            this.lvManageRecord.MultiSelect = false;
            this.lvManageRecord.Size = new System.Drawing.Size(466, 278);
            this.lvManageRecord.SmallImageList = this.imageList1;
            this.lvManageRecord.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvManageRecord_ItemChecked);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(302, 76);
            this.btnSearch.Size = new System.Drawing.Size(39, 29);
            this.btnSearch.Text = "";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(84, 40);
            this.tbSearch.Size = new System.Drawing.Size(207, 20);
            this.metroToolTip1.SetToolTip(this.tbSearch, "Search using \r\n - Lastname or Firstname or both \r\n - StudID \r\n - Student Number (" +
        " not yet working)");
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtcbBalance);
            this.groupBox1.Controls.Add(this.btnPartialPayment);
            this.groupBox1.Location = new System.Drawing.Point(0, 338);
            this.groupBox1.Size = new System.Drawing.Size(466, 75);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnPartialPayment, 0);
            this.groupBox1.Controls.SetChildIndex(this.mtcbBalance, 0);
            this.groupBox1.Controls.SetChildIndex(this.tbSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            // 
            // clmSeqNo
            // 
            this.clmSeqNo.Text = "No";
            this.clmSeqNo.Width = 38;
            // 
            // clmStudID
            // 
            this.clmStudID.Text = "StudID";
            this.clmStudID.Width = 0;
            // 
            // clmFName
            // 
            this.clmFName.DisplayIndex = 3;
            this.clmFName.Text = "First Name";
            this.clmFName.Width = 80;
            // 
            // clmMName
            // 
            this.clmMName.DisplayIndex = 4;
            this.clmMName.Text = "Middle Name";
            this.clmMName.Width = 80;
            // 
            // clmLName
            // 
            this.clmLName.DisplayIndex = 5;
            this.clmLName.Text = "Last Name";
            this.clmLName.Width = 78;
            // 
            // btnPartialPayment
            // 
            this.btnPartialPayment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPartialPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPartialPayment.Location = new System.Drawing.Point(311, 19);
            this.btnPartialPayment.Name = "btnPartialPayment";
            this.btnPartialPayment.Size = new System.Drawing.Size(134, 36);
            this.btnPartialPayment.TabIndex = 4;
            this.btnPartialPayment.Text = "Partial/Full Payment";
            this.btnPartialPayment.UseVisualStyleBackColor = false;
            this.btnPartialPayment.Click += new System.EventHandler(this.btnPartialPayment_Click);
            // 
            // clmAmountx
            // 
            this.clmAmountx.DisplayIndex = 6;
            this.clmAmountx.Text = "Amount";
            this.clmAmountx.Width = 71;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.BackColor = System.Drawing.Color.SteelBlue;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel1.Location = new System.Drawing.Point(0, -2);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lollipopLabel1.Size = new System.Drawing.Size(466, 31);
            this.lollipopLabel1.TabIndex = 4;
            this.lollipopLabel1.Text = "Students Balance List";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Gender Neutral User-48.png");
            this.imageList1.Images.SetKeyName(1, "Bill-48.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter :";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProgCode";
            this.columnHeader1.Width = 73;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.Honeydew;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.Location = new System.Drawing.Point(436, 0);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(30, 29);
            this.metroLink1.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.metroLink1, "Double Click to Select a student");
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutomaticDelay = 100;
            this.metroToolTip1.AutoPopDelay = 5000;
            this.metroToolTip1.InitialDelay = 50;
            this.metroToolTip1.ReshowDelay = 20;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Tag = "";
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel2.Location = new System.Drawing.Point(543, 4);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lollipopLabel2.Size = new System.Drawing.Size(477, 439);
            this.lollipopLabel2.TabIndex = 6;
            this.lollipopLabel2.Text = "Recent Order Of Payments";
            // 
            // lvOP
            // 
            this.lvOP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lvOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.lvOP.ForeColor = System.Drawing.SystemColors.Info;
            this.lvOP.FullRowSelect = true;
            this.lvOP.Location = new System.Drawing.Point(558, 31);
            this.lvOP.Name = "lvOP";
            this.lvOP.Size = new System.Drawing.Size(462, 272);
            this.lvOP.TabIndex = 7;
            this.lvOP.UseCompatibleStateImageBehavior = false;
            this.lvOP.View = System.Windows.Forms.View.Details;
            this.lvOP.SelectedIndexChanged += new System.EventHandler(this.lvOP_SelectedIndexChanged);
            this.lvOP.Leave += new System.EventHandler(this.lvOP_Leave);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "OPNo.";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Payor";
            this.columnHeader5.Width = 202;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paid";
            this.columnHeader4.Width = 65;
            // 
            // clmStudNo
            // 
            this.clmStudNo.Text = "StudNo";
            // 
            // mtOPDetails
            // 
            this.mtOPDetails.ActiveControl = null;
            this.mtOPDetails.Enabled = false;
            this.mtOPDetails.Location = new System.Drawing.Point(558, 307);
            this.mtOPDetails.Name = "mtOPDetails";
            this.mtOPDetails.Size = new System.Drawing.Size(141, 98);
            this.mtOPDetails.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtOPDetails.TabIndex = 8;
            this.mtOPDetails.Text = "OP Details";
            this.mtOPDetails.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtOPDetails.TileImage = ((System.Drawing.Image)(resources.GetObject("mtOPDetails.TileImage")));
            this.mtOPDetails.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOPDetails.UseSelectable = true;
            this.mtOPDetails.UseTileImage = true;
            // 
            // mtReissue
            // 
            this.mtReissue.ActiveControl = null;
            this.mtReissue.Enabled = false;
            this.mtReissue.Location = new System.Drawing.Point(871, 307);
            this.mtReissue.Name = "mtReissue";
            this.mtReissue.Size = new System.Drawing.Size(140, 98);
            this.mtReissue.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtReissue.TabIndex = 9;
            this.mtReissue.Text = "Re-issue OP";
            this.mtReissue.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtReissue.TileImage = ((System.Drawing.Image)(resources.GetObject("mtReissue.TileImage")));
            this.mtReissue.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReissue.UseSelectable = true;
            this.mtReissue.UseTileImage = true;
            // 
            // mtPaymentHistory
            // 
            this.mtPaymentHistory.ActiveControl = null;
            this.mtPaymentHistory.Enabled = false;
            this.mtPaymentHistory.Location = new System.Drawing.Point(715, 307);
            this.mtPaymentHistory.Name = "mtPaymentHistory";
            this.mtPaymentHistory.Size = new System.Drawing.Size(140, 98);
            this.mtPaymentHistory.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtPaymentHistory.TabIndex = 10;
            this.mtPaymentHistory.Text = "Payment History";
            this.mtPaymentHistory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPaymentHistory.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPaymentHistory.TileImage")));
            this.mtPaymentHistory.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPaymentHistory.UseSelectable = true;
            this.mtPaymentHistory.UseTileImage = true;
            // 
            // mtcViewPaid
            // 
            this.mtcViewPaid.AutoSize = true;
            this.mtcViewPaid.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mtcViewPaid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mtcViewPaid.Location = new System.Drawing.Point(910, 11);
            this.mtcViewPaid.Name = "mtcViewPaid";
            this.mtcViewPaid.Size = new System.Drawing.Size(93, 15);
            this.mtcViewPaid.TabIndex = 11;
            this.mtcViewPaid.Text = "View Paid OP";
            this.mtcViewPaid.UseCustomBackColor = true;
            this.mtcViewPaid.UseCustomForeColor = true;
            this.mtcViewPaid.UseSelectable = true;
            this.mtcViewPaid.CheckedChanged += new System.EventHandler(this.mtcViewPaid_CheckedChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1029, 644);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mtcbBalance
            // 
            this.mtcbBalance.AutoSize = true;
            this.mtcbBalance.BackColor = System.Drawing.Color.MintCream;
            this.mtcbBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtcbBalance.Location = new System.Drawing.Point(26, 19);
            this.mtcbBalance.Name = "mtcbBalance";
            this.mtcbBalance.Size = new System.Drawing.Size(84, 15);
            this.mtcbBalance.TabIndex = 13;
            this.mtcbBalance.Text = "Balance > 0";
            this.mtcbBalance.UseCustomBackColor = true;
            this.mtcbBalance.UseCustomForeColor = true;
            this.mtcbBalance.UseSelectable = true;
            this.mtcbBalance.CheckedChanged += new System.EventHandler(this.mtcbBalance_CheckedChanged);
            // 
            // frmOrPayManageData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackMaxSize = 1300;
            this.ClientSize = new System.Drawing.Size(1026, 630);
            this.Controls.Add(this.mtcViewPaid);
            this.Controls.Add(this.mtPaymentHistory);
            this.Controls.Add(this.mtReissue);
            this.Controls.Add(this.mtOPDetails);
            this.Controls.Add(this.lvOP);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrPayManageData";
            this.Resizable = false;
            this.Text = "frmOrPayManageData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrPayManageData_FormClosed);
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.Controls.SetChildIndex(this.lollipopLabel1, 0);
            this.Controls.SetChildIndex(this.metroLink1, 0);
            this.Controls.SetChildIndex(this.lollipopLabel2, 0);
            this.Controls.SetChildIndex(this.lvOP, 0);
            this.Controls.SetChildIndex(this.mtOPDetails, 0);
            this.Controls.SetChildIndex(this.mtReissue, 0);
            this.Controls.SetChildIndex(this.mtPaymentHistory, 0);
            this.Controls.SetChildIndex(this.mtcViewPaid, 0);
            this.Controls.SetChildIndex(this.lvManageRecord, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmSeqNo;
        private System.Windows.Forms.ColumnHeader clmStudID;
        private System.Windows.Forms.ColumnHeader clmFName;
        private System.Windows.Forms.ColumnHeader clmMName;
        private System.Windows.Forms.ColumnHeader clmLName;
        private System.Windows.Forms.Button btnPartialPayment;
        private System.Windows.Forms.ColumnHeader clmAmountx;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private LollipopLabel lollipopLabel2;
        private System.Windows.Forms.ListView lvOP;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader clmStudNo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTile mtOPDetails;
        private MetroFramework.Controls.MetroTile mtReissue;
        private MetroFramework.Controls.MetroTile mtPaymentHistory;
        private MetroFramework.Controls.MetroCheckBox mtcViewPaid;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox mtcbBalance;
    }
}