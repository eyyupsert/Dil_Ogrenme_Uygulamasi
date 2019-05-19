namespace yazılım_Yapımı
{
    partial class frm_AnaMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AnaMenu));
            this.btn_kelimeEkle = new System.Windows.Forms.Button();
            this.btn_kelOgren = new System.Windows.Forms.Button();
            this.btn_sınavGor = new System.Windows.Forms.Button();
            this.btn_istatistikGör = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kelimeEkle
            // 
            this.btn_kelimeEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kelimeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kelimeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_kelimeEkle.Image")));
            this.btn_kelimeEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kelimeEkle.Location = new System.Drawing.Point(142, 11);
            this.btn_kelimeEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kelimeEkle.Name = "btn_kelimeEkle";
            this.btn_kelimeEkle.Size = new System.Drawing.Size(125, 119);
            this.btn_kelimeEkle.TabIndex = 0;
            this.btn_kelimeEkle.Text = "Kelime Ekle";
            this.btn_kelimeEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kelimeEkle.UseVisualStyleBackColor = false;
            this.btn_kelimeEkle.Click += new System.EventHandler(this.btn_kelEkle_Click);
            // 
            // btn_kelOgren
            // 
            this.btn_kelOgren.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kelOgren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kelOgren.Image = ((System.Drawing.Image)(resources.GetObject("btn_kelOgren.Image")));
            this.btn_kelOgren.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kelOgren.Location = new System.Drawing.Point(330, 10);
            this.btn_kelOgren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kelOgren.Name = "btn_kelOgren";
            this.btn_kelOgren.Size = new System.Drawing.Size(125, 119);
            this.btn_kelOgren.TabIndex = 1;
            this.btn_kelOgren.Text = "Kelime Öğren";
            this.btn_kelOgren.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kelOgren.UseVisualStyleBackColor = false;
            this.btn_kelOgren.Click += new System.EventHandler(this.btn_kelOgren_Click);
            // 
            // btn_sınavGor
            // 
            this.btn_sınavGor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sınavGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sınavGor.Image = ((System.Drawing.Image)(resources.GetObject("btn_sınavGor.Image")));
            this.btn_sınavGor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sınavGor.Location = new System.Drawing.Point(142, 168);
            this.btn_sınavGor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sınavGor.Name = "btn_sınavGor";
            this.btn_sınavGor.Size = new System.Drawing.Size(122, 119);
            this.btn_sınavGor.TabIndex = 2;
            this.btn_sınavGor.Text = "Sınavları Görüntüle";
            this.btn_sınavGor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sınavGor.UseVisualStyleBackColor = false;
            this.btn_sınavGor.Click += new System.EventHandler(this.btn_sınavGor_Click);
            // 
            // btn_istatistikGör
            // 
            this.btn_istatistikGör.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_istatistikGör.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_istatistikGör.Image = ((System.Drawing.Image)(resources.GetObject("btn_istatistikGör.Image")));
            this.btn_istatistikGör.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_istatistikGör.Location = new System.Drawing.Point(330, 168);
            this.btn_istatistikGör.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_istatistikGör.Name = "btn_istatistikGör";
            this.btn_istatistikGör.Size = new System.Drawing.Size(125, 119);
            this.btn_istatistikGör.TabIndex = 3;
            this.btn_istatistikGör.Text = "İstatistik Görüntüle";
            this.btn_istatistikGör.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_istatistikGör.UseVisualStyleBackColor = false;
            this.btn_istatistikGör.Click += new System.EventHandler(this.btn_istatistikGör_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(586, 312);
            this.Controls.Add(this.btn_istatistikGör);
            this.Controls.Add(this.btn_sınavGor);
            this.Controls.Add(this.btn_kelOgren);
            this.Controls.Add(this.btn_kelimeEkle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_AnaMenu";
            this.Text = "Ana Menü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kelimeEkle;
        private System.Windows.Forms.Button btn_kelOgren;
        private System.Windows.Forms.Button btn_sınavGor;
        private System.Windows.Forms.Button btn_istatistikGör;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

