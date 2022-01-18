using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{

    internal class Duello
    {

        public Duello(Game game)
        {
            Games = game;
        }


        public Game Games { get; set; }


        internal void PlayerSaldir()
        {
            
            while (Games.bot.Count!=0)
            {
                Random random = new Random();
                int v = random.Next(Games.bot.Count);
                while (Games.bot[v].BotHealth > 0 && Games.Player.PlayerHealth > 0)
                {
                    SilahSec();
                    Console.WriteLine($"Oyuncunun canı {Games.Player.PlayerHealth} düsmanin canı {Games.bot[v].BotHealth}");
                    if (Games.Player.PlayerSilahlar[Games.Player.EldekiSilah].saldirabilir)
                    {
                        Games.bot[v].BotHealth -= Games.Player.PlayerSilahlar[Games.Player.EldekiSilah].Hasar;
                        Games.Player.PlayerSilahlar[Games.Player.EldekiSilah].Saldir();
                        if (Games.bot[v].BotHealth <= 0)
                        {
                            Console.WriteLine("Düsman Öldü Düelloyu kazandiniz");
                            Games.bot.RemoveAt(v);
                            break;
                        }
                        else
                        {
                            Games.Player.PlayerHealth -= Games.bot[v].botWeapon.Hasar;
                            Games.bot[v].botWeapon.Saldir();
                            Console.WriteLine($"Oyuncunun canı {Games.Player.PlayerHealth} düsmanin canı {Games.bot[v].BotHealth}");
                            if (Games.Player.PlayerHealth <= 0)
                            {
                                Console.WriteLine("Oyuncu Kaybetti");
                                break;
                            }
                            if (!Games.bot[v].botWeapon.saldirabilir)
                            {
                                Games.bot.RemoveAt(v);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Silah kullanılamaz");

                    }
                }
            }
            if (Games.bot.Count == 0)
            {
                Console.WriteLine("Oyunu Kazandiniz");
            }
        }

        public void SilahSec()
        {
            Console.WriteLine("Lütfen elinizdeki silahi seciniz");
            int num =Convert.ToInt32(Console.ReadLine());
            Games.Player.EldekiSilah = num-1;
        }
        


    }
}
