using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class TowerSpecial2 : Tower
    {
        public TowerSpecial2(Vector2 pos) : base(pos)
        {
            type = ETower.SPECIAL2;
        }

       
    }
}
