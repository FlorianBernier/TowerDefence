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
        public ESpell type;
        public Vector2 position;
        public Rectangle spellRect;
        private Vector2 posOffset;
        private Vector2 velocity;
        public int competence = -1;

        public Spell(Vector2 pos) 
        {
            this.position = pos;
            posOffset = new Vector2(position.X * 64 + (int)Map.offsetMap.X+32-8, position.Y * 64 + (int)Map.offsetMap.Y+32-8);
            spellRect = new Rectangle((int)posOffset.X, (int)posOffset.Y, 16, 16);
        }

        public void UpdateSpell(Vector2 monsterPos)
        {
            Vector2 direction = Vector2.Normalize(monsterPos - posOffset);
            float distance = Vector2.Distance(monsterPos, posOffset);
            velocity = direction * (SpellDB.spell_speed[(int)type] * (distance / 100f));

            velocity.X = SpellDB.spell_speed[(int)type];

            posOffset += velocity;
        }

        public void DrawSpell()
        {
            MainGame.spriteBatch.Draw(SpellDB.spell_texture[(int)type], posOffset, Color.White);

        }

    }
}
