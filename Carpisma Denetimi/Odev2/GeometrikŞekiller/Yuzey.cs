using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{
    public class Yuzey : Sekiller
    {
        private Nokta3d nokta;
        private int en;
        private int boy;
        private int derinlik;

        public Nokta3d Nokta { get => nokta; set => nokta = value; }

        public int En { get => en; set => en = value; }

        public int Boy { get => boy; set => boy = value; }

        public int Derinlik { get => derinlik; set => derinlik = value; }

        public Yuzey()
        {
            Random random = new Random();
            Nokta = new Nokta3d();
            En = random.Next(40, 100);
            Boy = 1;    
            Derinlik = random.Next(40, 100);
        }

        public Yuzey(Nokta3d nokta, int en, int boy, int derinlik)
        {
            Nokta = nokta;
            En = en;
            Boy = boy;
            Derinlik = derinlik;
        }

        public string CisimBilgi()
        {
            return $"Başlangıç noktası Nokta (x,y,z) = ({Nokta.X},{Nokta.Y},{Nokta.Z}), eni {en} ve boyu {boy}";
        }

        public void YuzeyCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.DarkSlateGray);

            // Paralelkenarın köşe noktalarını hesapla
            Point nokta1 = new Point(Nokta.X, Nokta.Y);
            Point nokta2 = new Point(Nokta.X + En, Nokta.Y);
            Point nokta3 = new Point(Nokta.X + En + Derinlik, Nokta.Y + Derinlik);
            Point nokta4 = new Point(Nokta.X + Derinlik, Nokta.Y + Derinlik);

            // Paralelkenarı çiz
            graphics.DrawLine(pen, nokta1, nokta2);
            graphics.DrawLine(pen, nokta2, nokta3);
            graphics.DrawLine(pen, nokta3, nokta4);
            graphics.DrawLine(pen, nokta4, nokta1);

            // Köşegenleri çiz
            graphics.DrawLine(pen, nokta1, nokta3);
            graphics.DrawLine(pen, nokta2, nokta4);
        }

    }
}
    