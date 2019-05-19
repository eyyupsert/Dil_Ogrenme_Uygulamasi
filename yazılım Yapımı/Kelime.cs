using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace yazılım_Yapımı
{
    public class Kelime
    {
        public string kelimeAdi { get; set; }
        public string kelimeAnlam { get; set; }
        public string kelimeTuru { get; set; }
        Ezberlenecek ezber=new Ezberlenecek();
        
        public void KelimeEkle()
        {
            bool kontrol=KelimeKontrol(kelimeAdi,"ekle.txt");
            if (kontrol)
            {
                string dosya_yolu = "ekle.txt";
                string geciciKelime;
                geciciKelime = kelimeAdi + "\t" + kelimeAnlam + "\t" + kelimeTuru;
                FileStream fEkle = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter dosya = new StreamWriter(fEkle);
                dosya.BaseStream.Seek(0, SeekOrigin.End);
                dosya.WriteLine(geciciKelime);
                dosya.Close();
                fEkle.Close();
                System.Windows.Forms.MessageBox.Show("Kelime Eklendi");
            }
            else System.Windows.Forms.MessageBox.Show("Kelime zaten var !!!");
        }
        public bool KelimeKontrol(string kelimeAdi,string dosya_yolu)
        {
            bool kontrol = true;
            string[] kelime = new string[3];
            FileStream fEkle = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader dosya = new StreamReader(fEkle);
            string satir;
            satir = dosya.ReadLine();
            while (satir != null)
            {
            
            kelime = Regex.Split(satir,@"\s");
                if (kelime[0] == kelimeAdi)
                {
                    kontrol = false;
                }
            satir = dosya.ReadLine();
            }
            dosya.Close();
            fEkle.Close();
            return kontrol;
        }
        public void SecilenKelimeleriYaz(string ogrKelime)
        {
            bool kontrol = KelimeKontrol(kelimeAdi, "ogrenilecek.txt");
            if (kontrol)
            {
                int seviye =0;
                string dosya_yolu = "ogrenilecek.txt";
                string geciciKelime;
                geciciKelime = kelimeAdi + "\t" + DateTime.Now.AddDays(1).ToShortDateString() + "\t" +seviye + "\t";
                FileStream fEkle = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter dosya = new StreamWriter(fEkle);
                dosya.BaseStream.Seek(0, SeekOrigin.End);
                dosya.WriteLine(geciciKelime);
                dosya.Close();
                fEkle.Close();
            }
            else System.Windows.Forms.MessageBox.Show("Kelimeyi zaten eklemişsiniz");
        }
        public void TarihGuncelle(bool cevapBilgi)
        {
            List<string> dosyaGuncelle = new List<string>();
            string guncelVeriler;
            string satir;
            string[] kelime = new string[3];
            FileStream fEkle = new FileStream("ogrenilecek.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader dosya = new StreamReader(fEkle);

            satir = dosya.ReadLine();
            while (satir != null)
            {
                kelime = Regex.Split(satir, @"\s");
                if (kelime[0] == kelimeAdi)
                {
                    if (cevapBilgi == true && kelime[2] == "0")
                    {
                        kelime[2] = "1";
                        kelime[1] = DateTime.Now.AddDays(7).ToShortDateString();

                    }
                    else if (cevapBilgi == true && kelime[2] == "1")
                    {
                        kelime[2] = "2";
                        kelime[1] = DateTime.Now.AddDays(30).ToShortDateString();
                    }
                    else if (cevapBilgi == true && kelime[2] == "2")
                    {
                        kelime[2] = "3";
                        kelime[1] = DateTime.Now.AddDays(180).ToShortDateString();
                    }
                    else if (cevapBilgi == true && kelime[2] == "3")
                    {
                        ezber.EzberlencekKelimeOku(kelime[0], kelime[1]);
                        kelime[1] = null;
                        
                    }
                    else if (cevapBilgi == false)
                    {
                        kelime[2] = "0";
                        kelime[1] = DateTime.Now.AddDays(1).ToShortDateString();
                    }
                    if (kelime[1]!=null)
                    {
                        guncelVeriler = kelime[0] + "\t" + kelime[1] + "\t" + kelime[2];
                        dosyaGuncelle.Add(guncelVeriler);
                    }
                }
                else
                {
                    dosyaGuncelle.Add(satir);
                }
                
                satir = dosya.ReadLine();
            }

            dosya.Close();
            fEkle.Close();
            DosyayıGuncelle(dosyaGuncelle);
        }
        public void DosyayıGuncelle(List<string> kelimeHafıza)
        {
            
            string dosya_yolu = "ogrenilecek.txt";
            TextWriter tw = new StreamWriter(dosya_yolu);
            tw.Write("");
            tw.Close();
            FileStream fEkle = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter dosya = new StreamWriter(fEkle);
            dosya.BaseStream.Seek(0, SeekOrigin.End);
            for (int i = 0; i < kelimeHafıza.Count; i++)
            {
                dosya.WriteLine(kelimeHafıza[i]);
            }
            dosya.Close();
            fEkle.Close();
        }


    }

}
