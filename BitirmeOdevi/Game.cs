using TechCareerWarGame.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{
    internal class Game
    {
        Cephanelik cephanelik;
        Duello duello { get; set; }
        public Player Player { get; set; }
        public List<Bots> bot { get; set; } = new List<Bots>();
        public Map map { get; set; }

        public void Basla()
        {

            if (Control())
            {
                BotOlustur(map.BotCount);
            }
            else
            {
                Console.WriteLine("Degerler bos gecilemez ");
                throw new Exception();
            }
                

        }


         bool Control()
        {
            bool control=false;
            if (Player.Name!=null&&map!=null&& Player.PlayerSilahlar.Count == 3)
            {
                return !control;
            }
            return control; 
        }
        
        void SilahVer()
        {
            foreach (var item in bot)
            {
                Random random = new Random();
                cephanelik = new Cephanelik();
                int r = random.Next(cephanelik.silahlar.Count);
                item.botWeapon = cephanelik.silahlar[r];
            }

        }
         void BotOlustur(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                bot.Add(new Bots());
            }
            SilahVer();
        } 
    }
}
