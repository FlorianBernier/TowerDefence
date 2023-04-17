using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace TowerDefence
{
    public class Map
    {
        public static Vector2 offsetMap = new Vector2(320, 50);

        public static Texture2D gridTexture;
        public static int[,] grid;
        public static Rectangle[,] gridRect;
        public static bool[,] gridHover;


        private Texture2D mapTexture;
        public Map() 
        {

        }
        public void Initialize()
        {
            gridRect = new Rectangle[15, 25];
            gridHover = new bool[15, 25];
            grid = new int[15, 25]
            {
                { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
                { 0,0,1,3,0,0,0,0,4,0,0,0,0,0,0,0,2,2,2,2,2,2,1,0,0 },
                { 0,0,1,2,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,2,1,0,0 },
                { 0,0,1,2,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,2,1,0,0 },
                { 0,0,1,2,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,2,1,0,0 },
                { 0,0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,0,0 },
                { 0,0,1,0,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,0,1,0,0 },
                { 0,0,1,0,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,0,1,0,0 },
                { 0,0,1,0,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,0,1,0,0 },
                { 0,0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,0,0 },
                { 0,0,1,2,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,2,1,0,0 },
                { 0,0,1,2,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,2,1,0,0 },
                { 0,0,1,2,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,2,1,0,0 },
                { 0,0,1,2,2,2,2,2,2,0,0,0,0,0,0,0,2,2,2,2,2,2,1,0,0 },
                { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
            };

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    gridRect[i, j] = new Rectangle(i * 64, j * 64, 64, 64);
                }
            }
        }

        public void LoadContent()
        {
            mapTexture = MainGame.content.Load<Texture2D>("Map/Map");

            gridTexture = MainGame.content.Load<Texture2D>("Map/Grid");


        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(mapTexture, offsetMap, Color.White);

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Rectangle gridPos = new Rectangle(i * 64 + (int)offsetMap.X, j * 64 + +(int)offsetMap.Y, 64, 64);

                    MainGame.spriteBatch.Draw(gridTexture, gridPos, Color.White);
                }
            }
        }
    }
}
