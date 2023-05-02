using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace TowerDefence
{
    public static class TowerDB
    {
        // TOWER


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



        // SPELL

        // Tir de base 
        public static List<Texture2D> spell_base_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
            MainGame.content.Load<Texture2D>("Tower/Spell/SpellBase/Test"),
        };

        public static List<int> spell_base_speed = new List<int>()
        {
            5,
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
