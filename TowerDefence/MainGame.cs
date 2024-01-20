using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TowerDefence
{
    public class MainGame : Game
    {
        // Déclaration des membres statiques partagés entre les classes
        public static SpriteBatch spriteBatch;
        public static ContentManager content;
        public static SpriteFont font;

        // Gestionnaire graphique pour les paramètres d'affichage
        public GraphicsDeviceManager graphics;

        // Instance de la classe principale du jeu
        public MainGameTD mainGameTD;

        // Texture utilisée pour rendre la souris invisible
        public static Texture2D mouseTransparent;

        // Liste des monstres présents dans le jeu
        List<Monster> monsters;

        // Constructeur de la classe MainGame
        public MainGame()
        {
            // Initialisation du gestionnaire graphique et du répertoire de contenu
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            content = Content;

            // Configuration de l'affichage
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1010;
        }

        // Méthode appelée lors de l'initialisation du jeu
        protected override void Initialize()
        {
            // Création de l'instance de la classe principale du jeu
            mainGameTD = new MainGameTD();
            base.Initialize();
        }
        // Méthode appelée lors du chargement des contenus du jeu
        protected override void LoadContent()
        {
            // Initialisation du spritebatch, chargement de la police de caractères et des contenus du jeu
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("MyFont");
            mainGameTD.LoadContent();

            // Création d'une texture transparente pour masquer la souris
            mouseTransparent = new Texture2D(GraphicsDevice, 1, 1);
            mouseTransparent.SetData(new[] { Color.Transparent });
        }
        // Méthode appelée à chaque mise à jour du jeu
        protected override void Update(GameTime gameTime)
        {
            // Gestion de la fermeture du jeu
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Mise à jour de la logique du jeu
            mainGameTD.Update(gameTime);
            base.Update(gameTime);
        }

        // Méthode appelée à chaque frame pour le rendu
        protected override void Draw(GameTime gameTime)
        {
            // Effacement de l'écran avec une couleur de fond noire
            GraphicsDevice.Clear(Color.Black);

            // Début du dessin avec le spritebatch
            spriteBatch.Begin();
            // Appel à la méthode de dessin de la classe principale du jeu
            mainGameTD.Draw();
            // Fin du dessin avec le spritebatch
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}