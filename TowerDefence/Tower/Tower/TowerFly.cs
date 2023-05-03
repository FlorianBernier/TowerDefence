using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class TowerFly : Tower
    {
        public TowerFly(Vector2 pos) : base(pos)
        {
            type = ETower.FLY;
        }


        public override void Update()
        {

        }
    }
}
