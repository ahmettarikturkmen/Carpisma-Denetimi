using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{
    public class Nokta : Sekiller
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }

        public int Y { get => y; set => y = value; }

        public Nokta()
        {
            Random random = new Random();
            X = random.Next(50, 200);
            Y = random.Next(50, 200);
        }

        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string CisimBilgi()
        {
            return $"Kordinat sisteminde (x,y) = ({x},{y})";
        }
        public void NoktaCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawEllipse(pen, X, Y, 1, 1);//nokta aslında yarıçapı 1 olan çok küçük elips
        }
    }
}
