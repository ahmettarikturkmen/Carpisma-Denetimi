using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{
    public class Dikdortgen:Sekiller
    {
        private Nokta nokta;
        private int en;
        private int boy;
        private Color renk; // Renk özelliği eklendi

        public Nokta Nokta { get=> nokta; set => nokta = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        public Color Renk { get => renk; set => renk = value; } // Renk özelliği eklendi

        public Dikdortgen()
        {
            Random random = new Random(); 
            Nokta = new Nokta();
            En = random.Next(20, 100);
            Boy = random.Next(20, 100);
            Renk = Color.DarkSlateGray; // Varsayılan renk atanıyor
        }
       
        public Dikdortgen(Nokta nokta, int en, int boy, Color renk)
        {
            Nokta = nokta;
            En = en;
            Boy = boy;
            Renk = renk; // Renk atanıyor
        }

        public string CisimBilgi()
        {
            return $"Başlangıç noktası (x,y) = {Nokta.X},{Nokta.Y}, eni {en} ve boyu {boy}";
        }
        public void DikdortgenCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Renk); // Renk kullanılıyor
            graphics.DrawRectangle(pen, Nokta.X, Nokta.Y, en, boy);
        }
    }
}
