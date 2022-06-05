using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDio.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }
        public string Attack(int Bonus)
        {
            if ( Bonus > 6)
            {
                return this.Name + " Efetuou um golpe SUPER EFETIVO!!! ";
            }
            else
            {
                return this.Name + " Atacou com a espada, recebendo " + Bonus + " de bônus no ataque. ";
            }
        }
    }
}
