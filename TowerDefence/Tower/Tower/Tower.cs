using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace TowerDefence
{
    public abstract class Tower : ITower
    {
        public ETower type;
        public Vector2 position;
        public Rectangle towerRect;
        private Vector2 posOffset;
        private Vector2 posOffsetSpell;
        public int competence = -1;
        public Tower(Vector2 pos) 
        {
            this.position = pos;
            posOffset = new Vector2(position.X * 64 + (int)Map.offsetMap.X, position.Y * 64 + (int)Map.offsetMap.Y);
            towerRect = new Rectangle((int)posOffset.X, (int)posOffset.Y, 64, 64);

            posOffsetSpell = new Vector2(position.X * 64 + (int)Map.offsetMap.X+32, position.Y * 64 + (int)Map.offsetMap.Y+32);
        }

        public void SpellBase()
        {
            //posOffsetSpell.Y += TowerDB.spell_base_speed[(int)type];
        }
        public void Draw()
        {
            //MouseState mouseState = Mouse.GetState();

            MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], posOffset, Color.White);

            MainGame.spriteBatch.Draw(TowerDB.spell_base_texture[(int)type], posOffsetSpell, Color.White);

        }

        
    }
}
