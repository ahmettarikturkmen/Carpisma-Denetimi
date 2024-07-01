using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{
    public class Cember : Sekiller
    {
        private Nokta nokta;
        private int yaricap;
        private Color renk; // Renk özelliği eklendi

        public Nokta Nokta { get => nokta; set => nokta = value; }

        public int Yaricap { get => yaricap; set => yaricap = value; }
        public Color Renk { get => renk; set => renk = value; } // Renk özelliği eklendi

        public Cember()
        {

            Random random = new Random();
            Nokta = new Nokta();
            Yaricap = random.Next(20, 60);
            Renk = Color.Black; // Varsayılan renk atanıyor
        }
        public Cember(Nokta nokta, int yaricap, Color renk)// Renk parametresi eklendi
        {
            Nokta = nokta;
            Yaricap = yaricap;
            Renk = renk; // Renk atanıyor
        }

        public string CisimBilgi()
        {
            return $"Yarıçapı {Yaricap} ve merkez noktası (x,y) = ({Nokta.X},{Nokta.Y})";
        }

        public void CemberCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Renk); // Renk kullanılıyor

            // Elipsin koordinatları ve boyutu hesaplanıyor
            int x = Nokta.X - Yaricap;
            int y = Nokta.Y - Yaricap;
            int width = 2 * Yaricap;
            int height = 2 * Yaricap;

            graphics.DrawEllipse(pen, x, y, width, height);
        }
    }
}
