using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{

    public class DikdortgenPrizması : Sekiller
    {
        private Nokta3d nokta;
        private int en;
        private int boy;
        private int derinlik;
        private Color renk; // Renk özelliği eklendi

        public Nokta3d Nokta { get => nokta; set => nokta = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        public int Derinlik { get => derinlik; set => derinlik = value; }
        public Color Renk { get => renk; set => renk = value; } // Renk özelliği eklendi

        public DikdortgenPrizması()
        {
            Random random = new Random();
            Nokta = new Nokta3d();
            En = random.Next(30, 90);
            Boy = random.Next(30, 90);
            Derinlik = random.Next(30, 90);
            Renk = Color.DarkSlateGray; // Varsayılan renk atanıyor
        }

        public DikdortgenPrizması(Nokta3d nokta, int en, int boy, int derinlik, Color renk) // Renk parametresi eklendi
        {
            Nokta = nokta;
            En = en;
            Boy = boy;
            Derinlik = derinlik;
            Renk = renk; // Renk atanıyor
        }

        public string CisimBilgi()
        {
            return $"Başlangıç noktası Nokta (x,y,z) = {Nokta.X},{Nokta.Y},{Nokta.Z}, eni {en}, boyu {boy} ve derinliği {derinlik}";
        }

        public void PrizmaCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Renk); // Renk kullanılıyor

            // Alt yüzey
            graphics.DrawRectangle(pen, Nokta.X, Nokta.Y, Boy, En);

            // Üst yüzey
            graphics.DrawRectangle(pen, Nokta.X + Derinlik, Nokta.Y + Derinlik, Boy, En);

            // Yan yüzeyler
            graphics.DrawLine(pen, Nokta.X, Nokta.Y, Nokta.X + Derinlik, Nokta.Y + Derinlik);
            graphics.DrawLine(pen, Nokta.X + Boy, Nokta.Y, Nokta.X + Boy + Derinlik, Nokta.Y + Derinlik);
            graphics.DrawLine(pen, Nokta.X, Nokta.Y + En, Nokta.X + Derinlik, Nokta.Y + Derinlik + En);
            graphics.DrawLine(pen, Nokta.X + Boy, Nokta.Y + En, Nokta.X + Boy + Derinlik, Nokta.Y + Derinlik + En);
        }
    }
}
