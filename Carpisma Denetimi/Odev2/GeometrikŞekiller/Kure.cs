using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2.GeometrikŞekiller
{
    public class Kure : Sekiller
    {
        private Nokta3d nokta;
        private int yaricap;
        private Color renk; // Renk özelliği eklendi

        public Nokta3d Nokta { get => nokta; set => nokta = value; }

        public int Yaricap { get => yaricap; set => yaricap = value; }
        public Color Renk { get => renk; set => renk = value; } // Renk özelliği eklendi

        public Kure() 
        {
        
            Random random = new Random();
            Nokta = new Nokta3d();
            Yaricap = random.Next(40, 80);
            Renk = Color.Black; // Varsayılan renk atanıyor
        }
        public Kure(Nokta3d nokta, int yaricap, Color renk)// Renk parametresi eklendi
        {
            Nokta= nokta;
            Yaricap= yaricap;
            Renk = renk; // Renk atanıyor
        }

        public string CisimBilgi()
        {
            return $"Merkez noktası Nokta {Nokta.X},{Nokta.Y},{Nokta.Z} ve Yarıçapı {yaricap}";
        }
        
        public void KureCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Renk); // Renk kullanılıyor

            // Kürenin çizileceği dikdörtgenin koordinatları ve boyutu hesaplanıyor
            int dikdortgenX = Nokta.X - Yaricap;
            int dikdortgenY = Nokta.Y - Yaricap;
            int dikdortgenWidth = 2 * Yaricap;
            int dikdortgenHeight = 2 * Yaricap;

            // Kürenin çizilmesi için bir dikdörtgen oluşturuluyor
            Rectangle dikdortgen = new Rectangle(dikdortgenX, dikdortgenY, dikdortgenWidth, dikdortgenHeight);

            // Küreyi çizmek için DrawEllipse yerine DrawEllipse methodunu kullanıyoruz
            graphics.DrawEllipse(pen, dikdortgen);
        }




    }
}
