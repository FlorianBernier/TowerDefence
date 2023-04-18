using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public MonsterFilter MoveMonsters()
        {
            filtred.ForEach(monstre => monstre.MoveMonster());
            return this;
        }

        public MonsterFilter Draw()
        {
            filtred.ForEach(monstre => monstre.DrawMonster());
            return this;
        }


        public List<Monster> Build()
        {
            return liste;
        }
    }
}
