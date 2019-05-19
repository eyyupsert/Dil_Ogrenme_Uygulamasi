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
    public partial class frm_KelimeEkle : Form
    {
        public frm_KelimeEkle()
        {
            InitializeComponent();
        }
        private Kelime sözcük;
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            sözcük = new Kelime();
            sözcük.kelimeAdi = txt_türkcesi.Text.ToLower();
            sözcük.kelimeAnlam = txt_ingilizcesi.Text.ToLower();
            sözcük.kelimeTuru = txt_kelimeTürü.Text.ToLower();
            sözcük.KelimeEkle();

            txt_türkcesi.Text = null;
            txt_ingilizcesi.Text = null;
            txt_kelimeTürü.Text = null;
            txt_türkcesi.Focus();
        }
    }
}
