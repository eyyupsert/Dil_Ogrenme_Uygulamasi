namespace yazılım_Yapımı
{
    partial class frm_Kelimeogren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Kelimeogren));
            this.cmb_kelimeSec = new System.Windows.Forms.ComboBox();
            this.btn_ögrenilcekEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_kelimeSec
            // 
            this.cmb_kelimeSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kelimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kelimeSec.FormattingEnabled = true;
            this.cmb_kelimeSec.Location = new System.Drawing.Point(152, 97);
            this.cmb_kelimeSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_kelimeSec.Name = "cmb_kelimeSec";
            this.cmb_kelimeSec.Size = new System.Drawing.Size(144, 25);
            this.cmb_kelimeSec.TabIndex = 6;
            // 
            // btn_ögrenilcekEkle
            // 
            this.btn_ögrenilcekEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ögrenilcekEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ögrenilcekEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ögrenilcekEkle.Image")));
            this.btn_ögrenilcekEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ögrenilcekEkle.Location = new System.Drawing.Point(160, 141);
            this.btn_ögrenilcekEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ögrenilcekEkle.Name = "btn_ögrenilcekEkle";
            this.btn_ögrenilcekEkle.Size = new System.Drawing.Size(122, 80);
            this.btn_ögrenilcekEkle.TabIndex = 7;
            this.btn_ögrenilcekEkle.Text = "Öğrenileceklere\r\nEkle";
            this.btn_ögrenilcekEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ögrenilcekEkle.UseVisualStyleBackColor = false;
            this.btn_ögrenilcekEkle.Click += new System.EventHandler(this.btn_ögrenilcekEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenmek İstediğini Kelimeleri Seçin";
            // 
            // frm_Kelimeogren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(442, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ögrenilcekEkle);
            this.Controls.Add(this.cmb_kelimeSec);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Kelimeogren";
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.frm_Kelimeogren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_kelimeSec;
        private System.Windows.Forms.Button btn_ögrenilcekEkle;
        private System.Windows.Forms.Label label1;
    }
}