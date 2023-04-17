using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.DirectWrite;
using System.Diagnostics;

namespace TowerDefence
{
    public class Map
    {
        private Texture2D mapTexture;
        public static Vector2 offsetMap = new Vector2(320, 50);


        public static Texture2D gridTexture;
        public static int[,] grid;
        public static int tileWidth = 64;
        public static int tileHeight = 64;
        public static int mapWidth = 25;
        public static int mapHeight = 15;




        public Map() 
        {

        }
        public void Initialize()
        {

        }

        public void LoadContent()
        {
            mapTexture = MainGame.content.Load<Texture2D>("Map/Map");
            gridTexture = MainGame.content.Load<Texture2D>("Map/Grid");

            grid = new int[15, 25]
            {
                { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
                { 0,0,1,3,0,0,0,0,3,0,0,0,0,0,0,0,2,9,9,9,9,4,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,6,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,8,1,0,0 },
                { 0,0,1,0,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,0,1,0,0 },
                { 0,0,1,0,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,0,1,0,0 },
                { 0,0,1,0,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,0,1,0,0 },
                { 0,0,1,2,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,4,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,6,9,9,9,9,8,0,0,0,0,0,0,0,6,9,9,9,9,8,1,0,0 },
                { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
            };

        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(mapTexture, offsetMap, Color.White);

            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    Rectangle gridPos = new Rectangle(i * 64 + (int)offsetMap.X, j * 64 + (int)offsetMap.Y, 64, 64);

                    MainGame.spriteBatch.Draw(gridTexture, gridPos, Color.White);
                }
            }
        }
    }
}
