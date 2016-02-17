namespace Cashier
{
    partial class frmMetroMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetroMainMenu));
            this.mtCashier = new MetroFramework.Controls.MetroTile();
            this.mtOP = new MetroFramework.Controls.MetroTile();
            this.mtReports = new MetroFramework.Controls.MetroTile();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtReports.SuspendLayout();
            this.metroTile4.SuspendLayout();
            this.metroTile5.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtCashier
            // 
            this.mtCashier.ActiveControl = null;
            this.mtCashier.Location = new System.Drawing.Point(182, 110);
            this.mtCashier.Name = "mtCashier";
            this.mtCashier.Size = new System.Drawing.Size(140, 87);
            this.mtCashier.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtCashier.TabIndex = 1;
            this.mtCashier.Text = "Cashier";
            this.mtCashier.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCashier.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCashier.TileImage")));
            this.mtCashier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCashier.UseSelectable = true;
            this.mtCashier.UseTileImage = true;
            this.mtCashier.Click += new System.EventHandler(this.mtCashier_Click);
            // 
            // mtOP
            // 
            this.mtOP.ActiveControl = null;
            this.mtOP.Location = new System.Drawing.Point(27, 110);
            this.mtOP.Name = "mtOP";
            this.mtOP.Size = new System.Drawing.Size(140, 87);
            this.mtOP.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtOP.TabIndex = 2;
            this.mtOP.Text = "Order Of Payment";
            this.mtOP.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtOP.TileImage = ((System.Drawing.Image)(resources.GetObject("mtOP.TileImage")));
            this.mtOP.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOP.UseSelectable = true;
            this.mtOP.UseTileImage = true;
            this.mtOP.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtReports
            // 
            this.mtReports.ActiveControl = null;
            this.mtReports.Controls.Add(this.linkLabel3);
            this.mtReports.Location = new System.Drawing.Point(27, 213);
            this.mtReports.Name = "mtReports";
            this.mtReports.Size = new System.Drawing.Size(295, 87);
            this.mtReports.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtReports.TabIndex = 3;
            this.mtReports.Text = "Reports";
            this.mtReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReports.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtReports.TileImage = ((System.Drawing.Image)(resources.GetObject("mtReports.TileImage")));
            this.mtReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtReports.UseSelectable = true;
            this.mtReports.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel3.Image")));
            this.linkLabel3.Location = new System.Drawing.Point(46, 17);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(72, 57);
            this.linkLabel3.TabIndex = 0;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Controls.Add(this.linkLabel5);
            this.metroTile4.Location = new System.Drawing.Point(27, 319);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(140, 87);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile4.TabIndex = 7;
            this.metroTile4.Text = "Dummy ";
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.UseSelectable = true;
            // 
            // linkLabel5
            // 
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Enabled = false;
            this.linkLabel5.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel5.Image")));
            this.linkLabel5.Location = new System.Drawing.Point(68, 5);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(72, 57);
            this.linkLabel5.TabIndex = 0;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Controls.Add(this.linkLabel6);
            this.metroTile5.Location = new System.Drawing.Point(182, 319);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(140, 87);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile5.TabIndex = 8;
            this.metroTile5.Text = "Dummy";
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.UseSelectable = true;
            // 
            // linkLabel6
            // 
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Enabled = false;
            this.linkLabel6.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel6.Image")));
            this.linkLabel6.Location = new System.Drawing.Point(64, 5);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(72, 57);
            this.linkLabel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Management System ( Currently in development)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome user : ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(726, 110);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(213, 216);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.Location = new System.Drawing.Point(132, 179);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(61, 33);
            this.metroLink1.TabIndex = 11;
            this.metroLink1.Text = "Logout";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 134);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmMetroMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 548);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.mtReports);
            this.Controls.Add(this.mtOP);
            this.Controls.Add(this.mtCashier);
            this.Name = "frmMetroMainMenu";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = " ";
            this.mtReports.ResumeLayout(false);
            this.metroTile4.ResumeLayout(false);
            this.metroTile5.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCashier;
        private MetroFramework.Controls.MetroTile mtOP;
        private MetroFramework.Controls.MetroTile mtReports;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}