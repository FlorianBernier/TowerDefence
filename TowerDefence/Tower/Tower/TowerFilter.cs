using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace TowerDefence
{
    // Classe représentant un filtre pour les tours dans le jeu
    public class TowerFilter
    {
        // Liste de toutes les tours présentes dans le jeu
        List<Tower> liste;
        // Liste filtrée de tours
        List<Tower> filtred;

        // Constructeur de la classe TowerFilter
        public TowerFilter() 
        {
            this.liste = new List<Tower>();
            // Initialise la liste filtrée comme étant la liste complète
            this.filtred = liste;
        }

        // Méthode pour ajouter une tour à la liste en fonction de son type et de sa position
        public TowerFilter Add(ETower type, Vector2 pos)
        {
            switch (type)
            {
                case ETower.FIRE:
                    // Ajoute une tour de type "Feu" à la liste et ajuste les ressources du joueur
                    this.liste.Add(new TowerFire(pos));
                    StatsDB.playerOR = StatsDB.playerOR - TowerDB.tower_or[0];
                    break;
                case ETower.ICE:
                    this.liste.Add(new TowerIce(pos));
                    StatsDB.playerOR = StatsDB.playerOR - TowerDB.tower_or[1];
                    break;
                case ETower.POISON:
                    this.liste.Add(new TowerPoison(pos));
                    StatsDB.playerOR = StatsDB.playerOR - TowerDB.tower_or[2];
                    break;
                case ETower.FLY:
                    this.liste.Add(new TowerFly(pos));
                    StatsDB.playerOR = StatsDB.playerOR - TowerDB.tower_or[3];
                    break;
                case ETower.EARTH:
                    this.liste.Add(new TowerEarth(pos));
                    StatsDB.playerOR = StatsDB.playerOR - TowerDB.tower_or[4];
                    break;
                case ETower.SPECIAL1:
                    this.liste.Add(new TowerSpecial1(pos));
                    StatsDB.playerOR = StatsDB.playerOR - TowerDB.tower_or[5];
                    StatsDB.playerWood = StatsDB.playerWood - TowerDB.tower_wood[5];
                    break;
                case ETower.SPECIAL2:
                    this.liste.Add(new TowerSpecial2(pos));
                    StatsDB.playerOR = StatsDB.playerOR - TowerDB.tower_or[6];
                    StatsDB.playerWood = StatsDB.playerWood - TowerDB.tower_wood[6];
                    break;
                default:
                    throw new Exception("TowerFilter : ERROR TYPE INCONNU");
            }
            return this;
        }

        // Méthode pour afficher toutes les tours sans aucun filtre
        public TowerFilter all()
        {
            filtred = liste;
            return this;
        }

        // Méthode pour afficher toutes les tours dans la liste filtrée
        public TowerFilter Draw()
        {
            filtred.ForEach(tower => tower.Draw());
            return this;
        }

        // Méthode pour ajouter un sort à toutes les tours dans la liste filtrée
        public TowerFilter AddSpell()
        {
            filtred.ForEach((tower) => tower.AddSpell());
            return this;
        }

        // Méthode pour construire la liste complète des tours
        public List<Tower> Build()
        {
            return liste;
        }

        // Méthode pour vérifier si une case spécifique est vide (aucune tour dessus)
        public bool isEmpty(int x, int y)
        {
            return liste.FindAll(tower => (tower.position.X == x && tower.position.Y == y)).Count > 0 ? false : true ;
        }

        // Méthode pour sélectionner la tour sous la souris
        public Tower TowerSelected()
        {
            Tower testContainsMouse = null;
            // Parcourt toutes les tours filtrées pour vérifier si la souris est au-dessus de l'une d'entre elles
            MouseState mouseState = Mouse.GetState();
            filtred.ForEach(tower =>
            {
                if (tower.towerRect.Contains(mouseState.Position)) testContainsMouse = tower;
            });
            return testContainsMouse;
        }

        
    }
}
