
namespace InternetTest
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panelOne = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelNO = new System.Windows.Forms.Panel();
            this.labelTryagain = new System.Windows.Forms.Label();
            this.labelNoInternet = new System.Windows.Forms.Label();
            this.panelOK = new System.Windows.Forms.Panel();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbltimezone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblping = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblTitlte = new System.Windows.Forms.Label();
            this.panelOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelNO.SuspendLayout();
            this.panelOK.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOne
            // 
            this.panelOne.Controls.Add(this.pictureBoxLogo);
            this.panelOne.Controls.Add(this.btnStart);
            this.panelOne.Controls.Add(this.labelTitle);
            this.panelOne.Location = new System.Drawing.Point(121, 81);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(467, 346);
            this.panelOne.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::InternetTest.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(125, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(216, 183);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(109, 275);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(249, 56);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Alhurra", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(103, 201);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(260, 62);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Internet Test";
            // 
            // panelNO
            // 
            this.panelNO.Controls.Add(this.labelTryagain);
            this.panelNO.Controls.Add(this.labelNoInternet);
            this.panelNO.Location = new System.Drawing.Point(12, 12);
            this.panelNO.Name = "panelNO";
            this.panelNO.Size = new System.Drawing.Size(684, 484);
            this.panelNO.TabIndex = 0;
            this.panelNO.Visible = false;
            // 
            // labelTryagain
            // 
            this.labelTryagain.AutoSize = true;
            this.labelTryagain.Font = new System.Drawing.Font("Alhurra", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTryagain.ForeColor = System.Drawing.Color.White;
            this.labelTryagain.Location = new System.Drawing.Point(254, 278);
            this.labelTryagain.Name = "labelTryagain";
            this.labelTryagain.Size = new System.Drawing.Size(200, 51);
            this.labelTryagain.TabIndex = 1;
            this.labelTryagain.Text = "Try Again ...";
            // 
            // labelNoInternet
            // 
            this.labelNoInternet.AutoSize = true;
            this.labelNoInternet.Font = new System.Drawing.Font("Alhurra", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInternet.ForeColor = System.Drawing.Color.White;
            this.labelNoInternet.Location = new System.Drawing.Point(165, 179);
            this.labelNoInternet.Name = "labelNoInternet";
            this.labelNoInternet.Size = new System.Drawing.Size(378, 99);
            this.labelNoInternet.TabIndex = 0;
            this.labelNoInternet.Text = "No Internet ";
            // 
            // panelOK
            // 
            this.panelOK.Controls.Add(this.lblTitlte);
            this.panelOK.Controls.Add(this.lbl5);
            this.panelOK.Controls.Add(this.lbltimezone);
            this.panelOK.Controls.Add(this.lblCity);
            this.panelOK.Controls.Add(this.lbl3);
            this.panelOK.Controls.Add(this.lbl2);
            this.panelOK.Controls.Add(this.lblCountry);
            this.panelOK.Controls.Add(this.lbl4);
            this.panelOK.Controls.Add(this.lblping);
            this.panelOK.Controls.Add(this.lbl1);
            this.panelOK.Controls.Add(this.lblIp);
            this.panelOK.Location = new System.Drawing.Point(15, 15);
            this.panelOK.Name = "panelOK";
            this.panelOK.Size = new System.Drawing.Size(678, 478);
            this.panelOK.TabIndex = 3;
            this.panelOK.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(23, 362);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(156, 42);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Time Zone :";
            // 
            // lbltimezone
            // 
            this.lbltimezone.AutoSize = true;
            this.lbltimezone.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimezone.ForeColor = System.Drawing.Color.White;
            this.lbltimezone.Location = new System.Drawing.Point(292, 362);
            this.lbltimezone.Name = "lbltimezone";
            this.lbltimezone.Size = new System.Drawing.Size(96, 42);
            this.lbltimezone.TabIndex = 10;
            this.lbltimezone.Text = "label1";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(292, 247);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(96, 42);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "label1";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(23, 247);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(84, 42);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "City : ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(23, 185);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(144, 42);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Countery :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(292, 185);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(96, 42);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "label1";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(23, 302);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(90, 42);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Ping : ";
            // 
            // lblping
            // 
            this.lblping.AutoSize = true;
            this.lblping.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblping.ForeColor = System.Drawing.Color.White;
            this.lblping.Location = new System.Drawing.Point(292, 302);
            this.lblping.Name = "lblping";
            this.lblping.Size = new System.Drawing.Size(96, 42);
            this.lblping.TabIndex = 4;
            this.lblping.Text = "label1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(23, 123);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 42);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "IP : ";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Alhurra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.ForeColor = System.Drawing.Color.White;
            this.lblIp.Location = new System.Drawing.Point(292, 123);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(96, 42);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "label1";
            // 
            // lblTitlte
            // 
            this.lblTitlte.AutoSize = true;
            this.lblTitlte.Font = new System.Drawing.Font("Alhurra", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlte.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitlte.Location = new System.Drawing.Point(240, 25);
            this.lblTitlte.Name = "lblTitlte";
            this.lblTitlte.Size = new System.Drawing.Size(211, 53);
            this.lblTitlte.TabIndex = 12;
            this.lblTitlte.Text = "Information";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(708, 508);
            this.Controls.Add(this.panelOK);
            this.Controls.Add(this.panelNO);
            this.Controls.Add(this.panelOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Test";
            this.panelOne.ResumeLayout(false);
            this.panelOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelNO.ResumeLayout(false);
            this.panelNO.PerformLayout();
            this.panelOK.ResumeLayout(false);
            this.panelOK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelNO;
        private System.Windows.Forms.Panel panelOK;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label labelTryagain;
        private System.Windows.Forms.Label labelNoInternet;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblping;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbltimezone;
        private System.Windows.Forms.Label lblTitlte;
    }
}

