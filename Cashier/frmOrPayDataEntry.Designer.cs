namespace Cashier
{
    partial class frmOrPayDataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrPayDataEntry));
            this.dtOrDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tPaymentOrNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pNewParticular = new System.Windows.Forms.Panel();
            this.btnNewParticularExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewParticular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNewParticularShortDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNewParticularAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddParticular = new System.Windows.Forms.Button();
            this.cmbParticular = new System.Windows.Forms.ComboBox();
            this.lbStudID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.btnPayor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbMiddlename = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.btnSelectParticular = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lvDataEntryOP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSeqNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSemNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmParticulars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mrbBtr = new MetroFramework.Controls.MetroRadioButton();
            this.mrbIGD = new MetroFramework.Controls.MetroRadioButton();
            this.mrbFiduciary = new MetroFramework.Controls.MetroRadioButton();
            this.mrbMasteral = new MetroFramework.Controls.MetroRadioButton();
            this.mrbUndergrad = new MetroFramework.Controls.MetroRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pNewParticular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(529, 12);
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "      Submit && Print";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(650, 12);
            this.btnCancel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(695, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Of Payment";
            // 
            // dtOrDate
            // 
            this.dtOrDate.Location = new System.Drawing.Point(97, 83);
            this.dtOrDate.Name = "dtOrDate";
            this.dtOrDate.Size = new System.Drawing.Size(200, 22);
            this.dtOrDate.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payment Order # :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Payor  :";
            // 
            // tPaymentOrNo
            // 
            this.tPaymentOrNo.Location = new System.Drawing.Point(474, 83);
            this.tPaymentOrNo.Name = "tPaymentOrNo";
            this.tPaymentOrNo.Size = new System.Drawing.Size(200, 22);
            this.tPaymentOrNo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pNewParticular);
            this.groupBox1.Controls.Add(this.btnAddParticular);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbParticular);
            this.groupBox1.Controls.Add(this.lbStudID);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnPayor);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.tbMiddlename);
            this.groupBox1.Controls.Add(this.tbFirstname);
            this.groupBox1.Controls.Add(this.tbLastname);
            this.groupBox1.Controls.Add(this.btnSelectParticular);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lvDataEntryOP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(711, 359);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(257, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "( Middlename )";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(181, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "( Firstname )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(100, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "( Lastname )";
            // 
            // pNewParticular
            // 
            this.pNewParticular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNewParticular.Controls.Add(this.btnNewParticularExit);
            this.pNewParticular.Controls.Add(this.button1);
            this.pNewParticular.Controls.Add(this.btnNewParticular);
            this.pNewParticular.Controls.Add(this.label9);
            this.pNewParticular.Controls.Add(this.tbNewParticularShortDesc);
            this.pNewParticular.Controls.Add(this.label8);
            this.pNewParticular.Controls.Add(this.tbNewParticularAmount);
            this.pNewParticular.Controls.Add(this.label7);
            this.pNewParticular.Location = new System.Drawing.Point(450, 37);
            this.pNewParticular.Name = "pNewParticular";
            this.pNewParticular.Size = new System.Drawing.Size(200, 123);
            this.pNewParticular.TabIndex = 29;
            this.pNewParticular.Visible = false;
            // 
            // btnNewParticularExit
            // 
            this.btnNewParticularExit.Location = new System.Drawing.Point(141, 95);
            this.btnNewParticularExit.Name = "btnNewParticularExit";
            this.btnNewParticularExit.Size = new System.Drawing.Size(56, 23);
            this.btnNewParticularExit.TabIndex = 7;
            this.btnNewParticularExit.Text = "Exit";
            this.btnNewParticularExit.UseVisualStyleBackColor = true;
            this.btnNewParticularExit.Click += new System.EventHandler(this.btnNewParticularExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save && Use";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewParticular
            // 
            this.btnNewParticular.Location = new System.Drawing.Point(3, 95);
            this.btnNewParticular.Name = "btnNewParticular";
            this.btnNewParticular.Size = new System.Drawing.Size(56, 23);
            this.btnNewParticular.TabIndex = 5;
            this.btnNewParticular.Text = "Save";
            this.btnNewParticular.UseVisualStyleBackColor = true;
            this.btnNewParticular.Click += new System.EventHandler(this.btnNewParticular_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 31);
            this.label9.TabIndex = 4;
            this.label9.Text = "Short Description";
            // 
            // tbNewParticularShortDesc
            // 
            this.tbNewParticularShortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tbNewParticularShortDesc.Location = new System.Drawing.Point(72, 52);
            this.tbNewParticularShortDesc.Name = "tbNewParticularShortDesc";
            this.tbNewParticularShortDesc.Size = new System.Drawing.Size(123, 31);
            this.tbNewParticularShortDesc.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Amount";
            // 
            // tbNewParticularAmount
            // 
            this.tbNewParticularAmount.Location = new System.Drawing.Point(72, 23);
            this.tbNewParticularAmount.Name = "tbNewParticularAmount";
            this.tbNewParticularAmount.Size = new System.Drawing.Size(123, 22);
            this.tbNewParticularAmount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Particular Description";
            // 
            // btnAddParticular
            // 
            this.btnAddParticular.Image = ((System.Drawing.Image)(resources.GetObject("btnAddParticular.Image")));
            this.btnAddParticular.Location = new System.Drawing.Point(604, 11);
            this.btnAddParticular.Name = "btnAddParticular";
            this.btnAddParticular.Size = new System.Drawing.Size(32, 31);
            this.btnAddParticular.TabIndex = 28;
            this.btnAddParticular.UseVisualStyleBackColor = true;
            this.btnAddParticular.Click += new System.EventHandler(this.btnAddParticular_Click_1);
            // 
            // cmbParticular
            // 
            this.cmbParticular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParticular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticular.FormattingEnabled = true;
            this.cmbParticular.Location = new System.Drawing.Point(450, 14);
            this.cmbParticular.Name = "cmbParticular";
            this.cmbParticular.Size = new System.Drawing.Size(148, 24);
            this.cmbParticular.TabIndex = 27;
            // 
            // lbStudID
            // 
            this.lbStudID.AutoSize = true;
            this.lbStudID.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbStudID.Location = new System.Drawing.Point(360, 22);
            this.lbStudID.Name = "lbStudID";
            this.lbStudID.Size = new System.Drawing.Size(74, 13);
            this.lbStudID.TabIndex = 26;
            this.lbStudID.Text = "[ Student ID ]";
            this.lbStudID.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(337, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(17, 19);
            this.btnReset.TabIndex = 25;
            this.btnReset.TabStop = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnPayor
            // 
            this.btnPayor.Image = ((System.Drawing.Image)(resources.GetObject("btnPayor.Image")));
            this.btnPayor.Location = new System.Drawing.Point(16, 17);
            this.btnPayor.Name = "btnPayor";
            this.btnPayor.Size = new System.Drawing.Size(26, 23);
            this.btnPayor.TabIndex = 24;
            this.btnPayor.Text = "...";
            this.btnPayor.UseVisualStyleBackColor = true;
            this.btnPayor.Click += new System.EventHandler(this.btnPayor_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(639, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 31);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbMiddlename
            // 
            this.tbMiddlename.Location = new System.Drawing.Point(256, 19);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.Size = new System.Drawing.Size(74, 22);
            this.tbMiddlename.TabIndex = 22;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(176, 19);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(74, 22);
            this.tbFirstname.TabIndex = 21;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(97, 19);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(73, 22);
            this.tbLastname.TabIndex = 20;
            // 
            // btnSelectParticular
            // 
            this.btnSelectParticular.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectParticular.Image")));
            this.btnSelectParticular.Location = new System.Drawing.Point(673, 11);
            this.btnSelectParticular.Name = "btnSelectParticular";
            this.btnSelectParticular.Size = new System.Drawing.Size(32, 31);
            this.btnSelectParticular.TabIndex = 19;
            this.btnSelectParticular.UseVisualStyleBackColor = true;
            this.btnSelectParticular.Click += new System.EventHandler(this.btnAddParticular_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTotal.Location = new System.Drawing.Point(505, 236);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 24);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "0.00";
            // 
            // lvDataEntryOP
            // 
            this.lvDataEntryOP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clmSeqNo,
            this.clmSemNo,
            this.clmStudID,
            this.clmParticulars,
            this.clmAmount,
            this.clmPayment,
            this.clmBalance});
            this.lvDataEntryOP.FullRowSelect = true;
            this.lvDataEntryOP.GridLines = true;
            this.lvDataEntryOP.Location = new System.Drawing.Point(17, 47);
            this.lvDataEntryOP.Name = "lvDataEntryOP";
            this.lvDataEntryOP.Size = new System.Drawing.Size(677, 186);
            this.lvDataEntryOP.TabIndex = 12;
            this.lvDataEntryOP.UseCompatibleStateImageBehavior = false;
            this.lvDataEntryOP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 7;
            this.columnHeader1.Width = 0;
            // 
            // clmSeqNo
            // 
            this.clmSeqNo.DisplayIndex = 0;
            this.clmSeqNo.Text = "No";
            // 
            // clmSemNo
            // 
            this.clmSemNo.DisplayIndex = 1;
            this.clmSemNo.Text = "SemNo";
            this.clmSemNo.Width = 0;
            // 
            // clmStudID
            // 
            this.clmStudID.DisplayIndex = 2;
            this.clmStudID.Text = "StudID";
            this.clmStudID.Width = 0;
            // 
            // clmParticulars
            // 
            this.clmParticulars.DisplayIndex = 3;
            this.clmParticulars.Text = "Particulars";
            this.clmParticulars.Width = 196;
            // 
            // clmAmount
            // 
            this.clmAmount.DisplayIndex = 4;
            this.clmAmount.Text = "Amount";
            this.clmAmount.Width = 160;
            // 
            // clmPayment
            // 
            this.clmPayment.DisplayIndex = 5;
            this.clmPayment.Text = "Payment";
            this.clmPayment.Width = 140;
            // 
            // clmBalance
            // 
            this.clmBalance.DisplayIndex = 6;
            this.clmBalance.Text = "Balance";
            this.clmBalance.Width = 113;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(440, 233);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(254, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tAmount);
            this.groupBox2.Location = new System.Drawing.Point(18, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mrbBtr);
            this.groupBox3.Controls.Add(this.mrbIGD);
            this.groupBox3.Controls.Add(this.mrbFiduciary);
            this.groupBox3.Controls.Add(this.mrbMasteral);
            this.groupBox3.Controls.Add(this.mrbUndergrad);
            this.groupBox3.Location = new System.Drawing.Point(427, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 69);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Type";
            // 
            // mrbBtr
            // 
            this.mrbBtr.AutoSize = true;
            this.mrbBtr.Location = new System.Drawing.Point(112, 42);
            this.mrbBtr.Name = "mrbBtr";
            this.mrbBtr.Size = new System.Drawing.Size(44, 15);
            this.mrbBtr.TabIndex = 4;
            this.mrbBtr.Tag = "1";
            this.mrbBtr.Text = "BTR";
            this.mrbBtr.UseSelectable = true;
            // 
            // mrbIGD
            // 
            this.mrbIGD.AutoSize = true;
            this.mrbIGD.Location = new System.Drawing.Point(168, 42);
            this.mrbIGD.Name = "mrbIGD";
            this.mrbIGD.Size = new System.Drawing.Size(42, 15);
            this.mrbIGD.TabIndex = 3;
            this.mrbIGD.Tag = "5";
            this.mrbIGD.Text = "IGD";
            this.mrbIGD.UseSelectable = true;
            // 
            // mrbFiduciary
            // 
            this.mrbFiduciary.AutoSize = true;
            this.mrbFiduciary.Location = new System.Drawing.Point(130, 21);
            this.mrbFiduciary.Name = "mrbFiduciary";
            this.mrbFiduciary.Size = new System.Drawing.Size(71, 15);
            this.mrbFiduciary.TabIndex = 2;
            this.mrbFiduciary.Tag = "4";
            this.mrbFiduciary.Text = "Fiduciary";
            this.mrbFiduciary.UseSelectable = true;
            // 
            // mrbMasteral
            // 
            this.mrbMasteral.AutoSize = true;
            this.mrbMasteral.Location = new System.Drawing.Point(8, 42);
            this.mrbMasteral.Name = "mrbMasteral";
            this.mrbMasteral.Size = new System.Drawing.Size(68, 15);
            this.mrbMasteral.TabIndex = 1;
            this.mrbMasteral.Tag = "3";
            this.mrbMasteral.Text = "Masteral";
            this.mrbMasteral.UseSelectable = true;
            // 
            // mrbUndergrad
            // 
            this.mrbUndergrad.AutoSize = true;
            this.mrbUndergrad.Checked = true;
            this.mrbUndergrad.Location = new System.Drawing.Point(8, 21);
            this.mrbUndergrad.Name = "mrbUndergrad";
            this.mrbUndergrad.Size = new System.Drawing.Size(79, 15);
            this.mrbUndergrad.TabIndex = 0;
            this.mrbUndergrad.TabStop = true;
            this.mrbUndergrad.Tag = "2";
            this.mrbUndergrad.Text = "Undergrad";
            this.mrbUndergrad.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(22, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Amount :";
            // 
            // tAmount
            // 
            this.tAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAmount.Location = new System.Drawing.Point(125, 21);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(267, 62);
            this.tAmount.TabIndex = 1;
            // 
            // frmOrPayDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tPaymentOrNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtOrDate);
            this.Controls.Add(this.label2);
            this.Name = "frmOrPayDataEntry";
            this.ShowInTaskbar = false;
            this.Text = "Other Payments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrPayDataEntry_FormClosed);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtOrDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tPaymentOrNo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pNewParticular.ResumeLayout(false);
            this.pNewParticular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtOrDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tPaymentOrNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDataEntryOP;
        private System.Windows.Forms.ColumnHeader clmSeqNo;
        private System.Windows.Forms.ColumnHeader clmSemNo;
        private System.Windows.Forms.ColumnHeader clmStudID;
        private System.Windows.Forms.ColumnHeader clmParticulars;
        private System.Windows.Forms.ColumnHeader clmAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader clmPayment;
        private System.Windows.Forms.ColumnHeader clmBalance;
        private System.Windows.Forms.Button btnSelectParticular;
        private System.Windows.Forms.TextBox tbMiddlename;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPayor;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.Label lbStudID;
        private System.Windows.Forms.ComboBox cmbParticular;
        private System.Windows.Forms.Button btnAddParticular;
        private System.Windows.Forms.Panel pNewParticular;
        private System.Windows.Forms.TextBox tbNewParticularAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNewParticularShortDesc;
        private System.Windows.Forms.Button btnNewParticular;
        private System.Windows.Forms.Button btnNewParticularExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton mrbBtr;
        private MetroFramework.Controls.MetroRadioButton mrbIGD;
        private MetroFramework.Controls.MetroRadioButton mrbFiduciary;
        private MetroFramework.Controls.MetroRadioButton mrbMasteral;
        private MetroFramework.Controls.MetroRadioButton mrbUndergrad;
    }
}