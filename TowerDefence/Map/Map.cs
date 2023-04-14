using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace TowerDefence
{
    public class Map
    {
        public static Vector2 offsetMap = new Vector2(320, 50);
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
            MainGame.spriteBatch.Draw(mapTexture, offsetMap, Color.White);
        }
    }
}
