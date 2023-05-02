using System;
using System.Collections.Generic;

namespace TowerDefence
{
    public class MonsterFilter
    {
        public static List<Monster> liste;
        public static List<Monster> filtred;

        public MonsterFilter()
        { 
            liste = new List<Monster>();
            filtred = liste;
        }


        public MonsterFilter Add(EMonster type)
        {
            switch (type)
            {
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


        public MonsterFilter all()
        {
            filtred = liste;
            return this;
        }


        public MonsterFilter Move()
        {
            filtred.ForEach(monstre => monstre.Move());
            return this;
        }

        public MonsterFilter Draw()
        {
            filtred.ForEach(monstre => monstre.Draw());
            return this;
        }

        public MonsterFilter Remove()
        {
            liste.RemoveAll(monstre => monstre.remove);
            return this;
        }

        public List<Monster> Build()
        {
            return liste;
        }
    }
}
