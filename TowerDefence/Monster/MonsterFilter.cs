using System;
using System.Collections.Generic;

namespace TowerDefence
{
    // Classe responsable de la gestion des filtres pour les monstres
    public class MonsterFilter
    {
        // Liste principale de tous les monstres
        public static List<Monster> liste;
        // Liste filtrée de monstres
        public static List<Monster> filtred;

        // Constructeur de la classe MonsterFilter
        public MonsterFilter()
        {
            // Initialise la liste principale et la liste filtrée
            liste = new List<Monster>();
            filtred = liste;
        }

        // Méthode pour ajouter un monstre du type spécifié à la liste principale
        public MonsterFilter Add(EMonster type)
        {
            switch (type)
            {
                // Ajoute un monstre du type spécifié à la liste principale
                case EMonster.FIRE:
                    liste.Add(new MonsterFire());
                    break;
                case EMonster.ICE:
                    liste.Add(new MonsterIce());
                    break;
                case EMonster.POISON:
                    liste.Add(new MonsterPoison());
                    break;
                case EMonster.WATER:
                    liste.Add(new MonsterWather());
                    break;
                case EMonster.WIND:
                    liste.Add(new MonsterWind());
                    break;
                case EMonster.LIGHT:
                    liste.Add(new MonsterLight());
                    break;
                case EMonster.DARK:
                    liste.Add(new MonsterDark());
                    break;
                case EMonster.ELECTRIC:
                    liste.Add(new MonsterElectric());
                    break;
                case EMonster.PSYCHIC:
                    liste.Add(new MonsterPsychic());
                    break;
                default:
                    throw new Exception("ERROR TYPE INCONNU");
            }
            return this;
        }

        // Méthode pour filtrer tous les monstres
        public MonsterFilter all()
        {
            // Affecte la liste principale à la liste filtrée
            filtred = liste;
            return this;
        }

        // Méthode pour déplacer tous les monstres dans la liste filtrée
        public MonsterFilter Move()
        {
            filtred.ForEach(monstre => monstre.Move());
            return this;
        }

        // Méthode pour dessiner tous les monstres dans la liste filtrée
        public MonsterFilter Draw()
        {
            filtred.ForEach(monstre => monstre.Draw());
            return this;
        }

        // Méthode pour supprimer tous les monstres marqués pour suppression dans la liste principale
        public MonsterFilter Remove()
        {
            liste.RemoveAll(monstre => monstre.remove);
            return this;
        }

        // Méthode pour construire la liste de monstres
        public List<Monster> Build()
        {
            return liste;
        }
    }
}
