using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace TowerDefence
{
    public static class TowerDB
    {
        public static List<Texture2D> tower_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("Tower/Tower/TowerFire"),
            MainGame.content.Load<Texture2D>("Tower/Tower/TowerIce"),
            MainGame.content.Load<Texture2D>("Tower/Tower/TowerPoison"),
            MainGame.content.Load<Texture2D>("Tower/Tower/TowerFly"),
            MainGame.content.Load<Texture2D>("Tower/Tower/TowerEarth"),
            MainGame.content.Load<Texture2D>("Tower/Tower/TowerSpecial1"),
            MainGame.content.Load<Texture2D>("Tower/Tower/TowerSpecial2"),
        };
    }
}
