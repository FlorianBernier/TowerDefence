using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.ComponentModel;


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


        // CONTROLLER

        // Contener
        public static Texture2D contener_texture = MainGame.content.Load<Texture2D>("GUI/Contener");
        public static Vector2 contener_pos = new Vector2(5, 695);

        // Afficher
        public static Texture2D afficher_texture = MainGame.content.Load<Texture2D>("GUI/Afficher");
        public static Vector2 afficher_pos = new Vector2(0, 50);


        // TOWER BUILDER

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

        // Builder Pos
        public static List<Vector2> builder_pos = new List<Vector2>()
        {
            new Vector2(contener_pos.X + 6, contener_pos.Y + 6),
            new Vector2(contener_pos.X + 107, contener_pos.Y + 6 ),
            new Vector2(contener_pos.X + 208, contener_pos.Y + 6),
            new Vector2(contener_pos.X + 6, contener_pos.Y + 107),
            new Vector2(contener_pos.X + 107, contener_pos.Y + 107),
            new Vector2(contener_pos.X + 208, contener_pos.Y + 107),
            new Vector2(contener_pos.X + 6, contener_pos.Y + 208)
        };

        // Infos Texture
        public static List<Texture2D> fire_infos_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Fire"),
        };

        public static List<Texture2D> ice_infos_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Ice"),
        };

        public static List<Texture2D> poison_infos_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Poison"),
        };

        public static List<Texture2D> fly_infos_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Fly"),
        };

        public static List<Texture2D> earth_infos_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Earth"),
        };

        public static List<Texture2D> special1_infos_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Special1"),
        };

        public static List<Texture2D> special2_infos_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Special2"),
        };

        // Infos Pos
        public static List<Vector2> infos_pos = new List<Vector2>()
        {
            new Vector2(afficher_pos.X + 63, afficher_pos.Y + 40),
            new Vector2(afficher_pos.X + 6, afficher_pos.Y + 325),
            new Vector2(afficher_pos.X + 6, afficher_pos.Y + 411),
            new Vector2(afficher_pos.X + 6, afficher_pos.Y + 497),
            new Vector2(afficher_pos.X + 6, afficher_pos.Y + 583),
        };




        // Tower Upgrade



    }
}
