using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class SpellPoison : Spell
    {
        public SpellPoison(Vector2 pos) : base(pos)
        {
            type = ESpell.POISON;
        }
    }
}
