using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public abstract class Monster : IMonster
    {
        public EMonster type;

        public Vector2 pos = new Vector2(
            MonsterDB.initial_pos.X, 
            MonsterDB.initial_pos.Y
        );

        public Monster() 
        {
            
        }

        public void DrawMonster()
        {
            MainGame.spriteBatch.Draw(
                MonsterDB.monster_texture[(int)type],
                this.pos,
                Color.White
           );
        }

        public void MoveMonster()
        {
            pos += MonsterDB.vitesse[(int)type];
        }

        public void TimerMonster()
        {

        }
        
    }
}
