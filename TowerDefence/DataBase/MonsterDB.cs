﻿using Microsoft.Xna.Framework;
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

        // Position
        public static Vector2 start_pos = new Vector2(3*Map.tileWidth + Map.offsetMap.X, 1*Map.tileHeight + Map.offsetMap.Y);

        // Texture
        public static List<Texture2D> monster_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("Monster/Monster1"),
            MainGame.content.Load<Texture2D>("Monster/Monster2"),
            MainGame.content.Load<Texture2D>("Monster/Monster3"),
        };
         
        // Speed
        public static List<Vector2> speed = new List<Vector2>()
        {
            new Vector2(0,3),
            new Vector2(0,1),
            new Vector2(0,3)
        };
    }
}