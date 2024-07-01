using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{
    public class Nokta3d : Sekiller
    {
        private int x;
        private int y;
        private int z;

        public int X { get => x; set => x = value; }

        public int Y { get => y; set => y = value; }

        public int Z { get => z; set => z = value; }

        public Nokta3d()
        {
            Random random = new Random();
            X = random.Next(50, 200);
            Y = random.Next(50, 200);
            Z = random.Next(50, 100);
        }

        public Nokta3d(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public string CisimBilgi()
        {
            return $"Kordinat sisteminde (x,y,z) = ({x},{y},{z})";
        }
        public void NoktaCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawEllipse(pen, X, Y, 1, 1);//nokta aslında yarıçapı 1 olan çok küçük elips
        }
    }
}
