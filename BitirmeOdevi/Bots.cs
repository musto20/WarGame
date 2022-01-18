using TechCareerWarGame.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{
    internal class Bots
    {
        public Weapons botWeapon { get; set; }
        public int BotHealth {  get; set; } = new Random().Next(30, 71);
    }
}
