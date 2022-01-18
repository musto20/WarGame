using TechCareerWarGame.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{
    internal class Player
    { 
        int silahsayi=0;
        Cephanelik cephanelik=new Cephanelik();
        public int PlayerHealth { get; set; } = 100;
        public string Name { get; set; }
        public List<Weapons> PlayerSilahlar = new List<Weapons>();
        public int EldekiSilah=0;

        public bool SilahEkle(int sayi)
        {
            if (silahsayi < 3)
            {
                if (PlayerSilahlar.Contains(cephanelik.silahlar[sayi]))
                {
                    Console.WriteLine("Farkli bir silah alin");
                    return false;
                }
                PlayerSilahlar.Add(cephanelik.silahlar[sayi]);
                silahsayi++;
            }
            return true;
        }
    }
}
