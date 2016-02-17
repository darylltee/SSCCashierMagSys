namespace Cashier
{
    partial class frmPartialPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartialPayment));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbSemNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.lbMscFee = new System.Windows.Forms.Label();
            this.lbTuitionFee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnFull = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tPaymentOrNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtOrDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.lbStudNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(576, 10);
            this.btnSave.Size = new System.Drawing.Size(63, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "       OK";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(646, 10);
            this.btnCancel.Size = new System.Drawing.Size(85, 40);
            this.btnCancel.Text = "       Cancel";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(709, 60);
            this.label1.Text = "     Payment Method";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 127);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 213);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SeqNo";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "StudID";
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SemNo";
            this.columnHeader3.Width = 48;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Particulars";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Payment";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Balance";
            this.columnHeader7.Width = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Semester :";
            // 
            // tbSemNo
            // 
            this.tbSemNo.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemNo.Location = new System.Drawing.Point(171, 69);
            this.tbSemNo.Name = "tbSemNo";
            this.tbSemNo.Size = new System.Drawing.Size(37, 17);
            this.tbSemNo.TabIndex = 1;
            this.tbSemNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbSemNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSemNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "For :";
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbStudentName.Location = new System.Drawing.Point(471, 73);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(92, 13);
            this.lbStudentName.TabIndex = 7;
            this.lbStudentName.Text = "[ Student Name ]";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.tAmount);
            this.groupBox1.Controls.Add(this.lbMscFee);
            this.groupBox1.Controls.Add(this.lbTuitionFee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtnFull);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(14, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Summary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Amount :";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTotal.Location = new System.Drawing.Point(486, 20);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 25);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "0.00";
            // 
            // tAmount
            // 
            this.tAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.tAmount.Location = new System.Drawing.Point(479, 54);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(226, 22);
            this.tAmount.TabIndex = 25;
            this.tAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tAmount_KeyPress);
            // 
            // lbMscFee
            // 
            this.lbMscFee.AutoSize = true;
            this.lbMscFee.Location = new System.Drawing.Point(286, 43);
            this.lbMscFee.Name = "lbMscFee";
            this.lbMscFee.Size = new System.Drawing.Size(13, 13);
            this.lbMscFee.TabIndex = 4;
            this.lbMscFee.Text = "0";
            // 
            // lbTuitionFee
            // 
            this.lbTuitionFee.AutoSize = true;
            this.lbTuitionFee.Location = new System.Drawing.Point(286, 22);
            this.lbTuitionFee.Name = "lbTuitionFee";
            this.lbTuitionFee.Size = new System.Drawing.Size(13, 13);
            this.lbTuitionFee.TabIndex = 3;
            this.lbTuitionFee.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(35, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Miscellaneous Fee (REQUIRED) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(35, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tuition Fee (50% if Partial) :";
            // 
            // rbtnFull
            // 
            this.rbtnFull.AutoSize = true;
            this.rbtnFull.Location = new System.Drawing.Point(591, 80);
            this.rbtnFull.Name = "rbtnFull";
            this.rbtnFull.Size = new System.Drawing.Size(91, 17);
            this.rbtnFull.TabIndex = 2;
            this.rbtnFull.Text = "Full Payment";
            this.rbtnFull.UseVisualStyleBackColor = true;
            this.rbtnFull.CheckedChanged += new System.EventHandler(this.rbtnFull_CheckedChanged_2);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(409, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total :";
            // 
            // tPaymentOrNo
            // 
            this.tPaymentOrNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPaymentOrNo.Location = new System.Drawing.Point(138, 98);
            this.tPaymentOrNo.Name = "tPaymentOrNo";
            this.tPaymentOrNo.Size = new System.Drawing.Size(186, 22);
            this.tPaymentOrNo.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Payment Order # :";
            // 
            // dtOrDate
            // 
            this.dtOrDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOrDate.Location = new System.Drawing.Point(475, 98);
            this.dtOrDate.Name = "dtOrDate";
            this.dtOrDate.Size = new System.Drawing.Size(233, 22);
            this.dtOrDate.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date :";
            // 
            // cmbSem
            // 
            this.cmbSem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Location = new System.Drawing.Point(138, 69);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(186, 21);
            this.cmbSem.TabIndex = 25;
            this.cmbSem.SelectedIndexChanged += new System.EventHandler(this.cmbSem_SelectedIndexChanged);
            // 
            // lbStudNo
            // 
            this.lbStudNo.AutoSize = true;
            this.lbStudNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudNo.ForeColor = System.Drawing.Color.DimGray;
            this.lbStudNo.Location = new System.Drawing.Point(616, 60);
            this.lbStudNo.Name = "lbStudNo";
            this.lbStudNo.Size = new System.Drawing.Size(108, 13);
            this.lbStudNo.TabIndex = 26;
            this.lbStudNo.Text = "[ Student Number ]";
            // 
            // frmPartialPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopLeft;
            this.ClientSize = new System.Drawing.Size(755, 455);
            this.Controls.Add(this.lbStudNo);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.tPaymentOrNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtOrDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSemNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPartialPayment";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPartialPayment_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbSemNo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbStudentName, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dtOrDate, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tPaymentOrNo, 0);
            this.Controls.SetChildIndex(this.cmbSem, 0);
            this.Controls.SetChildIndex(this.lbStudNo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSemNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMscFee;
        private System.Windows.Forms.Label lbTuitionFee;
        private System.Windows.Forms.CheckBox rbtnFull;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tPaymentOrNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtOrDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.Label lbStudNo;
    }
}