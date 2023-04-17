using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;

namespace TowerDefence
{
    public abstract class Monster : IMonster
    {
        public EMonster type;
        public Vector2 pos = MonsterDB.start_pos;

        public Monster() 
        {
            
        }

        public void DrawMonster()
        {
            MainGame.spriteBatch.Draw(MonsterDB.monster_texture[(int)type],this.pos,Color.White);
        }

        public void MoveMonster()
        {
            

            int tileX = (int)((pos.X - Map.offsetMap.X) / Map.tileWidth);
            int tileY = (int)((pos.Y - Map.offsetMap.Y) / Map.tileHeight);

            


            switch (Map.grid[tileY, tileX])
            {
                case 2:
                    //pos.X = tileX * Map.tileWidth + Map.offsetMap.X;
                    MonsterDB.speed[(int)type] = new Vector2(0, 3);
                    break;
                case 4:
                    //pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    MonsterDB.speed[(int)type] = new Vector2(-3, 0);
                    break;
                case 6:
                    //pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    MonsterDB.speed[(int)type] = new Vector2(3, 0);
                    break;
                case 8:
                    //pos.X = tileX * Map.tileWidth + Map.offsetMap.X;
                    MonsterDB.speed[(int)type] = new Vector2(0, -3);
                    break;

                default:
                    break;
            }

            pos += MonsterDB.speed[(int)type];
        }







        public void TimerMonster()
        {

        }
        
    }
}
