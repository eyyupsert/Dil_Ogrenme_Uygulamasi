using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace yazılım_Yapımı
{
    public partial class frm_Kelimeogren : Form
    {
        public frm_Kelimeogren()
        {
            InitializeComponent();
        }
         private void frm_Kelimeogren_Load(object sender, EventArgs e)
        {
            string dosya_yolu = "ekle.txt";
            string[] kelime = new string[3];
            FileStream fEkle = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader dosya = new StreamReader(fEkle);
            string satir;
            satir = dosya.ReadLine();
            while (satir != null)
            {
                kelime = Regex.Split(satir, @"\s");
                cmb_kelimeSec.Items.Add(kelime[0]);
                satir = dosya.ReadLine();
            }
            dosya.Close();
            fEkle.Close();
        }
        Kelime kel = new Kelime();

        private void btn_ögrenilcekEkle_Click(object sender, EventArgs e)
        {
            kel.kelimeAdi = cmb_kelimeSec.Text.ToLower();
            kel.SecilenKelimeleriYaz(cmb_kelimeSec.Text);
        }
    }
}
