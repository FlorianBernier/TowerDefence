using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1;
using SharpDX.MediaFoundation;

namespace TowerDefence
{
    public class Infos
    {
        // Décalage pour positionner le panneau d'informations sur la GUI
        public static Vector2 offsetBuilder = new Vector2(0, 50);
        // Texture du panneau d'informations
        private Texture2D infosTexture;
        // Texture du constructeur de tour
        private Texture2D builderTexture;

        // Constructeur par défaut
        public Infos() 
        {
        
        }

        // Chargement des contenus
        public void LoadContent()
        {
            // Chargement de la texture du panneau d'informations
            infosTexture = MainGame.content.Load<Texture2D>("GUI/Infos/Infos");
            // Chargement de la texture du constructeur de tour
            builderTexture = MainGame.content.Load<Texture2D>("GUI/Infos/Builder");

        }
        
        // Affichage des contenus
        public void Draw()
        {
            // Affichage du panneau d'informations et du constructeur de tour
            MainGame.spriteBatch.Draw(infosTexture, new Vector2(0, 0), Color.White);
            MainGame.spriteBatch.Draw(builderTexture, offsetBuilder, Color.White);

            // Affichage des statistiques du joueur
            MainGame.spriteBatch.DrawString(MainGame.font, ""+ StatsDB.playerPV, StatsDB.posPlayerPV, Color.Red);
            MainGame.spriteBatch.DrawString(MainGame.font, "" + StatsDB.playerOR, StatsDB.posPlayerOR, Color.White);
            MainGame.spriteBatch.DrawString(MainGame.font, "" + StatsDB.playerWood, StatsDB.posPlayerWood, Color.White);
            MainGame.spriteBatch.DrawString(MainGame.font, "" + StatsDB.playerWave, StatsDB.posPlayerWave, Color.White);
        }
    }
}
