using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TowerDefence
{

    public static class MonsterDB
    {
        // Wave
        public static int wave = 1;
        public static int monsterByWave = 20;
        public static int monsterCount = 0;
        public static TimerMiliseconde waveTimer = new TimerMiliseconde(500);
        public static TimerMiliseconde monsterTimer = new TimerMiliseconde(5000);


        // Position
        public static Vector2 start_pos = new Vector2(3*Map.tileWidth + Map.offsetMap.X, 1*Map.tileHeight + Map.offsetMap.Y);
        

        // Texture
        public static List<Texture2D> monster_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("Monster/Monster1"),
            MainGame.content.Load<Texture2D>("Monster/Monster2"),
            MainGame.content.Load<Texture2D>("Monster/Monster3"),
            MainGame.content.Load<Texture2D>("Monster/Monster4"),
            MainGame.content.Load<Texture2D>("Monster/Monster5"),
            MainGame.content.Load<Texture2D>("Monster/Monster6"),
            MainGame.content.Load<Texture2D>("Monster/Monster7"),
            MainGame.content.Load<Texture2D>("Monster/Monster8"),
            MainGame.content.Load<Texture2D>("Monster/Monster9"),

        };
         
        // Speed
        public static List<int> speed = new List<int>()
        {
            2, 
            3, 
            2,
            4,
            3,
            2,
            2,
            3,
            3
        };

        

    }
}
