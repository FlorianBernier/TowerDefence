using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace TowerDefence
{
    public class Map
    {
        public static int[,] grid;


        private Texture2D mapTexture;
        public Map() 
        {

        }

        public void LoadContent()
        {



            mapTexture = MainGame.content.Load<Texture2D>("Map/Map");
        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(mapTexture, new Vector2(0,50), Color.White);
        }
    }
}
