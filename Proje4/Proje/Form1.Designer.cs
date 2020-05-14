namespace Proje
{
    partial class Form1
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
            this.picAtik = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOrganikAtik = new System.Windows.Forms.Button();
            this.btnBosaltOrganikAtik = new System.Windows.Forms.Button();
            this.btnKagitAtik = new System.Windows.Forms.Button();
            this.btnBosaltKagitAtik = new System.Windows.Forms.Button();
            this.btnCamAtik = new System.Windows.Forms.Button();
            this.btnBosaltCamAtik = new System.Windows.Forms.Button();
            this.btnMetalAtik = new System.Windows.Forms.Button();
            this.btnBosaltMetalAtik = new System.Windows.Forms.Button();
            this.pbarOrganikAtik = new System.Windows.Forms.ProgressBar();
            this.pbarKagitAtik = new System.Windows.Forms.ProgressBar();
            this.pbarCamAtik = new System.Windows.Forms.ProgressBar();
            this.pbarMetalAtik = new System.Windows.Forms.ProgressBar();
            this.lstOrganikAtik = new System.Windows.Forms.ListBox();
            this.lstKagitAtik = new System.Windows.Forms.ListBox();
            this.lstCamAtik = new System.Windows.Forms.ListBox();
            this.lstMetalAtik = new System.Windows.Forms.ListBox();
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.lblYuzdeOrganik = new System.Windows.Forms.Label();
            this.lblYuzdeKagit = new System.Windows.Forms.Label();
            this.lblYuzdeCam = new System.Windows.Forms.Label();
            this.lblYuzdeMetal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAtik)).BeginInit();
            this.SuspendLayout();
            // 
            // picAtik
            // 
            this.picAtik.BackColor = System.Drawing.Color.AntiqueWhite;
            this.picAtik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAtik.Location = new System.Drawing.Point(13, 19);
            this.picAtik.Name = "picAtik";
            this.picAtik.Size = new System.Drawing.Size(209, 185);
            this.picAtik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtik.TabIndex = 0;
            this.picAtik.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(244, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 438);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeniOyun.Location = new System.Drawing.Point(28, 243);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(178, 51);
            this.btnYeniOyun.TabIndex = 3;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "SÜRE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSure.Location = new System.Drawing.Point(28, 342);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(178, 86);
            this.lblSure.TabIndex = 5;
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuan.Location = new System.Drawing.Point(28, 475);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(178, 83);
            this.lblPuan.TabIndex = 7;
            this.lblPuan.Text = "0";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "PUAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(28, 587);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(178, 51);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(244, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 291);
            this.label6.TabIndex = 9;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(443, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 291);
            this.label7.TabIndex = 10;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(244, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 291);
            this.label8.TabIndex = 11;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(443, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 291);
            this.label9.TabIndex = 12;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrganikAtik
            // 
            this.btnOrganikAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnOrganikAtik.Location = new System.Drawing.Point(260, 78);
            this.btnOrganikAtik.Name = "btnOrganikAtik";
            this.btnOrganikAtik.Size = new System.Drawing.Size(152, 32);
            this.btnOrganikAtik.TabIndex = 13;
            this.btnOrganikAtik.Text = "ORGANİK ATIK";
            this.btnOrganikAtik.UseVisualStyleBackColor = false;
            this.btnOrganikAtik.Click += new System.EventHandler(this.btnOrganikAtik_Click);
            // 
            // btnBosaltOrganikAtik
            // 
            this.btnBosaltOrganikAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnBosaltOrganikAtik.Location = new System.Drawing.Point(260, 313);
            this.btnBosaltOrganikAtik.Name = "btnBosaltOrganikAtik";
            this.btnBosaltOrganikAtik.Size = new System.Drawing.Size(152, 32);
            this.btnBosaltOrganikAtik.TabIndex = 14;
            this.btnBosaltOrganikAtik.Text = "BOŞALT";
            this.btnBosaltOrganikAtik.UseVisualStyleBackColor = false;
            this.btnBosaltOrganikAtik.Click += new System.EventHandler(this.btnBosaltOrganikAtik_Click);
            // 
            // btnKagitAtik
            // 
            this.btnKagitAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnKagitAtik.Location = new System.Drawing.Point(458, 78);
            this.btnKagitAtik.Name = "btnKagitAtik";
            this.btnKagitAtik.Size = new System.Drawing.Size(152, 32);
            this.btnKagitAtik.TabIndex = 15;
            this.btnKagitAtik.Text = "KAĞIT";
            this.btnKagitAtik.UseVisualStyleBackColor = false;
            this.btnKagitAtik.Click += new System.EventHandler(this.btnKagitAtik_Click);
            // 
            // btnBosaltKagitAtik
            // 
            this.btnBosaltKagitAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnBosaltKagitAtik.Location = new System.Drawing.Point(458, 313);
            this.btnBosaltKagitAtik.Name = "btnBosaltKagitAtik";
            this.btnBosaltKagitAtik.Size = new System.Drawing.Size(152, 32);
            this.btnBosaltKagitAtik.TabIndex = 16;
            this.btnBosaltKagitAtik.Text = "BOŞALT";
            this.btnBosaltKagitAtik.UseVisualStyleBackColor = false;
            this.btnBosaltKagitAtik.Click += new System.EventHandler(this.btnBosaltKagitAtik_Click);
            // 
            // btnCamAtik
            // 
            this.btnCamAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnCamAtik.Location = new System.Drawing.Point(260, 375);
            this.btnCamAtik.Name = "btnCamAtik";
            this.btnCamAtik.Size = new System.Drawing.Size(152, 32);
            this.btnCamAtik.TabIndex = 17;
            this.btnCamAtik.Text = "CAM";
            this.btnCamAtik.UseVisualStyleBackColor = false;
            this.btnCamAtik.Click += new System.EventHandler(this.btnCamAtik_Click);
            // 
            // btnBosaltCamAtik
            // 
            this.btnBosaltCamAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnBosaltCamAtik.Location = new System.Drawing.Point(260, 610);
            this.btnBosaltCamAtik.Name = "btnBosaltCamAtik";
            this.btnBosaltCamAtik.Size = new System.Drawing.Size(152, 32);
            this.btnBosaltCamAtik.TabIndex = 18;
            this.btnBosaltCamAtik.Text = "BOŞALT";
            this.btnBosaltCamAtik.UseVisualStyleBackColor = false;
            this.btnBosaltCamAtik.Click += new System.EventHandler(this.btnBosaltCamAtik_Click);
            // 
            // btnMetalAtik
            // 
            this.btnMetalAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnMetalAtik.Location = new System.Drawing.Point(458, 375);
            this.btnMetalAtik.Name = "btnMetalAtik";
            this.btnMetalAtik.Size = new System.Drawing.Size(152, 32);
            this.btnMetalAtik.TabIndex = 19;
            this.btnMetalAtik.Text = "METAL";
            this.btnMetalAtik.UseVisualStyleBackColor = false;
            this.btnMetalAtik.Click += new System.EventHandler(this.btnMetalAtik_Click);
            // 
            // btnBosaltMetalAtik
            // 
            this.btnBosaltMetalAtik.BackColor = System.Drawing.Color.MintCream;
            this.btnBosaltMetalAtik.Location = new System.Drawing.Point(458, 610);
            this.btnBosaltMetalAtik.Name = "btnBosaltMetalAtik";
            this.btnBosaltMetalAtik.Size = new System.Drawing.Size(152, 32);
            this.btnBosaltMetalAtik.TabIndex = 20;
            this.btnBosaltMetalAtik.Text = "BOŞALT";
            this.btnBosaltMetalAtik.UseVisualStyleBackColor = false;
            this.btnBosaltMetalAtik.Click += new System.EventHandler(this.btnBosaltMetalAtik_Click);
            // 
            // pbarOrganikAtik
            // 
            this.pbarOrganikAtik.Location = new System.Drawing.Point(260, 284);
            this.pbarOrganikAtik.Maximum = 700;
            this.pbarOrganikAtik.Name = "pbarOrganikAtik";
            this.pbarOrganikAtik.Size = new System.Drawing.Size(152, 23);
            this.pbarOrganikAtik.TabIndex = 21;
            // 
            // pbarKagitAtik
            // 
            this.pbarKagitAtik.Location = new System.Drawing.Point(458, 284);
            this.pbarKagitAtik.Maximum = 1200;
            this.pbarKagitAtik.Name = "pbarKagitAtik";
            this.pbarKagitAtik.Size = new System.Drawing.Size(152, 23);
            this.pbarKagitAtik.TabIndex = 22;
            // 
            // pbarCamAtik
            // 
            this.pbarCamAtik.Location = new System.Drawing.Point(260, 581);
            this.pbarCamAtik.Maximum = 2200;
            this.pbarCamAtik.Name = "pbarCamAtik";
            this.pbarCamAtik.Size = new System.Drawing.Size(152, 23);
            this.pbarCamAtik.TabIndex = 23;
            // 
            // pbarMetalAtik
            // 
            this.pbarMetalAtik.Location = new System.Drawing.Point(458, 581);
            this.pbarMetalAtik.Maximum = 2300;
            this.pbarMetalAtik.Name = "pbarMetalAtik";
            this.pbarMetalAtik.Size = new System.Drawing.Size(152, 23);
            this.pbarMetalAtik.TabIndex = 24;
            // 
            // lstOrganikAtik
            // 
            this.lstOrganikAtik.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstOrganikAtik.FormattingEnabled = true;
            this.lstOrganikAtik.ItemHeight = 16;
            this.lstOrganikAtik.Location = new System.Drawing.Point(260, 117);
            this.lstOrganikAtik.Name = "lstOrganikAtik";
            this.lstOrganikAtik.Size = new System.Drawing.Size(152, 164);
            this.lstOrganikAtik.TabIndex = 25;
            // 
            // lstKagitAtik
            // 
            this.lstKagitAtik.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstKagitAtik.FormattingEnabled = true;
            this.lstKagitAtik.ItemHeight = 16;
            this.lstKagitAtik.Location = new System.Drawing.Point(458, 117);
            this.lstKagitAtik.Name = "lstKagitAtik";
            this.lstKagitAtik.Size = new System.Drawing.Size(152, 164);
            this.lstKagitAtik.TabIndex = 26;
            // 
            // lstCamAtik
            // 
            this.lstCamAtik.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstCamAtik.FormattingEnabled = true;
            this.lstCamAtik.ItemHeight = 16;
            this.lstCamAtik.Location = new System.Drawing.Point(260, 413);
            this.lstCamAtik.Name = "lstCamAtik";
            this.lstCamAtik.Size = new System.Drawing.Size(152, 164);
            this.lstCamAtik.TabIndex = 27;
            // 
            // lstMetalAtik
            // 
            this.lstMetalAtik.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstMetalAtik.FormattingEnabled = true;
            this.lstMetalAtik.ItemHeight = 16;
            this.lstMetalAtik.Location = new System.Drawing.Point(458, 413);
            this.lstMetalAtik.Name = "lstMetalAtik";
            this.lstMetalAtik.Size = new System.Drawing.Size(152, 164);
            this.lstMetalAtik.TabIndex = 28;
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // lblYuzdeOrganik
            // 
            this.lblYuzdeOrganik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYuzdeOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuzdeOrganik.Location = new System.Drawing.Point(378, 285);
            this.lblYuzdeOrganik.Name = "lblYuzdeOrganik";
            this.lblYuzdeOrganik.Size = new System.Drawing.Size(33, 21);
            this.lblYuzdeOrganik.TabIndex = 29;
            this.lblYuzdeOrganik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYuzdeKagit
            // 
            this.lblYuzdeKagit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYuzdeKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuzdeKagit.Location = new System.Drawing.Point(576, 285);
            this.lblYuzdeKagit.Name = "lblYuzdeKagit";
            this.lblYuzdeKagit.Size = new System.Drawing.Size(33, 21);
            this.lblYuzdeKagit.TabIndex = 30;
            this.lblYuzdeKagit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYuzdeCam
            // 
            this.lblYuzdeCam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYuzdeCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuzdeCam.Location = new System.Drawing.Point(378, 582);
            this.lblYuzdeCam.Name = "lblYuzdeCam";
            this.lblYuzdeCam.Size = new System.Drawing.Size(33, 21);
            this.lblYuzdeCam.TabIndex = 31;
            this.lblYuzdeCam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYuzdeMetal
            // 
            this.lblYuzdeMetal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYuzdeMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuzdeMetal.Location = new System.Drawing.Point(576, 582);
            this.lblYuzdeMetal.Name = "lblYuzdeMetal";
            this.lblYuzdeMetal.Size = new System.Drawing.Size(33, 21);
            this.lblYuzdeMetal.TabIndex = 32;
            this.lblYuzdeMetal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(647, 669);
            this.Controls.Add(this.lblYuzdeMetal);
            this.Controls.Add(this.lblYuzdeCam);
            this.Controls.Add(this.lblYuzdeKagit);
            this.Controls.Add(this.lblYuzdeOrganik);
            this.Controls.Add(this.lstMetalAtik);
            this.Controls.Add(this.lstCamAtik);
            this.Controls.Add(this.lstKagitAtik);
            this.Controls.Add(this.lstOrganikAtik);
            this.Controls.Add(this.pbarMetalAtik);
            this.Controls.Add(this.pbarCamAtik);
            this.Controls.Add(this.pbarKagitAtik);
            this.Controls.Add(this.pbarOrganikAtik);
            this.Controls.Add(this.btnBosaltMetalAtik);
            this.Controls.Add(this.btnMetalAtik);
            this.Controls.Add(this.btnBosaltCamAtik);
            this.Controls.Add(this.btnCamAtik);
            this.Controls.Add(this.btnBosaltKagitAtik);
            this.Controls.Add(this.btnKagitAtik);
            this.Controls.Add(this.btnBosaltOrganikAtik);
            this.Controls.Add(this.btnOrganikAtik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAtik);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAtik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAtik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOrganikAtik;
        private System.Windows.Forms.Button btnBosaltOrganikAtik;
        private System.Windows.Forms.Button btnKagitAtik;
        private System.Windows.Forms.Button btnBosaltKagitAtik;
        private System.Windows.Forms.Button btnCamAtik;
        private System.Windows.Forms.Button btnBosaltCamAtik;
        private System.Windows.Forms.Button btnMetalAtik;
        private System.Windows.Forms.Button btnBosaltMetalAtik;
        private System.Windows.Forms.ProgressBar pbarOrganikAtik;
        private System.Windows.Forms.ProgressBar pbarKagitAtik;
        private System.Windows.Forms.ProgressBar pbarCamAtik;
        private System.Windows.Forms.ProgressBar pbarMetalAtik;
        private System.Windows.Forms.ListBox lstOrganikAtik;
        private System.Windows.Forms.ListBox lstKagitAtik;
        private System.Windows.Forms.ListBox lstCamAtik;
        private System.Windows.Forms.ListBox lstMetalAtik;
        private System.Windows.Forms.Timer timerSure;
        private System.Windows.Forms.Label lblYuzdeOrganik;
        private System.Windows.Forms.Label lblYuzdeKagit;
        private System.Windows.Forms.Label lblYuzdeCam;
        private System.Windows.Forms.Label lblYuzdeMetal;
    }
}

