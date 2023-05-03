using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class TowerSpecial1 : Tower
    {
        public TowerSpecial1(Vector2 pos) : base(pos)
        {
            type = ETower.SPECIAL1;
        }

        public override void Update()
        {

        }
    }
}
