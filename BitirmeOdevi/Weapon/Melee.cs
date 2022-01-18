using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{
    internal abstract class Melee:Weapons
    {
        protected Melee(string marka, string model, int hasar,bool scope) : base(marka, model, hasar,scope)
        {
        }
        public override void Bileyle()
        {
            if (!saldirabilir)
            {
                saldirabilir = !saldirabilir;
                Console.WriteLine("Bileylendi.");
            }
            else
            {
                Console.WriteLine("Zaten keskin durumda");
            }
        }

    }
}
