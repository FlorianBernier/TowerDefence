using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public abstract class Tower : ITower
    {
        public ETower type;
        public Tower() 
        {
        
        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], new Vector2(0,0), Color.White);
        }
    }
}
