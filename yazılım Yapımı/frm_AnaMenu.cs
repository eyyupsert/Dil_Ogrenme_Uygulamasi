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
    public partial class frm_AnaMenu : Form
    {
        public frm_AnaMenu()
        {
            InitializeComponent();
        }

        private void btn_kelEkle_Click(object sender, EventArgs e)
        {
            frm_KelimeEkle form2sec = new frm_KelimeEkle();
            form2sec.ShowDialog();
        }

        Soru sor = new Soru();

        private void btn_kelOgren_Click(object sender, EventArgs e)
        {
            frm_Kelimeogren form2sec = new frm_Kelimeogren();
            form2sec.ShowDialog();
        }

        private void btn_sınavGor_Click(object sender, EventArgs e)
        {
            if (sor.SoruKontrolu("ogrenilecek.txt") == true)
            {
                frm_Sınav form2sec = new frm_Sınav();
                form2sec.ShowDialog();
            }
            else
                MessageBox.Show("Bugüne ait sınavınız bulunmamaktadır.");
        }

        private void btn_istatistikGör_Click(object sender, EventArgs e)
        {
            frm_ıstatistik form2sec = new frm_ıstatistik();
            form2sec.ShowDialog();
        }

        
    }
}
