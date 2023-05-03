using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public abstract class Spell : ISpell
    {
        public ETower type;
        public Vector2 position;
        public Rectangle spellRect;
        private Vector2 posOffset;

        public Spell(Vector2 pos) 
        {
            this.position = pos;
            posOffset = new Vector2(position.X * 64 + (int)Map.offsetMap.X+32, position.Y * 64 + (int)Map.offsetMap.Y+32);
            spellRect = new Rectangle((int)posOffset.X, (int)posOffset.Y, 8, 8);
        }

        public void DrawSpell()
        {
            MainGame.spriteBatch.Draw(SpellDB.spell_texture[(int)type], new Vector2(200,200), Color.White);

        }

    }
}
