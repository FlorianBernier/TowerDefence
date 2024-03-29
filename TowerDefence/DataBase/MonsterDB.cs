﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TowerDefence
{
    // Classe statique contenant les données des monstres
    public static class MonsterDB
    {
        // Paramètres des vagues de monstres
        public static int wave = 0;
        public static int monsterByWave = 10;
        public static int monsterCount = 0;
        public static TimerMiliseconde monsterTimer = new TimerMiliseconde(500);
        public static TimerMiliseconde waveTimer = new TimerMiliseconde(5000);

        // Position de départ des monstres
        public static Vector2 start_pos = new Vector2(3*Map.tileWidth + Map.offsetMap.X, 1*Map.tileHeight + Map.offsetMap.Y);


        // Liste des textures des monstres
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

        // Vitesse des monstres correspondant aux textures
        public static List<int> speed = new List<int>()
        {
            10, 
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
