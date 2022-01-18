using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{
    internal class Cephanelik
    {
        public List<Weapons> silahlar;
        public Cephanelik()
        {
            silahlar = new List<Weapons>();
            silahlar.Add(new Knive("Rambo", "K500",5,false));
            silahlar.Add(new Knive("Rambo", "K700", 8,false));
            silahlar.Add(new Bayonet("KST", "K100", 8,false));
            silahlar.Add(new Pistol("Altıpatlar", "A300",8,6,Weapon.AmmoType.Cekirdekli,1,false));
            silahlar.Add(new Pistol("Su", "S1000", 8,15,Weapon.AmmoType.Cekirdekli,1,false));
            silahlar.Add(new Shotgun("Poz", "K500", 15,5,Weapon.AmmoType.Sacma,1,true));
            silahlar.Add(new Rifle("Tara", "T600", 10, 50, Weapon.AmmoType.Sacma, 5, true));
            silahlar.Add(new RocketLauncher("Rot", "R100", 40, 1, Weapon.AmmoType.Sacma, 1, true));
            silahlar.Add(new Cannon("Guny", "G200", 30, 1, Weapon.AmmoType.Sacma, 1, false));

        }
        public void SilahlariGoster()
        {
            int i = 1;
            foreach (Weapons item in silahlar)
            {
                Console.WriteLine($"{i}. {item.Marka} Marka {item.Model} Model {item.Hasar} Hasarlı {item.GetType()}");
                i++;
            }
        }
        public Weapons this[int index]
        {
            get
            { 
                return silahlar[index];
            }
        }
    }
}
