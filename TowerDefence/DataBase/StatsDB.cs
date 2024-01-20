using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TowerDefence
{
    // Classe statique contenant les données des statistiques du joueur
    public static class StatsDB
    {
        // Informations sur le joueur

        // Points de vie du joueur
        public static int playerPV = 100;
        public static Vector2 posPlayerPV = new Vector2(940, 20);

        // Or du joueur
        public static int playerOR = 500;
        public static Vector2 posPlayerOR = new Vector2(1100, 15);

        // Bois du joueur
        public static int playerWood = 1;
        public static Vector2 posPlayerWood = new Vector2(1420, 15);

        // Vague actuelle du joueur
        public static int playerWave = 1;
        public static Vector2 posPlayerWave = new Vector2(1720, 15);


        //---------------------------- TEXTURE ----------------------------//

        // CONTROLLER //----------------------------------------------------------------------------------//

        // Conteneur
        public static Texture2D container_texture = MainGame.content.Load<Texture2D>("GUI/Contener");
        public static Vector2 container_pos = new Vector2(5, 695);

        // Affichage
        public static Texture2D display_texture = MainGame.content.Load<Texture2D>("GUI/Afficher");
        public static Vector2 display_pos = new Vector2(0, 50);

        // Retour au constructeur
        public static Texture2D return_builder_texture = MainGame.content.Load<Texture2D>("GUI/ReturnBuilder");
        public static Vector2 return_builder_pos = new Vector2(container_pos.X+208, container_pos.Y+208);

        // Amélioration active
        public static Texture2D upgrade_active_texture = MainGame.content.Load<Texture2D>("GUI/UpgradeActive");

        // Informations sur les textures
        public static List<Texture2D> infos_fire_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Fire"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Fire"),
        };
        public static List<Texture2D> infos_ice_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Ice"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Ice"),
        };
        public static List<Texture2D> infos_poison_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Poison"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Poison"),
        };
        public static List<Texture2D> infos_fly_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Fly"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Fly"),
        };
        public static List<Texture2D> infos_earth_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Earth"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Earth"),
        };
        public static List<Texture2D> infos_special1_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Special1"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Special1"),
        };
        public static List<Texture2D> infos_special2_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/Afficher/Portrait/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Type/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance1/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance2/Special2"),
            MainGame.content.Load<Texture2D>("GUI/Afficher/Competance3/Special2"),
        };

        // Informations sur les positions des textures
        public static List<Vector2> infos_texture_pos = new List<Vector2>()
        {
            new Vector2(display_pos.X + 63, display_pos.Y + 40),
            new Vector2(display_pos.X + 6, display_pos.Y + 325),
            new Vector2(display_pos.X + 6, display_pos.Y + 411),
            new Vector2(display_pos.X + 6, display_pos.Y + 497),
            new Vector2(display_pos.X + 6, display_pos.Y + 583),
        };

        // TOWER BUILDER //---------------------------------------------------------------------------//

        // Informations sur les textures du constructeur de tours
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

        // Informations sur les positions du constructeur de tours
        public static List<Vector2> builder_pos = new List<Vector2>()
        {
            new Vector2(container_pos.X + 6, container_pos.Y + 6),
            new Vector2(container_pos.X + 107, container_pos.Y + 6 ),
            new Vector2(container_pos.X + 208, container_pos.Y + 6),
            new Vector2(container_pos.X + 6, container_pos.Y + 107),
            new Vector2(container_pos.X + 107, container_pos.Y + 107),
            new Vector2(container_pos.X + 208, container_pos.Y + 107),
            new Vector2(container_pos.X + 6, container_pos.Y + 208)
        };


        // TOWER UPGRADE //--------------------------------------------------------------------//

        // Informations sur les textures des améliorations de tours
        public static List<Texture2D> upgrade_fire_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/FireCompetence1"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/FireCompetence2"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/FireCompetence3"),
        };
        public static List<Texture2D> upgrade_ice_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/IceCompetence1"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/IceCompetence2"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/IceCompetence3"),
        };
        public static List<Texture2D> upgrade_poison_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/PoisonCompetence1"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/PoisonCompetence2"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/PoisonCompetence3"),
        };
        public static List<Texture2D> upgrade_fly_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/FlyCompetence1"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/FlyCompetence2"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/FlyCompetence3"),
        };
        public static List<Texture2D> upgrade_earth_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/EarthCompetence1"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/EarthCompetence2"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/EarthCompetence3"),
        };
        public static List<Texture2D> upgrade_special1_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/Special1Competence1"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/Special1Competence2"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/Special1Competence3"),
        };
        public static List<Texture2D> upgrade_special2_texture = new List<Texture2D>()
        {
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/Special2Competence1"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/Special2Competence2"),
            MainGame.content.Load<Texture2D>("GUI/TowerUpgrade/Special2Competence3"),
        };

        // Informations sur les positions des améliorations de tours
        public static List<Vector2> upgrade_pos = new List<Vector2>()
        {
            new Vector2(container_pos.X + 6, container_pos.Y + 6),
            new Vector2(container_pos.X + 107, container_pos.Y + 6 ),
            new Vector2(container_pos.X + 208, container_pos.Y + 6),
        };


        // TEXTE //------------------------------------------------------------------------------------// 

        // CONTROLLER //----------------------------------------------------------------------------//

        // Affichage
        public static List<string> infos_fire_texte = new List<string>()
        {
            "MAGE DE FEU",
            "Incendio",
            "Diffinito",
            "Flambois",
        };
        public static List<string> infos_ice_texte = new List<string>()
        {
            "MAGE DE GLACE",
            "glacius",
            "Stupefix",
            "Oubliette",
        };
        public static List<string> infos_poison_texte = new List<string>()
        {
            "MAGE DE POISON",
            "Crache limace",
            "Silencio",
            "Serpentasortia",
        };
        public static List<string> infos_fly_texte = new List<string>()
        {
            "MAGE DE L'AIR",
            "Reducto",
            "Ridiculuce",
            "Incarcerem",
        };
        public static List<string> infos_earth_texte = new List<string>()
        {
            "MAGE DE TERRE",
            "Amplificatum",
            "Destructum",
            "Flipendo",
        };
        public static List<string> infos_special1_texte = new List<string>()
        {
            "MAGE DE LUMIERE",
            "Expelliarmus",
            "Lumos",
            "Spero patronum",
        };
        public static List<string> infos_special2_texte = new List<string>()
        {
            "MAGE DE TENEBRE",
            "Imperium",
            "Endoloris",
            "Avada kedavra",
        };

        // Positions du texte
        public static List<Vector2> infos_texte_pos = new List<Vector2>()
        {
            new Vector2(display_pos.X + 6+60, display_pos.Y + 325+15),
            new Vector2(display_pos.X + 6+60, display_pos.Y + 411+15),
            new Vector2(display_pos.X + 6+60, display_pos.Y + 497+15),
            new Vector2(display_pos.X + 6+60, display_pos.Y + 583+15),
        };
    }
}
