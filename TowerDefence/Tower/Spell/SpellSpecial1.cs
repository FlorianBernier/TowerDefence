using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class SpellSpecial1 : Spell
    {
        public SpellSpecial1(Vector2 pos) : base(pos)
        {
            type = ESpell.SPECIAL1;
        }
    }
}
