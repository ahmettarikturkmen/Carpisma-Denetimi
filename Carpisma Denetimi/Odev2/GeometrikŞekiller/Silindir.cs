using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{

    public class Silindir : Sekiller
    {
        private Nokta3d nokta;
        private int yaricap;
        private int yükseklik;
        private Color renk; // Renk özelliği eklendi

        public Nokta3d Nokta { get => nokta; set => nokta = value; }
        public int Yaricap { get => yaricap; set => yaricap = value; }
        public int Yükseklik { get => yükseklik; set => yükseklik = value; }
        public Color Renk { get => renk; set => renk = value; } // Renk özelliği eklendi

        public Silindir()
        {
            Random random = new Random();
            Nokta = new Nokta3d();
            Yaricap = random.Next(15, 70);
            Yükseklik = random.Next(30, 70);
            Renk = Color.Black; // Varsayılan renk atanıyor
        }

        public Silindir(Nokta3d nokta, int yaricap, int yükseklik, Color renk) // Renk parametresi eklendi
        {
            Nokta = nokta;
            Yaricap = yaricap;
            Yükseklik = yükseklik;
            Renk = renk; // Renk atanıyor
        }

        public string CisimBilgi()
        {
            return $"Tabanın merkez noktası Nokta (x,y,z) = ({Nokta.X},{Nokta.Y},{Nokta.Z}), Yarıçapı {Yaricap} ve yüksekliği {Yükseklik}";
        }

        public void SilindirCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Renk); // Renk kullanılıyor

            // Tabanı çiz
            graphics.DrawEllipse(pen, Nokta.X - Yaricap, Nokta.Y - Yaricap, 2 * Yaricap, 2 * Yaricap);

            // Üst yüzeyi çiz
            graphics.DrawEllipse(pen, Nokta.X - Yaricap, Nokta.Y + Yükseklik - Yaricap, 2 * Yaricap, 2 * Yaricap);

            // Yan yüzeyleri çiz
            graphics.DrawLine(pen, Nokta.X - Yaricap, Nokta.Y, Nokta.X - Yaricap, Nokta.Y + Yükseklik);
            graphics.DrawLine(pen, Nokta.X + Yaricap, Nokta.Y, Nokta.X + Yaricap, Nokta.Y + Yükseklik);
            graphics.DrawLine(pen, Nokta.X - Yaricap, Nokta.Y, Nokta.X - Yaricap, Nokta.Y + Yükseklik);
            graphics.DrawLine(pen, Nokta.X + Yaricap, Nokta.Y, Nokta.X + Yaricap, Nokta.Y + Yükseklik);
        }
    }

}
