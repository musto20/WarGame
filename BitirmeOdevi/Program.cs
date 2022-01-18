using TechCareerWarGame.Maps;
using System;

namespace TechCareerWarGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Haritalar haritalar = new Haritalar();
            Cephanelik cephanelik = new Cephanelik();
            Game gameStart = new Game();
            int conrol = 0;

            while (conrol!=6)
            {
                Console.WriteLine("********************************\nHarita eklemek için 1'i\nOyuncu eklemek için 2'yi\nHarita seçmek için 3'ü\nSilahlari Seçmek icin 4'ü\nOyunu başlatmak için 5'i\nÇıkmak için 6'yı seçin\n********************************");
                conrol=Convert.ToInt32( Console.ReadLine());


                if (conrol==1)//Harita Ekleme işlemi
                {
                    Haritaolustur(haritalar);
                }


                else if (conrol == 2)//Oyuncu Ekleme işlemi
                {
                    string playername;
                    Console.WriteLine("Oyuncu Adini girin");
                    playername = Console.ReadLine();
                    player.Name = playername;
                    gameStart.Player= player;
                    
                }
                else if (conrol==3)//Harita seçme işlemi
                {
                    if (player.Name!=null)
                    {
                        haritalar.HaritalarGoster();
                        int i=Convert.ToInt32( Console.ReadLine());
                        gameStart.map = haritalar.maps[i-1];
                    }
                }
                else if (conrol == 4)//Oyuncunun silahlarını seçme işlemi
                {
                    if (player.Name != null)
                    {
                        cephanelik.SilahlariGoster();
                        int j = 0;
                        while (j<3)
                        {
                            int i = Convert.ToInt32(Console.ReadLine());
                            if(player.SilahEkle(i - 1))
                            {
                                j++;
                            }
                        }
                    }
                }
                else if(conrol== 5)//Oyunu başlatma
                {
                    gameStart.Basla();
                    Duello duello = new Duello(gameStart);
                    duello.PlayerSaldir();
                }
                else if (conrol == 6)
                {
                }
                else
                {
                    Console.WriteLine("Hatalı deger girdiniz ");
                }
            }
            Console.ReadKey();
        }



       public static void Haritaolustur(Haritalar haritalar)
        {
            int bot;
            string haritaname;
            Console.WriteLine("Harita Adini giriniz");
            haritaname=Console.ReadLine();
            Console.WriteLine("Bot sayisini giriniz");
            bot=Convert.ToInt32( Console.ReadLine());
            haritalar.maps.Add(new Map(haritaname, bot));
        }


    }
}
