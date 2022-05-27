using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace veri_yapilari_odev_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private Yigin[] yigindizisi=new Yigin[11]; // Yığın dizisi bütün yığınları tutuyor.Her yığında bir cümle tutulacak. Her cümle ise Kelime classlarından oluşacak.

        // Okunacak olan metin dosyasını seçmemize ve metin hakkındaki bilgileri listboxa yazdırmamıza yarayan fonksiyon
        private void btnmetinyukle_Click(object sender, EventArgs e)
        {
            string dosyaYolu = String.Empty;
            string dosyaUzantisi = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = openFileDialog.FileName;
                dosyaUzantisi = Path.GetExtension(dosyaYolu);
                if (dosyaUzantisi.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(dosyaYolu);
                        StringBuilder builder = new StringBuilder();
                        string line = "";

                        while ((line = reader.ReadLine()) != null)
                        {
                            builder.AppendLine(line);
                        }
                        reader.Close();
                        duzenlenecek_metin_rchtxtb.Text = builder.ToString();
                        txtdosyayolu.Text = dosyaYolu;

                        int cumle_sayisi_sayaci = 0, kelime_sayisi_sayaci = 0, ort_kelime_sayisi;
                        string yazi = duzenlenecek_metin_rchtxtb.Text;
                        string[] cumlelerim = yazi.Split('\n');
                        foreach (string cumle in cumlelerim)
                        {
                            cumle_sayisi_sayaci += 1;
                            string[] kelimeler = cumle.Split(' ');
                            foreach (string kelime in kelimeler)
                            {
                                kelime_sayisi_sayaci += 1;
                            }

                        }
                        ort_kelime_sayisi = (kelime_sayisi_sayaci-1) / (cumle_sayisi_sayaci-1);
                        dosya_bilgileri_listbox.Items.Add("Metindeki toplam cümle sayısı: " + (cumle_sayisi_sayaci-1));
                        dosya_bilgileri_listbox.Items.Add("Metindeki toplam kelime sayısı: " + (kelime_sayisi_sayaci-1));
                        dosya_bilgileri_listbox.Items.Add("Cümlelerdeki ortalama kelime sayısı: " + (ort_kelime_sayisi));
                    }
                    catch (Exception exception)
                    {
                        throw new Exception("Dosya açılamadı.");
                    }
                }
            }
        }
        
        // İslenmis kelimelerin bulunduğu temiz metin ve frekansı bulunacak kelimeyi parametre olarak alan fonksiyon. Kelimenin metinde her geçişi için sayacı 1 arttırıyor.
        public int FrekansHesapla(string word,string metin)
        {
            string kocaman_metin = metin;
            string frekansına_bakilacak_kelime = word;
            int frekans_sayaci = 0;

            foreach (string kelime in kocaman_metin.Split(' '))
            {
                if (kelime == frekansına_bakilacak_kelime)
                {
                    frekans_sayaci++;
                }
            }
            return frekans_sayaci;

        }


        // Tırnak işareti içeren kelimeler için tırnak işareti ve sonrasını atan fonksiyon. Örneğin Ensar'ın -> Ensar
        public static string TirnakIsaretindenSonrasiniAt(string text, string stopAt = "'")
        {
            int karakterin_indisi = text.IndexOf(stopAt, StringComparison.Ordinal);

            if (karakterin_indisi > 0)
            {
                return text.Substring(0, karakterin_indisi);
            }


            return text;
        }


        // Bütün metni ön işleyen fonksiyon
        public static string MetniOnIsleme(string butunmetin)
        {
            string[] cumleler = butunmetin.Split('\n');
            string hazir_metin="";
            foreach(string cumlem in cumleler)
            {
                foreach(string kelimem in cumlem.Split(' '))
                {    
                    string islenenkelime = TirnakIsaretindenSonrasiniAt(kelimem);
                    islenenkelime = islenenkelime.ToLower();
                    islenenkelime = Regex.Replace(islenenkelime, @"[^\w\d\s]", "");
                    hazir_metin += islenenkelime + " ";
                }
            }
            return hazir_metin;
        }

        // Her kelime için bir class oluşturup kelime hakkındaki 5 ayrı bilgiyi hazırlayan, sonra da bu kelimeleri stacke pushlayan, en son da cümleleri yigindizisine atan bir fonksiyon
        public void btnstackeoku_Click(object sender, EventArgs e)
        {
            
            int yigin_dizisi_indisi = 0;
            string metin = duzenlenecek_metin_rchtxtb.Text;
            string duzenlenmis_metin = MetniOnIsleme(metin);
           
            string[] cumleler = metin.Split('\n');
            int cumle_sayaci = 1, kelime_sayaci = 1;

            foreach (string cumle in cumleler)
            {
                Yigin yigin = new Yigin();
                kelime_sayaci = 1;
                foreach (string kelime in cumle.Split(' '))
                {

                    Kelime klm = new Kelime();

                    klm.orijinal_bicim = kelime;

                    string islenmis = klm.orijinal_bicim.ToLower();
                    islenmis = TirnakIsaretindenSonrasiniAt(islenmis);
                    islenmis = Regex.Replace(islenmis, @"[^\w\d\s]", "");
                    klm.islenmis_bicim = islenmis;

                    klm.kacinci_cumlede = cumle_sayaci;
                    klm.cumle_icinde_kacinci = kelime_sayaci;

                    klm.frekans = FrekansHesapla(islenmis, duzenlenmis_metin);

                    yigin.Push(klm);
                    

                    kelime_sayaci++;
                }
                cumle_sayaci++;

                
                
                yigindizisi[yigin_dizisi_indisi] = yigin;
                yigin_dizisi_indisi++;
                cumle_sayaci++;
            }

           

        }

        Heap agac = new Heap(75);
        ArrayList agaca_giren_kelimeler = new ArrayList();
        public void btnagacaaktar_Click(object sender, EventArgs e)
        {
           
            int i = 0;
            foreach (Yigin yigin in yigindizisi)
            {

                while (yigindizisi[i].elemansayisi>0)
                {
                    
                    Kelime agaca_gidecek_kelime = yigindizisi[i].Pop();
                   
                    bool kelime_daha_once_var_miymis = agaca_giren_kelimeler.Contains(agaca_gidecek_kelime.islenmis_bicim);
                    agaca_giren_kelimeler.Add(agaca_gidecek_kelime.islenmis_bicim);
                    if (kelime_daha_once_var_miymis == false)
                    {
                        agac.Insert(agaca_gidecek_kelime);
                    }
                }
                i++;
            }
            

        }

        public Heap HeapSort(Heap heapım)
        {
            Heap h = new Heap(heapım.simdikiboyut);
            
            foreach (var item in heapım.heapdizisi)
            {
                h.Insert(item.kelime);
            }
            int i = 0;
            while (!h.IsEmpty())
            {
                heapım.heapdizisi[i++].kelime = h.RemoveMax().kelime;
            }
            return heapım;
        }

        // Ağacı heap sort algoritması ile sıralayıp sonra da frekansı en yüksek olan "n" kelimeyi form kontrolüne yazan fonksiyon. (n kullanıcı tarafından formda input olarak girilecek.)
        private void btn_ensık_kullanılan_kelimeler_Click(object sender, EventArgs e)
        {
            Heap agacim = agac;
            Heap siralanmis_agac = HeapSort(agacim);
            for (int i = 0; i < Int32.Parse(txt_en_sik_kac_kelime.Text); i++)
            {
                listbox_ensikkelimeler.Items.Add(siralanmis_agac.heapdizisi[i].kelime.islenmis_bicim + " -> " + siralanmis_agac.heapdizisi[i].kelime.frekans + " kez geçiyor");

            }

        }

        // Bütün kelimelerin frekanslarını hash tablosuna dolduran fonksiyon
        private void btnHashTabloOlustur_Click(object sender, EventArgs e)
        {
            HashMap hashtablom = new HashMap(75);
            for (int i = 0; i < agac.simdikiboyut-1; i++) 
            {
                hashtablom.TabloyaEkle(agac.heapdizisi[i].kelime.frekans);
            }
            
        }
    }
}
