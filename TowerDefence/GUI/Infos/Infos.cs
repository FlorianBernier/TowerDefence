using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefence
{
    public class Infos
    {
        private Texture2D infosTexture;
        public Infos() 
        {
        
        }

        public void LoadContent()
        {
            infosTexture = MainGame.content.Load<Texture2D>("GUI/Infos/Infos");
        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(infosTexture, new Vector2(0, 0), Color.White);
        }
    }
}
