﻿using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace TowerDefence
{
    // Classe statique contenant les données des tours
    public static class TowerDB
    {
        // Liste des textures des différentes tours
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

        // Coût en OR de chaque tour
        public static List<int> tower_or = new List<int>()
        {
            100,
            100,
            100,
            150,
            150,
            200,
            200
        };
        // Coût en bois de chaque tour
        public static List<int> tower_wood = new List<int>()
        {
            0,
            0,
            0,
            0,
            0,
            1,
            1
        };

    }
}
