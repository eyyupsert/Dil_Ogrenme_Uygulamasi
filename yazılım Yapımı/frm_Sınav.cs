using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılım_Yapımı
{
    public partial class frm_Sınav : Form
    {
        public frm_Sınav()
        {
            InitializeComponent();
        }

        Soru sor = new Soru();
        Kelime kel = new Kelime();
        private void frm_Sınav_Load(object sender, EventArgs e)
        {
            lbl_türkceKelime.Text= sor.SorulacakSoru();
        }
        private void btn_cevapla_Click(object sender, EventArgs e)
        {
           sor.cevap = txt_ingilizceCevap.Text.ToLower();
            
            if (sor.CevapKontrol(lbl_türkceKelime.Text)==true)
            {
                MessageBox.Show("Evet Bildiniz");
                kel.kelimeAdi = lbl_türkceKelime.Text;
                kel.TarihGuncelle(true);
                if (sor.SoruKontrolu("ogrenilecek.txt") == true)
                {
                    lbl_türkceKelime.Text = sor.SorulacakSoru();
                }
                else
                {
                    MessageBox.Show("Bugüne Ait Sınavınız Kalmadı");
                    this.Close();
                }
            }
            else
            {
                kel.kelimeAdi = lbl_türkceKelime.Text;
                MessageBox.Show("Bilemedin");
                kel.TarihGuncelle(false);
                if (sor.SoruKontrolu("ogrenilecek.txt") == true)
                {
                    lbl_türkceKelime.Text = sor.SorulacakSoru();
                }
                else
                {
                    MessageBox.Show("Sınavınız Bitti");
                    this.Close();
                }
            }

  
        }

    }
}
