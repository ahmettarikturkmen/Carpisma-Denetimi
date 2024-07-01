using Odev2.GeometrikŞekiller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Odev2.ÇarpışmaDenetimi
{
    public static class CarpısmaDenetimi
    {
        
        public static bool NoktaDikdortgen(Nokta nokta, Dikdortgen dikdortgen)
        {
            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if (nokta.X >= dikdortgen.Nokta.X + dikdortgen.En &&
                nokta.X <= dikdortgen.Nokta.X + dikdortgen.En &&
                nokta.Y >= dikdortgen.Nokta.Y + dikdortgen.Boy &&
                nokta.Y <= dikdortgen.Nokta.Y + dikdortgen.Boy)
            {
                return true;
            }
            return false;
        }

        public static bool NoktaCember(Nokta nokta, Cember cember)
        {
            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if ((nokta.X - cember.Nokta.X) * (nokta.X - cember.Nokta.X) + (nokta.Y - cember.Nokta.Y) * (nokta.Y - cember.Nokta.Y) <= cember.Yaricap * cember.Yaricap)
            {
                return true;
            }
            return false;
        }

        public static bool DikdortgenDikdortgen(Dikdortgen dikdortgen1, Dikdortgen dikdortgen2)
        {
            // Dikdörtgenlerin köşe noktalarını hesapla
            Nokta solUst1 = dikdortgen1.Nokta;
            Nokta sagAlt1 = new Nokta { X = dikdortgen1.Nokta.X + dikdortgen1.En, Y = dikdortgen1.Nokta.Y + dikdortgen1.Boy };

            Nokta solUst2 = dikdortgen2.Nokta;
            Nokta sagAlt2 = new Nokta { X = dikdortgen2.Nokta.X + dikdortgen2.En, Y = dikdortgen2.Nokta.Y + dikdortgen2.Boy };

            // Dikdörtgenlerin çarpışma durumunu kontrol et
            if (solUst1.X < sagAlt2.X && sagAlt1.X > solUst2.X && solUst1.Y < sagAlt2.Y && sagAlt1.Y > solUst2.Y)
            {
                return true; // Dikdörtgenler çarpışıyor
            }
            return false; // Dikdörtgenler çarpışmıyor
        }

        public static bool DikdortgenCember(Dikdortgen dikdortgen, Cember cember)
        {
            // Dikdörtgenin sınırlarını belirleme
            int dikdortgenSol = dikdortgen.Nokta.X;
            int dikdortgenSag = dikdortgen.Nokta.X + dikdortgen.En;
            int dikdortgenUst = dikdortgen.Nokta.Y;
            int dikdortgenAlt = dikdortgen.Nokta.Y + dikdortgen.Boy;

            // Çemberin merkezi ve yarıçapını belirleme
            int cemberMerkezX = cember.Nokta.X;
            int cemberMerkezY = cember.Nokta.Y;
            int cemberYaricap = cember.Yaricap;

            // Dikdörtgenin içindeki bir noktanın çemberin içinde olup olmadığını kontrol etme
            int enKucukX = Math.Max(dikdortgenSol, Math.Min(cemberMerkezX, dikdortgenSag));
            int enKucukY = Math.Max(dikdortgenUst, Math.Min(cemberMerkezY, dikdortgenAlt));

            double mesafeX = cemberMerkezX - enKucukX;
            double mesafeY = cemberMerkezY - enKucukY;
            double mesafe = Math.Sqrt(mesafeX * mesafeX + mesafeY * mesafeY);

            // Eğer mesafe çemberin yarıçapından küçük veya eşitse, çarpışma var demektir
            return mesafe <= cemberYaricap;
        }

        public static bool CemberCember(Cember cember1, Cember cember2)
        {
            double dx = cember1.Nokta.X - cember2.Nokta.X;
            double dy = cember1.Nokta.Y - cember2.Nokta.Y;
            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if ((dx * dx + dy * dy) <= (cember1.Yaricap + cember2.Yaricap) * (cember1.Yaricap + cember2.Yaricap))
            {
                return true;
            }
            return false;
        }

        public static bool NoktaKure(Nokta3d nokta, Kure kure)
        {
            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            double mesafeKare = Math.Pow(nokta.X - kure.Nokta.X, 2) +
                                Math.Pow(nokta.Y - kure.Nokta.Y, 2) +
                                Math.Pow(nokta.Z - kure.Nokta.Z, 2);

            double kureYaricapKare = Math.Pow(kure.Yaricap, 2);

            return mesafeKare <= kureYaricapKare;
        }

        public static bool NoktaDikdortgenlerPrizması(Nokta3d nokta, DikdortgenPrizması prizma)
        {
            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            double minX = prizma.Nokta.X - (prizma.En / 2);
            double maxX = prizma.Nokta.X + (prizma.En / 2);
            double minY = prizma.Nokta.Y - (prizma.Boy / 2);
            double maxY = prizma.Nokta.Y + (prizma.Boy / 2);
            double minZ = prizma.Nokta.Z - (prizma.Derinlik / 2);
            double maxZ = prizma.Nokta.Z + (prizma.Derinlik / 2);

            return (nokta.X >= minX && nokta.X <= maxX &&
                    nokta.Y >= minY && nokta.Y <= maxY &&
                    nokta.Z >= minZ && nokta.Z <= maxZ);
        }

        public static bool NoktaSilindir(Nokta3d nokta, Silindir silindir)
        {
            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if ((nokta.X <= silindir.Nokta.X + silindir.Yaricap)
             && (nokta.X <= silindir.Nokta.X - silindir.Yaricap)
             && (nokta.Y <= silindir.Nokta.Y + silindir.Yükseklik / 2)
             && (nokta.Y <= silindir.Nokta.Y - silindir.Yükseklik / 2)
             && (nokta.Z <= silindir.Nokta.Z + silindir.Yaricap)
             && (nokta.Z <= silindir.Nokta.Z - silindir.Yaricap))

            {
                return true;
            }
            return false;
        }

        public static bool SilindirSilindir(Silindir silindir1, Silindir silindir2)
        {
            double uzaklık = (silindir1.Nokta.X - silindir2.Nokta.X) * (silindir1.Nokta.X - silindir2.Nokta.X)
                + (silindir1.Nokta.Y - silindir2.Nokta.Y) * (silindir1.Nokta.Y - silindir2.Nokta.Y);

            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if (uzaklık <= (silindir1.Yaricap + silindir2.Yaricap) * (silindir1.Yaricap + silindir2.Yaricap) &&
                (silindir1.Nokta.Z <= silindir2.Nokta.Z + silindir2.Yükseklik) &&
                (silindir1.Nokta.Z + silindir1.Yükseklik >= silindir2.Nokta.Z))
            {
                return true;
            }
            return false;
        }

        public static bool KureKure(Kure kure1, Kure kure2)
        {
            double dx = kure1.Nokta.X - kure2.Nokta.X;
            double dy = kure1.Nokta.Y - kure2.Nokta.Y;
            double dz = kure1.Nokta.Z - kure2.Nokta.Z;
            double mesafeKare = dx * dx + dy * dy + dz * dz; // Tüm koordinatlar kullanılarak mesafe hesaplanıyor
            double toplamYaricapKare = (kure1.Yaricap + kure2.Yaricap) * (kure1.Yaricap + kure2.Yaricap);

            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if (mesafeKare <= toplamYaricapKare)
            {
                return true;
            }
            return false;
        }

        public static bool KureSilindir(Kure kure, Silindir silindir)
        {
            double uzaklık = (double)Math.Sqrt(Math.Pow(kure.Nokta.X - silindir.Nokta.X, 2) + Math.Pow(kure.Nokta.Y - silindir.Nokta.Y, 2));

            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if (uzaklık <= silindir.Yaricap + kure.Yaricap && kure.Nokta.Z >= silindir.Nokta.Z && kure.Nokta.Z <= silindir.Nokta.Z + silindir.Yükseklik)
            {
                return true;
            }
            return false;
        }

        public static bool KureYuzey(Kure kure, Yuzey yuzey)
        {
            double closestX = Math.Max(yuzey.Nokta.X, Math.Min(yuzey.Nokta.X, yuzey.Nokta.X + yuzey.En));
            double closestY = Math.Max(yuzey.Nokta.Y, Math.Min(yuzey.Nokta.Y, yuzey.Nokta.Y + yuzey.Boy));
            double closestZ = Math.Max(yuzey.Nokta.Z, Math.Min(yuzey.Nokta.Z, yuzey.Nokta.Z + yuzey.Derinlik));

            double uzaklık = (double)Math.Sqrt(Math.Pow(kure.Nokta.X - closestX, 2) + Math.Pow(kure.Nokta.Y - closestY, 2) + Math.Pow(kure.Nokta.Z - closestZ, 2));

            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if (uzaklık <= kure.Yaricap)
            {
                return true;
            }
            return false;
        }

        public static bool DikdortgenlerPrizmasıYuzey(Yuzey yuzey, DikdortgenPrizması prizma)
        {
            // Prizmanın köşe noktalarını ve boyutlarını al
            double prizmaX1 = prizma.Nokta.X;
            double prizmaY1 = prizma.Nokta.Y;
            double prizmaZ1 = prizma.Nokta.Z;
            double prizmaX2 = prizmaX1 + prizma.En;
            double prizmaY2 = prizmaY1 + prizma.Boy;
            double prizmaZ2 = prizmaZ1 + prizma.Derinlik;

            // Yüzeyin sınırlarını belirle
            double yuzeyX1 = yuzey.Nokta.X;
            double yuzeyY1 = yuzey.Nokta.Y;
            double yuzeyZ1 = yuzey.Nokta.Z;
            double yuzeyX2 = yuzeyX1 + yuzey.En;
            double yuzeyY2 = yuzeyY1 + yuzey.Boy;
            double yuzeyZ2 = yuzeyZ1 + yuzey.Derinlik;

            // Prizma ve yüzey arasındaki çarpışmayı kontrol et
            bool xCarpisti = prizmaX1 <= yuzeyX2 && prizmaX2 >= yuzeyX1;
            bool yCarpisti = prizmaY1 <= yuzeyY2 && prizmaY2 >= yuzeyY1;
            bool zCarpisti = prizmaZ1 <= yuzeyZ2 && prizmaZ2 >= yuzeyZ1;

            return xCarpisti && yCarpisti && zCarpisti;
        }

        public static bool SilindirYuzey(Silindir silindir, Yuzey yuzey)
        {
            double closestX = Math.Max(yuzey.Nokta.X, Math.Min(silindir.Nokta.X, yuzey.Nokta.X + yuzey.En));
            double closestY = Math.Max(yuzey.Nokta.Y, Math.Min(silindir.Nokta.Y, yuzey.Nokta.Y + yuzey.Boy));
            double closestZ = Math.Max(yuzey.Nokta.Z, Math.Min(silindir.Nokta.Z, yuzey.Nokta.Z + yuzey.Derinlik));

            double uzaklık = (double)Math.Sqrt(Math.Pow(silindir.Nokta.X - closestX, 2) + Math.Pow(silindir.Nokta.Y - closestY, 2));

            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if (uzaklık <= silindir.Yaricap && closestZ <= silindir.Nokta.Z + silindir.Yükseklik && closestZ >= silindir.Nokta.Z)
            {
                return true;
            }
            return false;
        }

        public static bool DikdortgenPrizmasiKure(DikdortgenPrizması prizma, Kure kure)
        {
            // Prizmanın köşe noktalarını ve boyutlarını al
            double prizmaX1 = prizma.Nokta.X;
            double prizmaY1 = prizma.Nokta.Y;
            double prizmaZ1 = prizma.Nokta.Z;
            double prizmaX2 = prizmaX1 + prizma.En;
            double prizmaY2 = prizmaY1 + prizma.Boy;
            double prizmaZ2 = prizmaZ1 + prizma.Derinlik;

            // Kürenin merkez noktasını ve yarıçapını al
            double kureMerkezX = kure.Nokta.X;
            double kureMerkezY = kure.Nokta.Y;
            double kureMerkezZ = kure.Nokta.Z;
            double kureYaricap = kure.Yaricap;

            // En yakın noktayı bul
            double closestX = Math.Max(prizmaX1, Math.Min(kureMerkezX, prizmaX2));
            double closestY = Math.Max(prizmaY1, Math.Min(kureMerkezY, prizmaY2));
            double closestZ = Math.Max(prizmaZ1, Math.Min(kureMerkezZ, prizmaZ2));

            // Kürenin merkezi ile en yakın nokta arasındaki mesafeyi hesapla
            double distanceX = kureMerkezX - closestX;
            double distanceY = kureMerkezY - closestY;
            double distanceZ = kureMerkezZ - closestZ;
            double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);

            // Eğer mesafe kürenin yarıçapından küçük veya eşitse, çarpışma var
            if (distance <= kureYaricap)
            {
                return true;
            }
            return false;
        }

        public static bool DikdortgenprizmasiDikdortgenprizmasi(DikdortgenPrizması prizma1, DikdortgenPrizması prizma2)
        {
            //Çizilen cisimlerin çarpışıp çarpışmadığını denetler 
            if (prizma1.Nokta.X <= prizma2.Nokta.X + prizma2.Boy && 
                prizma1.Nokta.X + prizma1.Boy >= prizma2.Nokta.X &&
                prizma1.Nokta.Y <= prizma2.Nokta.Y + prizma2.En && 
                prizma1.Nokta.Y + prizma1.En >= prizma2.Nokta.Y && 
                prizma1.Nokta.Z <= prizma2.Nokta.Z + prizma2.Derinlik && 
                prizma1.Nokta.Z + prizma1.Derinlik >= prizma2.Nokta.Z)
            {  return true; }   

            return false;
        }
    }          
}
