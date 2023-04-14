using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{

    public static class MonsterDB
    {


        public static Vector2 initial_pos = new Vector2(500,0);

        public static List<Texture2D> monster_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("Monster/Monster1"),
            MainGame.content.Load<Texture2D>("Monster/Monster2"),
            MainGame.content.Load<Texture2D>("Monster/Monster3"),
        };

        public static List<Vector2> vitesse = new List<Vector2>()
        {
            new Vector2(0,1),
            new Vector2(0,2),
            new Vector2(0,3)
        };
    }
}
