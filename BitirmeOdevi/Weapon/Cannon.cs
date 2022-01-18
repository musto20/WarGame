using TechCareerWarGame.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{
    internal class Cannon : Guns
    {
        public Cannon(string marka, string model, int hasar, int magazineCapacity, AmmoType ammo, int atisSayisi, bool scope) : base(marka, model, hasar, magazineCapacity, ammo, atisSayisi, scope)
        {
        }

        public override void Saldir()
        {
            MagazineCapacity -= AtisSayisi;
            if (MagazineCapacity<=0)
            {
                saldirabilir=false;
            }
        }
    }
}
