using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace yazılım_Yapımı
{
    public class Soru
    {
        public string cevap { get; set; }

        public bool SoruKontrolu(string dosya_yolu)
        {
                bool kontrol = false;
                string[] tarihh = new string[3];
                FileStream fEkle = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader dosya = new StreamReader(fEkle);
                string satir;
                satir = dosya.ReadLine();
                while (satir != null)
                {
                    tarihh = Regex.Split(satir, @"\s");
                    if (tarihh[1] == DateTime.Now.ToShortDateString())
                    {
                        kontrol = true;
                    }
                    satir = dosya.ReadLine();
                }
                dosya.Close();
                fEkle.Close();
            return kontrol;
        }
        public string SorulacakSoru()
        {
                string[] tarihh = new string[3];
                FileStream fEkle = new FileStream("ogrenilecek.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader dosya = new StreamReader(fEkle);
                string satir;
                satir = dosya.ReadLine();
                string sorulacakKelime = "";
                while (satir != null)
                {
                    tarihh = Regex.Split(satir, @"\s");
                    if (tarihh[1] == DateTime.Now.ToShortDateString())
                    {
                    sorulacakKelime = tarihh[0];
                    break;
                    }
                    satir = dosya.ReadLine();
                }
                dosya.Close();
                fEkle.Close();
            return sorulacakKelime;
        }
        public bool CevapKontrol(string turkceKelime)
        {
            bool kontrol = false;
            string[] kelime = new string[3];
            FileStream fEkle = new FileStream("ekle.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader dosya = new StreamReader(fEkle);
            string dogruCevap="";
            string satir;
            satir = dosya.ReadLine();
            while (satir != null)
            {

                kelime = Regex.Split(satir, @"\s");
                if (kelime[0] == turkceKelime)
                {
                    dogruCevap = kelime[1];
                    break;
                }
                satir = dosya.ReadLine();
            }
            if (dogruCevap==cevap)
            {
                kontrol = true;
            }
            dosya.Close();
            fEkle.Close();
            return kontrol;
        }
    }


    
}
