using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Configuration;

namespace TowerDefence
{
    // Classe abstraite représentant une tour dans le jeu
    public abstract class Tower : ITower
    {
        // Information générale des tours
        public ETower type;
        public Vector2 position;
        public Rectangle towerRect;
        private Vector2 posOffset;
        public int competence = -1;

        // Minuterie pour gérer le temps entre les lancements de sorts
        private TimerMiliseconde spellTimer;

        // Constructeur de la classe Tower
        public Tower(Vector2 pos) 
        {
            this.position = pos;
            // Calcul du décalage de position en fonction de la grille
            posOffset = new Vector2(position.X * 64 + (int)Map.offsetMap.X, position.Y * 64 + (int)Map.offsetMap.Y);
            // Initialisation du rectangle représentant la position et les dimensions de la tour
            towerRect = new Rectangle((int)posOffset.X, (int)posOffset.Y, 64, 64);

            // Initialisation de la minuterie pour le sort avec un intervalle en millisecondes
            spellTimer = new TimerMiliseconde(200);
        }

        // Méthode pour ajouter un sort à la tour
        public void AddSpell()
        {
            if ( spellTimer.elapsed())
            {
                MainGameTD.spellFilter
                .Add(
                    (ESpell)type, position);
                spellTimer.restart();
            }
        }

        // Méthode pour dessiner la tour sur l'écran
        public void Draw()
        {
            // Dessine la texture de la tour à la position calculée
            MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], posOffset, Color.White);
        }
    }
}
