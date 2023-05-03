using Microsoft.Xna.Framework;


namespace TowerDefence
{
    public class TowerFire : Tower
    { 
        public TowerFire(Vector2 pos) : base(pos)
        {
            type = ETower.FIRE;
        }

        
    }
}
