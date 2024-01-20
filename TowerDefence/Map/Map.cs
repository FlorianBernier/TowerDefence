using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.DirectWrite;
using System.Diagnostics;

namespace TowerDefence
{
    public class Map
    {
        // Texture de la carte
        private Texture2D mapTexture;
        // Décalage de la carte par rapport à l'écran
        public static Vector2 offsetMap = new Vector2(320, 50);
        // Texture de la grille
        public static Texture2D gridTexture;
        // Matrice représentant la grille du jeu
        public static int[,] grid;

        // Dimensions des tuiles et de la carte
        public static int tileWidth = 64;
        public static int tileHeight = 64;
        public static int mapWidth = 25;
        public static int mapHeight = 15;

        // Constructeur de la classe Map
        public Map() 
        {

        }
        // Méthode d'initialisation
        public void Initialize()
        {

        }

        // Méthode appelée lors du chargement des contenus du jeu
        public void LoadContent()
        {
            // Chargement des textures de la carte et de la grille
            mapTexture = MainGame.content.Load<Texture2D>("Map/Map");
            gridTexture = MainGame.content.Load<Texture2D>("Map/Grid");

            // Initialisation de la matrice représentant la grille
            // Contenu de la grille (0 : eau, 1 : zone de construction, 2-9 : chemin)
            grid = new int[15, 25]
            {
                { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
                { 0,0,1,3,0,0,0,0,5,0,0,0,0,0,0,0,2,9,9,9,9,4,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,6,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,8,1,0,0 },
                { 0,0,1,0,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,0,1,0,0 },
                { 0,0,1,0,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,0,1,0,0 },
                { 0,0,1,0,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,0,1,0,0 },
                { 0,0,1,2,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,4,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,9,1,1,1,1,9,1,1,1,1,1,1,1,9,1,1,1,1,9,1,0,0 },
                { 0,0,1,6,9,9,9,9,8,0,0,0,0,0,0,0,6,9,9,9,9,8,1,0,0 },
                { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
            };
        }

        // Méthode appelée à chaque frame pour le rendu de la carte
        public void Draw()
        {
            // Dessin de la texture de la carte à l'emplacement spécifié
            MainGame.spriteBatch.Draw(mapTexture, offsetMap, Color.White);

            // Dessin de la grille en parcourant chaque tuile de la matrice
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    // Calcul de la position de la tuile dans l'écran
                    Rectangle gridPos = new Rectangle(x * 64 + (int)offsetMap.X, y * 64 + (int)offsetMap.Y, 64, 64);

                    // Dessin de la tuile de la grille à la position calculée
                    MainGame.spriteBatch.Draw(gridTexture, gridPos, Color.White);
                }
            }
        }
    }
}
