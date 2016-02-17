namespace Cashier
{
    partial class frmPaymentDataEntry
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
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbORNo = new System.Windows.Forms.TextBox();
            this.dtORDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(310, 12);
            this.btnSave.Size = new System.Drawing.Size(76, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save && Print";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Size = new System.Drawing.Size(453, 64);
            this.label1.Text = "Payment";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(152, 131);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(258, 43);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount to Pay : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(56, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change  = ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbChange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbChange.Location = new System.Drawing.Point(252, 34);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(47, 37);
            this.lbChange.TabIndex = 7;
            this.lbChange.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "OR # :";
            // 
            // tbORNo
            // 
            this.tbORNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbORNo.Location = new System.Drawing.Point(310, 63);
            this.tbORNo.Name = "tbORNo";
            this.tbORNo.Size = new System.Drawing.Size(158, 23);
            this.tbORNo.TabIndex = 9;
            this.tbORNo.TextChanged += new System.EventHandler(this.tbORNo_TextChanged);
            // 
            // dtORDate
            // 
            this.dtORDate.Location = new System.Drawing.Point(30, 63);
            this.dtORDate.Name = "dtORDate";
            this.dtORDate.Size = new System.Drawing.Size(200, 20);
            this.dtORDate.TabIndex = 10;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAmountToPay.Location = new System.Drawing.Point(178, 94);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(260, 21);
            this.lblAmountToPay.TabIndex = 11;
            // 
            // frmPaymentDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 317);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.dtORDate);
            this.Controls.Add(this.tbORNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAmount);
            this.Name = "frmPaymentDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Of Payment";
            this.Load += new System.EventHandler(this.frmPaymentDataEntry_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbAmount, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbORNo, 0);
            this.Controls.SetChildIndex(this.dtORDate, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblAmountToPay, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbORNo;
        private System.Windows.Forms.DateTimePicker dtORDate;
        private System.Windows.Forms.Label lblAmountToPay;
    }
}