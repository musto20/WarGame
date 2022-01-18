using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame.Maps
{
    internal class Haritalar
    {
        public List<Map> maps = new List<Map>();
        public Haritalar()
        {
            maps.Add(new Map("Vahşi Batı",4));
            maps.Add(new Map("Hayalet Şehir", 3));
            maps.Add(new Map("Kuzey Ormanı", 6));
        }
        
        public void HaritalarGoster()
        { int i = 1;
            foreach (Map map in maps) 
            { 
                Console.WriteLine(i+". Harita: "+map.MapName+" Bot sayisi: "+map.BotCount);
                i++;
            }
        }

    }
}
