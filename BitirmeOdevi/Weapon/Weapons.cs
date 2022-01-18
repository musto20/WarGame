using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerWarGame
{
    internal abstract class Weapons
    {
        protected Weapons(string marka, string model, int hasar,bool scope)
        {
            Marka = marka;
            Model = model;
            Hasar = hasar;
            Scope = scope;
        }
        public bool saldirabilir { get; set; } = true;
        public  String Marka { get; set; }
        public  String Model { get; set; }
        public  int Hasar { get; set; }
        public bool Scope { get; set; }

        public  void ScopeOpen()
        {
            if (Scope == true)
            {
                Console.WriteLine("Hedefi net görmek için yakınlaştırıldı.");
            }
        }

       public virtual void Bileyle()
        {
            Console.WriteLine("Bu silah bileylenemez");
        }

        public abstract void Saldir();

    }
}
