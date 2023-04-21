using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class TowerFire : Tower
    {
        public TowerFire() : base()
        {
            type = ETower.FIRE;
        }
    }
}
