using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class TowerIce : Tower
    {
        public TowerIce(Vector2 pos) : base(pos)
        {
            type = ETower.ICE;
        }

    }
}
