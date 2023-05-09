using Microsoft.Xna.Framework;


namespace TowerDefence
{
    public abstract class Spell : ISpell
    {
        public ESpell type;
        public Vector2 spellPos;
        public Vector2 spellPosOffset;
        public Rectangle spellRect;
        private Vector2 velocity;
        


        public Spell(Vector2 pos) 
        {
            this.spellPos = pos;
            spellPosOffset = new Vector2(spellPos.X * 64 + (int)Map.offsetMap.X+32-8, spellPos.Y * 64 + (int)Map.offsetMap.Y+32-8);
            spellRect = new Rectangle((int)spellPosOffset.X, (int)spellPosOffset.Y, 16, 16);
        }

        public void UpdateSpell()
        {
            velocity.Y = SpellDB.spell_speed[(int)type];
            spellPosOffset += velocity;

            
        }
        

        public void DrawSpell()
        {
            MainGame.spriteBatch.Draw(SpellDB.spell_texture[(int)type], spellPosOffset, Color.White);

        }
    }
}
