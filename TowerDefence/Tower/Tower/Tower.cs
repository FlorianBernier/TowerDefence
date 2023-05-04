using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Configuration;

namespace TowerDefence
{
    public abstract class Tower : ITower
    {
        public ETower type;
        public Vector2 position;
        public Rectangle towerRect;
        private Vector2 posOffset;
        public int competence = -1;

        private TimerMiliseconde spellTimer;


        public Tower(Vector2 pos) 
        {
            this.position = pos;
            posOffset = new Vector2(position.X * 64 + (int)Map.offsetMap.X, position.Y * 64 + (int)Map.offsetMap.Y);
            towerRect = new Rectangle((int)posOffset.X, (int)posOffset.Y, 64, 64);

            spellTimer = new TimerMiliseconde(200);
        }

        public void AddSpell()
        {
            if ( spellTimer.elapsed())
            {
                MainGameTD.spellFilter
                .Add(
                    (ESpell)type, position);
                spellTimer.restart();

            }
        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], posOffset, Color.White);

        }
    }
}
