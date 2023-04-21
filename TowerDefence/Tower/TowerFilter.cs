using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class TowerFilter
    {
        List<Tower> liste;
        List<Tower> filtred;
        public TowerFilter() 
        {
            this.liste = new List<Tower>();
            this.filtred = liste;
        }


        public TowerFilter Add(ETower type)
        {
            switch (type)
            {
                case ETower.FIRE:
                    this.liste.Add(new TowerFire());
                    break;
                case ETower.ICE:
                    this.liste.Add(new TowerIce());
                    break;
                case ETower.POISON:
                    this.liste.Add(new TowerPoison());
                    break;
                case ETower.FLY:
                    this.liste.Add(new TowerFly());
                    break;
                case ETower.EARTH:
                    this.liste.Add(new TowerEarth());
                    break;
                case ETower.SPECIAL1:
                    this.liste.Add(new TowerSpecial1());
                    break;
                case ETower.SPECIAL2:
                    this.liste.Add(new TowerSpecial2());
                    break;
                default:
                    throw new Exception("ERROR TYPE INCONNU");
            }
            return this;
        }

        public TowerFilter all()
        {
            filtred = liste;
            return this;
        }

        public TowerFilter Draw()
        {
            filtred.ForEach(tower => tower.Draw());
            return this;
        }

        public List<Tower> Build()
        {
            return liste;
        }

    }
}
