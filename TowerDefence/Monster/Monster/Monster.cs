using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TowerDefence
{
    public abstract class Monster : IMonster
    {
        public EMonster type;
        // Move
        public Vector2 pos = MonsterDB.start_pos;
        public Vector2 velocity;
        public int lastDir;
        public bool remove = false;
        

        public Monster() 
        {
            
        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(MonsterDB.monster_texture[(int)type],this.pos,Color.White);
        }

        public void Move()
        {
            int tileX = (int)((pos.X - Map.offsetMap.X) / Map.tileWidth);
            int tileY = (int)((pos.Y - Map.offsetMap.Y) / Map.tileHeight);

            switch (lastDir)
            {
                case 4:
                    tileX++;
                    break;
                case 8:
                    tileY++;
                    break;

                default:
                    break;
            }


            switch (Map.grid[tileY, tileX])
            {
                case 2:
                    lastDir = 2;
                    pos.X = tileX * Map.tileWidth + Map.offsetMap.X;
                    velocity.X = 0;
                    velocity.Y = MonsterDB.speed[(int)type];
                    break;
                case 4:
                    lastDir = 4;
                    pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    velocity.X = MonsterDB.speed[(int)type] * -1;
                    velocity.Y = 0;
                    break;
                case 6:
                    lastDir = 6;
                    pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    velocity.X = MonsterDB.speed[(int)type];
                    velocity.Y = 0;
                    break;
                case 8:
                    lastDir = 8;
                    pos.X = tileX * Map.tileWidth + Map.offsetMap.X;
                    velocity.X = 0;
                    velocity.Y = MonsterDB.speed[(int)type] * -1;
                    break;
                case 3:
                    velocity.X = 0;
                    velocity.Y = MonsterDB.speed[(int)type];
                    break;
                case 5:
                    pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    velocity.X = 0;
                    velocity.Y = 0;
                    remove = true;
                    break;
                default:
                    break;
            }

            pos += velocity;
        }

        public void Build()
        {
            
        }
        
    }
}
