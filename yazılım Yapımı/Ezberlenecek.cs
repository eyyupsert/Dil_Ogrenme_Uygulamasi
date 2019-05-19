using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace yazılım_Yapımı
{
    class Ezberlenecek
    {
        public int ay { get; set; }
        public int yil { get; set; }
        public bool aysecimi;
        public void EzberlencekKelimeOku(string ezberKelime,string ezberTarihi)//6 ay bilinen kelimeler burada dosyaya yazdırılacak
        {
            string[] kelime = new string[3];
            FileStream fEkle = new FileStream("ekle.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader dosya = new StreamReader(fEkle);
            string ezberYaz="";
            string satir;
            satir = dosya.ReadLine();
            while (satir != null)
            {

                kelime = Regex.Split(satir, @"\s");
                if (kelime[0] == ezberKelime)
                {
                    ezberYaz = kelime[0]+"\t"+ kelime[1] +"\t"+ ezberTarihi;
                    break;
                }
                satir = dosya.ReadLine();
            }
            dosya.Close();
            fEkle.Close();
            EzberlenecekKelimeYaz(ezberYaz);
        }

        public void EzberlenecekKelimeYaz(string ezberBilgileri)
        {
            string dosya_yolu = "ezberlenmis.txt";
            FileStream fEkle = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter dosya = new StreamWriter(fEkle);
            dosya.BaseStream.Seek(0, SeekOrigin.End);
            dosya.WriteLine(ezberBilgileri);
            dosya.Close();
            fEkle.Close();
        }
        public List<string> IstatistikTut()
        {
            List<string> istatistikBilgileri = new List<string>();
            string[] kelime = new string[3];
            string[] tarihBölmek = new string[3];
            FileStream fEkle = new FileStream("ezberlenmis.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader dosya = new StreamReader(fEkle);
            string satir;
            satir = dosya.ReadLine();
            while (satir != null)
            {
                kelime = Regex.Split(satir, @"\s");
                tarihBölmek=  kelime[2].Split('.');
                if (int.Parse(tarihBölmek[1]) == ay && int.Parse(tarihBölmek[2]) == yil )
                {
                    istatistikBilgileri.Add(kelime [0]+ "\t" + kelime [1]+ "\t" + kelime [2]);
                }
                else if (int.Parse(tarihBölmek[2]) == yil && aysecimi==false)
                {
                    istatistikBilgileri.Add(kelime[0] + "\t" + kelime[1] + "\t" + kelime[2]);
                }

                satir = dosya.ReadLine();
            }
            dosya.Close();
            fEkle.Close();
            return istatistikBilgileri;
        }


    }
}
