using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace TowerDefence
{
    public static class StatsDB
    {
        // Infos

        // playerPV
        public static int playerPV = 100;
        public static Vector2 posPlayerPV = new Vector2(940, 20);

        // playerOR
        public static int playerOR = 500;
        public static Vector2 posPlayerOR = new Vector2(1100, 15);

        // playerWood
        public static int playerWood = 1;
        public static Vector2 posPlayerWood = new Vector2(1420, 15);

        // playerWave
        public static int playerWave = 1;
        public static Vector2 posPlayerWave = new Vector2(1720, 15);


        // Tower Builder

        // Builder Texture
        public static List<Texture2D> builder_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerBuilder/Fire"),
            MainGame.content.Load<Texture2D>("GUI/TowerBuilder/Ice"),
            MainGame.content.Load<Texture2D>("GUI/TowerBuilder/Poison"),
            MainGame.content.Load<Texture2D>("GUI/TowerBuilder/Fly"),
            MainGame.content.Load<Texture2D>("GUI/TowerBuilder/Earth"),
            MainGame.content.Load<Texture2D>("GUI/TowerBuilder/Special1"),
            MainGame.content.Load<Texture2D>("GUI/TowerBuilder/Special2"),
        };

        public static List<Vector2> pos_builder_texture = new List<Vector2>()
        {
            new Vector2(0,0),
            new Vector2(450,100),
            new Vector2(0,0),
            new Vector2(100,100),
            new Vector2(0,0),
            new Vector2(100,100),
            new Vector2(100,100)
        };


    }
}
