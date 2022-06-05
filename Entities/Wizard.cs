using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDio.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        
        public string Attack(int Bonus)
        {
            return this.Name + " Lançou magia de fogo, recebeu um bônus de ataque +" + Bonus;
        }
    }
}
