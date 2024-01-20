using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TowerDefence
{
    // Classe abstraite qui implémente l'interface IController et fournit des méthodes communes pour les contrôleurs spécifiques
    public abstract class Controller : IController
    {
        // État précédent de la souris
        public MouseState oldMouseState;
        // Indice du bouton cliqué
        public int boutonCliqueIndex = -1;
        // Coordonnées de la case cliquée
        public static int caseClickedX = -1;
        public static int caseClickedY = -1;

        // Constructeur par défaut
        public Controller() 
        {
        
        }

        // Méthodes abstraites à implémenter dans les classes dérivées
        public abstract void UpdateGUI();
        public abstract void DrawGUI();


        // Méthode commune pour dessiner les éléments d'affichage dans l'interface utilisateur
        public void DrawDisplay(List<Texture2D> listTextures, List<string> listeTextes)
        {
            // Dessine les textures
            for (int i = 0; i < listTextures.Count; i++)
            {
                MainGame.spriteBatch.Draw(listTextures[i], StatsDB.infos_texture_pos[i], Color.White);
            }
            // Dessine les textes
            for (int i = 0; i < listeTextes.Count; i++)
            {
                MainGame.spriteBatch.DrawString(MainGame.font, listeTextes[i], StatsDB.infos_texte_pos[i], Color.White);
            }
        }
    }
}
