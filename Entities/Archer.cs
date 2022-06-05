using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDio.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {

        }
        public override string Attack()
        {
            return this.Name + " Atacou atirando uma flecha de madeira.";
        }
    }
}
