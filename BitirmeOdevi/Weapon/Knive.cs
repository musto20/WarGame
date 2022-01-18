using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCareerWarGame.Weapon;

namespace TechCareerWarGame
{
    internal class Knive : Melee
    {
        public Knive(string marka, string model, int hasar,bool scope) : base(marka, model, hasar,scope)
        {
        }
        public override void Saldir()
        {
            if (saldirabilir)
            {
                saldirabilir = !saldirabilir;
            } 
            else
                Console.WriteLine("Bileyleme gerekli");
        }


    }
}
