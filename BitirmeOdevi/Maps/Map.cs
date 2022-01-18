using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame.Maps
{
    internal class Map
    {
        internal Map(string mapName, int botCount)
        {
            if (mapName.Length < 15 && botCount > 2 && botCount < 9)
            {
                MapName = mapName;
                BotCount = botCount;
            }
            else
                throw new Exception();
        }

        public string MapName { get; set; }
        public int BotCount { get; set; }
    }
}
