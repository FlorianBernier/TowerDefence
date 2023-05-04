using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TowerDefence
{
    public static class SpellDB
    {


        // SPELL

        // Spell Base
        public static List<Texture2D> spell_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("Tower/Spell/Spell/SpellFire"),
            MainGame.content.Load<Texture2D>("Tower/Spell/Spell/SpellIce"),
            MainGame.content.Load<Texture2D>("Tower/Spell/Spell/SpellPoison"),
            MainGame.content.Load<Texture2D>("Tower/Spell/Spell/SpellFly"),
            MainGame.content.Load<Texture2D>("Tower/Spell/Spell/SpellEarth"),
            MainGame.content.Load<Texture2D>("Tower/Spell/Spell/SpellSpecial1"),
            MainGame.content.Load<Texture2D>("Tower/Spell/Spell/SpellSpecial2"),
        };

        public static List<int> spell_speed = new List<int>()
        {
            10,
            3,
            2,
            4,
            3,
            2,
            2,
        };
    }
}
