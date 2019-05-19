namespace yazılım_Yapımı
{
    partial class frm_Sınav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sınav));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ingilizceCevap = new System.Windows.Forms.TextBox();
            this.lbl_türkceKelime = new System.Windows.Forms.Label();
            this.btn_cevapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(194, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "İngilizce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Türkçe";
            // 
            // txt_ingilizceCevap
            // 
            this.txt_ingilizceCevap.Location = new System.Drawing.Point(192, 124);
            this.txt_ingilizceCevap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ingilizceCevap.Name = "txt_ingilizceCevap";
            this.txt_ingilizceCevap.Size = new System.Drawing.Size(94, 20);
            this.txt_ingilizceCevap.TabIndex = 5;
            // 
            // lbl_türkceKelime
            // 
            this.lbl_türkceKelime.AutoSize = true;
            this.lbl_türkceKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_türkceKelime.Location = new System.Drawing.Point(98, 115);
            this.lbl_türkceKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_türkceKelime.Name = "lbl_türkceKelime";
            this.lbl_türkceKelime.Size = new System.Drawing.Size(0, 26);
            this.lbl_türkceKelime.TabIndex = 7;
            // 
            // btn_cevapla
            // 
            this.btn_cevapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cevapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cevapla.Image = ((System.Drawing.Image)(resources.GetObject("btn_cevapla.Image")));
            this.btn_cevapla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cevapla.Location = new System.Drawing.Point(123, 171);
            this.btn_cevapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cevapla.Name = "btn_cevapla";
            this.btn_cevapla.Size = new System.Drawing.Size(125, 50);
            this.btn_cevapla.TabIndex = 9;
            this.btn_cevapla.Text = "Cevapla";
            this.btn_cevapla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cevapla.UseVisualStyleBackColor = false;
            this.btn_cevapla.Click += new System.EventHandler(this.btn_cevapla_Click);
            // 
            // frm_Sınav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(386, 311);
            this.Controls.Add(this.btn_cevapla);
            this.Controls.Add(this.lbl_türkceKelime);
            this.Controls.Add(this.txt_ingilizceCevap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Sınav";
            this.Text = "Sınav";
            this.Load += new System.EventHandler(this.frm_Sınav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ingilizceCevap;
        private System.Windows.Forms.Label lbl_türkceKelime;
        private System.Windows.Forms.Button btn_cevapla;
    }
}