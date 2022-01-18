using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame.Weapon
{
    enum AmmoType
    {
        Cekirdekli,
        Sacma,
        Rocket,
        Top
    }
    internal abstract class Guns:Weapons
    {
       
        protected Guns(string marka, string model, int hasar,int magazineCapacity,AmmoType ammo,int atisSayisi, bool scope) : base(marka, model, hasar,scope)
        {
            MagazineCapacity = magazineCapacity;
            Ammo = ammo;
            AtisSayisi= atisSayisi;
        }

        public void Yakinlastir()
        {
            if (Scope==true)
            {
                Console.WriteLine("Dürbün açıldı");
            }
            else
            {
                Console.WriteLine("Bu özellik bulunmamaktadır");
            }
        }
        public int AtisSayisi { get; set; }
        public int MagazineCapacity { get; set; }
        public AmmoType Ammo { get; set; }

        
    }
}
