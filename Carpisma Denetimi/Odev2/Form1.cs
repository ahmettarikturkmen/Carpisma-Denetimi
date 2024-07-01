/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**				
**	
**				ÖDEV NUMARASI..........:2.Ödev
**				ÖĞRENCİ ADI............:Ahmet Tarık Türkmen
**				ÖĞRENCİ NUMARASI.......:G221210087
**              DERSİN ALINDIĞI GRUP...:2.Öğretim C Grubu
****************************************************************************/

using Odev2.ÇarpışmaDenetimi;
using Odev2.GeometrikŞekiller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Odev2
{
    public partial class CarpismaDenetimi : Form
    {
        public CarpismaDenetimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxBilgi.Clear();
            Nokta nokta = new Nokta();
            Nokta3d nokta3d = new Nokta3d();
            Thread.Sleep(150);
            Dikdortgen dikdortgen = new Dikdortgen();
            Dikdortgen dikdortgen1 = new Dikdortgen();
            // Dikdörtgen için 0,3 saniye sonra oluşturulması için gecikme ekleniyor üst üste oluşmaması için
            Thread.Sleep(150); // 300 milisaniye (0,3 saniye) gecikme
            Random random6 = new Random();
            int En = random6.Next(20, 100); // 1 ile 100 arasında rastgele bir sayı 
            int Boy = random6.Next(20, 100); // 1 ile 100 arasında rastgele bir sayı 
            Dikdortgen dikdortgen2 = new Dikdortgen(new Nokta(), En, Boy, Color.Red);

            Cember cember = new Cember();           
            Cember cember1 = new Cember();
            
            Thread.Sleep(150); 
            Random random4 = new Random();
            int yaricapcember = random4.Next(20, 60); 
            Cember cember2 = new Cember(new Nokta(), yaricapcember, Color.Red);

            
            DikdortgenPrizması Prizma = new DikdortgenPrizması(); 
            DikdortgenPrizması Prizma1 = new DikdortgenPrizması();
             
            Thread.Sleep(150); 
            Random random = new Random();
            int en = random.Next(30, 90); 
            int boy = random.Next(30, 90);  
            int derinlik = random.Next(30, 90); 
            DikdortgenPrizması Prizma2 = new DikdortgenPrizması(new Nokta3d(), en, boy, derinlik, Color.Red); 

            Kure kure = new Kure();
            Kure kure1 = new Kure();
            
            Thread.Sleep(150); 
            Random random5 = new Random();
            int yaricapkure = random5.Next(40,80);  
            Kure kure2 = new Kure(new Nokta3d(), yaricapkure, Color.Red);

            Silindir silindir = new Silindir();
            Silindir silindir1 = new Silindir();
            Thread.Sleep(150); 
            Random random2 = new Random();
            int yaricap = random.Next(15, 70); 
            int yükseklik = random.Next(30, 70); 
            Silindir silindir2 = new Silindir(new Nokta3d(), yaricap, yükseklik,Color.Red);

            Yuzey yuzey = new Yuzey();
            
            
            //seçenek 1 seçilirse Nokta Dikdörtgen cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 1)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();
                
                if (CarpısmaDenetimi.NoktaDikdortgen(nokta,dikdortgen))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Dikdörtgen={dikdortgen.CisimBilgi()}\nNokta={nokta.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Dikdörtgen={dikdortgen.CisimBilgi()}\nNokta={nokta.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla
         
                nokta.NoktaCiz(panel1);
                dikdortgen.DikdortgenCiz(panel1);
            }
            //seçenek 2 seçilirse Nokta Çember cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 2)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.NoktaCember(nokta, cember))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Çember={cember.CisimBilgi()}\nNokta={nokta.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Çember={cember.CisimBilgi()}\nNokta={nokta.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla
               
                nokta.NoktaCiz(panel1);
                cember.CemberCiz(panel1);
            }
            
            //seçenek 3 seçilirse Dikdortgen Dikdortgen cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 3)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.DikdortgenDikdortgen(dikdortgen1, dikdortgen2))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Dikdörtgen1={dikdortgen1.CisimBilgi()}\nDikdörtgen2={dikdortgen2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Dikdörtgen1={dikdortgen1.CisimBilgi()}\nDikdörtgen2={dikdortgen2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                dikdortgen1.DikdortgenCiz(panel1);
                dikdortgen2.DikdortgenCiz(panel1);
            }

            //seçenek 4 seçilirse Dikdortgen Cember cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 4)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.DikdortgenCember(dikdortgen, cember))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Dikdörtgen={dikdortgen.CisimBilgi()}\nÇember={cember.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Dikdörtgen={dikdortgen.CisimBilgi()}\nÇember={cember.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                dikdortgen.DikdortgenCiz(panel1);
                cember.CemberCiz(panel1);              
            }

            //seçenek 5 seçilirse Cember Cember cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 5)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.CemberCember(cember1, cember2))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Çember1={cember1.CisimBilgi()}\nÇember2={cember2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Çember1={cember1.CisimBilgi()}\nÇember2={cember2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                cember1.CemberCiz(panel1);
                cember2.CemberCiz(panel1);
            }

            //seçenek 6 seçilirse Nokta Kure cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 6)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.NoktaKure(nokta3d, kure))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Nokta={nokta3d.CisimBilgi()}\nKüre={kure.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Nokta={nokta3d.CisimBilgi()}\nKüre={kure.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                nokta3d.NoktaCiz(panel1);
                kure.KureCiz(panel1);
            }

            //seçenek 7 seçilirse Nokta DikdortgenlerPrizması cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 7)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.NoktaDikdortgenlerPrizması(nokta3d, Prizma))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Nokta={nokta3d.CisimBilgi()}\nPrizma={Prizma.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Nokta={nokta3d.CisimBilgi()}\nPrizma={Prizma.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                Nokta3d nokta3d3 = new Nokta3d();
                nokta3d3.NoktaCiz(panel1);
                Prizma.PrizmaCiz(panel1);
            }

            //seçenek 8 seçilirse Nokta Silindir cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 8)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.NoktaSilindir(nokta3d, silindir))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Silindir={silindir.CisimBilgi()}\nNokta={nokta3d.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Silindir={silindir.CisimBilgi()}\nNokta={nokta3d.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                nokta3d.NoktaCiz(panel1);
                silindir.SilindirCiz(panel1);
            }

            //seçenek 9 seçilirse Silindir Silindir cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 9)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.SilindirSilindir(silindir1, silindir2))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Silindir1={silindir1.CisimBilgi()}\nSilindir2={silindir2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Silindir1={silindir1.CisimBilgi()}\nSilindir2={silindir2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                silindir1.SilindirCiz(panel1);
                silindir2.SilindirCiz(panel1);
            }

            //seçenek 10 seçilirse Kure Kure cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 10)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.KureKure(kure1, kure2))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Küre1={kure1.CisimBilgi()}\nKüre2={kure2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Küre1={kure1.CisimBilgi()}\nKüre2={kure2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla 

                kure1.KureCiz(panel1);
                kure2.KureCiz(panel1);
            }

            //seçenek 11 seçilirse Kure Silindir cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 11)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.KureSilindir(kure, silindir))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Küre={kure.CisimBilgi()}\nSilindir={silindir.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Küre={kure.CisimBilgi()}\nSilindir={silindir.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                kure.KureCiz(panel1);
                silindir.SilindirCiz(panel1);
            }

            //seçenek 12 seçilirse Kure Yuzey cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 12)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.KureYuzey(kure, yuzey))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Küre={kure.CisimBilgi()}\nYüzey={yuzey.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Küre={kure.CisimBilgi()}\nYüzey={yuzey.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                kure.KureCiz(panel1);
                yuzey.YuzeyCiz(panel1);
            }

            //seçenek 13 seçilirse DikdortgenlerPrizması Yuzey cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 13)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.DikdortgenlerPrizmasıYuzey(yuzey, Prizma))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Yüzey={yuzey.CisimBilgi()}\nPrizma={Prizma.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Yüzey={yuzey.CisimBilgi()}\nPrizma={Prizma.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                yuzey.YuzeyCiz(panel1);
                Prizma2.PrizmaCiz(panel1);
            }

            //seçenek 14 seçilirse Silindir Yuzey cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 14)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.SilindirYuzey(silindir, yuzey))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Silindir={silindir.CisimBilgi()}\nYüzey={yuzey.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Silindi={silindir.CisimBilgi()}\nYüzey={yuzey.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                silindir.SilindirCiz(panel1);
                yuzey.YuzeyCiz(panel1);
            }

            //seçenek 15 seçilirse DikdortgenPrizmasi Kure cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 15)
            {  
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.DikdortgenPrizmasiKure(Prizma, kure))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Prizma={Prizma.CisimBilgi()}\nKüre={kure.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Prizma={Prizma.CisimBilgi()}\nKüre={kure.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                kure.KureCiz(panel1);
                Prizma.PrizmaCiz(panel1);
            }

            //seçenek 16 seçilirse Dikdortgenprizmasi Dikdortgenprizmasi cisimleri panel1'e çizilir, cisimlerin bilgileri ve çarpışma denetimi sonucu richtextbox'a yazılır.
            if (secenek == 16)
            {
                // Önceki çizimleri temizler
                panel1.Controls.Clear();
                panel1.Invalidate();
                panel1.Refresh();

                //Çarpışma Denetimi sonucu çarpışıyor ise yeşil renkte yazılır.
                if (CarpısmaDenetimi.DikdortgenprizmasiDikdortgenprizmasi(Prizma1, Prizma2))
                {
                    richTextBoxBilgi.SelectionColor = Color.Green; // Yeşil renk
                    richTextBoxBilgi.AppendText($"Prizma1={Prizma1.CisimBilgi()}\nPrizma2={Prizma2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞIYOR");
                }
                //Çarpışma Denetimi sonucu çarpışmıyor ise kırmızı renkte yazılır.
                else
                {
                    richTextBoxBilgi.SelectionColor = Color.Red; // Kırmızı renk
                    richTextBoxBilgi.AppendText($"Prizma1={Prizma1.CisimBilgi()}\nPrizma2={Prizma2.CisimBilgi()}\n\nCİSİMLER ÇARPIŞMIYOR");
                }
                richTextBoxBilgi.SelectionColor = richTextBoxBilgi.ForeColor; // Renkleri sıfırla

                Prizma1.PrizmaCiz(panel1);
                Prizma2.PrizmaCiz(panel1);
            }
        }

        private void UpdateCheckboxState(CheckBox clickedCheckbox)
        {   
            //ceheckbox'ın sadece bir kere işaretlenmesi için her seferinde chexkbox ı kontrol eder
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox && checkBox != clickedCheckbox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        int secenek=0;
        private void NoktaDortgen_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 1;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void NoktaCember_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 2;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void DikdortgenDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 3;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void DikdortgenCember_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 4;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void CemberCember_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 5;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void NoktaKure_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 6;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void NoktaDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 7;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void NoktaSilindir_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 8;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void SilindirSilindir_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 9;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void KureKure_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 10;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void KureSilindir_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 11;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void YüzeyKure_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 12;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void YüzeyDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 13;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void YuzeySilindir_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 14;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void KureDikdortgenPrizması_CheckedChanged(object sender, EventArgs e)
        {
            secenek =15;
            UpdateCheckboxState((CheckBox)sender);
        }

        private void DikdortgenPrizmasıDikdortgenPrizması_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 16;
            UpdateCheckboxState((CheckBox)sender);
        }       
    }
}
