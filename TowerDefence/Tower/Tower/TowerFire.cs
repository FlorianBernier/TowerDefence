using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class TowerFire : Tower
    {
        
            
        public TowerFire(Vector2 pos) : base(pos)
        {
            type = ETower.FIRE;
        }

        public override void Update()
        {

        }
    }
}
