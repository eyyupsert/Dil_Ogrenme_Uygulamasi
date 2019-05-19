namespace yazılım_Yapımı
{
    partial class frm_ıstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ıstatistik));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Aylar = new System.Windows.Forms.ComboBox();
            this.btn_istatistikBilgi = new System.Windows.Forms.Button();
            this.lstbx_istatistik = new System.Windows.Forms.ListBox();
            this.lbl_kelimesaybilgi = new System.Windows.Forms.Label();
            this.lbl_ogrenilenkelsayısı = new System.Windows.Forms.Label();
            this.rdb_ay = new System.Windows.Forms.RadioButton();
            this.rdb_yil = new System.Windows.Forms.RadioButton();
            this.cmb_yillar = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görüntüleme Şeklini \r\nSeçiniz ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Aylar
            // 
            this.cmb_Aylar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Aylar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Aylar.FormattingEnabled = true;
            this.cmb_Aylar.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmb_Aylar.Location = new System.Drawing.Point(28, 192);
            this.cmb_Aylar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Aylar.Name = "cmb_Aylar";
            this.cmb_Aylar.Size = new System.Drawing.Size(210, 30);
            this.cmb_Aylar.TabIndex = 1;
            this.cmb_Aylar.Visible = false;
            // 
            // btn_istatistikBilgi
            // 
            this.btn_istatistikBilgi.BackColor = System.Drawing.Color.Gold;
            this.btn_istatistikBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_istatistikBilgi.Image = ((System.Drawing.Image)(resources.GetObject("btn_istatistikBilgi.Image")));
            this.btn_istatistikBilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_istatistikBilgi.Location = new System.Drawing.Point(49, 237);
            this.btn_istatistikBilgi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_istatistikBilgi.Name = "btn_istatistikBilgi";
            this.btn_istatistikBilgi.Size = new System.Drawing.Size(164, 63);
            this.btn_istatistikBilgi.TabIndex = 2;
            this.btn_istatistikBilgi.Text = "İstatistik\r\nGörüntüle";
            this.btn_istatistikBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_istatistikBilgi.UseVisualStyleBackColor = false;
            this.btn_istatistikBilgi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbx_istatistik
            // 
            this.lstbx_istatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbx_istatistik.FormattingEnabled = true;
            this.lstbx_istatistik.ItemHeight = 17;
            this.lstbx_istatistik.Location = new System.Drawing.Point(262, 15);
            this.lstbx_istatistik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbx_istatistik.Name = "lstbx_istatistik";
            this.lstbx_istatistik.Size = new System.Drawing.Size(264, 276);
            this.lstbx_istatistik.TabIndex = 3;
            // 
            // lbl_kelimesaybilgi
            // 
            this.lbl_kelimesaybilgi.AutoSize = true;
            this.lbl_kelimesaybilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelimesaybilgi.Location = new System.Drawing.Point(274, 334);
            this.lbl_kelimesaybilgi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kelimesaybilgi.Name = "lbl_kelimesaybilgi";
            this.lbl_kelimesaybilgi.Size = new System.Drawing.Size(143, 13);
            this.lbl_kelimesaybilgi.TabIndex = 4;
            this.lbl_kelimesaybilgi.Text = "Öğrenilen Kelime Sayısı:";
            this.lbl_kelimesaybilgi.Visible = false;
            // 
            // lbl_ogrenilenkelsayısı
            // 
            this.lbl_ogrenilenkelsayısı.AutoSize = true;
            this.lbl_ogrenilenkelsayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogrenilenkelsayısı.Location = new System.Drawing.Point(475, 334);
            this.lbl_ogrenilenkelsayısı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ogrenilenkelsayısı.Name = "lbl_ogrenilenkelsayısı";
            this.lbl_ogrenilenkelsayısı.Size = new System.Drawing.Size(0, 13);
            this.lbl_ogrenilenkelsayısı.TabIndex = 5;
            // 
            // rdb_ay
            // 
            this.rdb_ay.AutoSize = true;
            this.rdb_ay.Location = new System.Drawing.Point(67, 103);
            this.rdb_ay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_ay.Name = "rdb_ay";
            this.rdb_ay.Size = new System.Drawing.Size(66, 17);
            this.rdb_ay.TabIndex = 6;
            this.rdb_ay.TabStop = true;
            this.rdb_ay.Text = "Ay ve Yıl";
            this.rdb_ay.UseVisualStyleBackColor = true;
            this.rdb_ay.CheckedChanged += new System.EventHandler(this.rdb_ay_CheckedChanged);
            // 
            // rdb_yil
            // 
            this.rdb_yil.AutoSize = true;
            this.rdb_yil.Location = new System.Drawing.Point(162, 103);
            this.rdb_yil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_yil.Name = "rdb_yil";
            this.rdb_yil.Size = new System.Drawing.Size(36, 17);
            this.rdb_yil.TabIndex = 7;
            this.rdb_yil.TabStop = true;
            this.rdb_yil.Text = "Yıl";
            this.rdb_yil.UseVisualStyleBackColor = true;
            this.rdb_yil.CheckedChanged += new System.EventHandler(this.rdb_yil_CheckedChanged);
            // 
            // cmb_yillar
            // 
            this.cmb_yillar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yillar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_yillar.FormattingEnabled = true;
            this.cmb_yillar.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmb_yillar.Location = new System.Drawing.Point(28, 140);
            this.cmb_yillar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_yillar.Name = "cmb_yillar";
            this.cmb_yillar.Size = new System.Drawing.Size(210, 30);
            this.cmb_yillar.TabIndex = 8;
            this.cmb_yillar.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(262, 297);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 26);
            this.progressBar1.TabIndex = 9;
            // 
            // frm_ıstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(548, 371);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmb_yillar);
            this.Controls.Add(this.rdb_yil);
            this.Controls.Add(this.rdb_ay);
            this.Controls.Add(this.lbl_ogrenilenkelsayısı);
            this.Controls.Add(this.lbl_kelimesaybilgi);
            this.Controls.Add(this.lstbx_istatistik);
            this.Controls.Add(this.btn_istatistikBilgi);
            this.Controls.Add(this.cmb_Aylar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ıstatistik";
            this.Text = "frm_ıstatistik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Aylar;
        private System.Windows.Forms.Button btn_istatistikBilgi;
        private System.Windows.Forms.ListBox lstbx_istatistik;
        private System.Windows.Forms.Label lbl_kelimesaybilgi;
        private System.Windows.Forms.Label lbl_ogrenilenkelsayısı;
        private System.Windows.Forms.RadioButton rdb_ay;
        private System.Windows.Forms.RadioButton rdb_yil;
        private System.Windows.Forms.ComboBox cmb_yillar;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}