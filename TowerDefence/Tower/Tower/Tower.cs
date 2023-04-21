using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
        public Vector2 position;

        private Vector2 posOffest;
        public Tower(Vector2 pos) 
        {
            this.position = pos;
            posOffest = new Vector2(position.X * 64 + (int)Map.offsetMap.X, position.Y * 64 + (int)Map.offsetMap.Y);
        }

        public void Draw()
        {
            MouseState mouseState = Mouse.GetState();

            MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], posOffest, Color.White);
        }
    }
}
