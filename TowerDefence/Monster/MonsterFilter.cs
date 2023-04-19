﻿using System;
using System.Collections.Generic;

namespace TowerDefence
{
    public class MonsterFilter
    {
        List<Monster> liste;
        List<Monster> filtred;

        public MonsterFilter()
        { 
            this.liste = new List<Monster>();
            this.filtred = liste;
        }


        public MonsterFilter StartWave()
        {
            
            return this;
        }
        

        public MonsterFilter Add(EMonster type)
        {
            switch (type)
            {
                case EMonster.FIRE:
                    this.liste.Add(new Monster1());
                    break;
                case EMonster.ICE:
                    this.liste.Add(new Monster2());
                    break;
                case EMonster.POISON:
                    this.liste.Add(new Monster3());
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
