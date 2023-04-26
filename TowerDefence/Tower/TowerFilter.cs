using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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


        public TowerFilter Add(ETower type, Vector2 pos)
        {
            switch (type)
            {
                case ETower.FIRE:
                    this.liste.Add(new TowerFire(pos));
                    break;
                case ETower.ICE:
                    this.liste.Add(new TowerIce(pos));
                    break;
                case ETower.POISON:
                    this.liste.Add(new TowerPoison(pos));
                    break;
                case ETower.FLY:
                    this.liste.Add(new TowerFly(pos));
                    break;
                case ETower.EARTH:
                    this.liste.Add(new TowerEarth(pos));
                    break;
                case ETower.SPECIAL1:
                    this.liste.Add(new TowerSpecial1(pos));
                    break;
                case ETower.SPECIAL2:
                    this.liste.Add(new TowerSpecial2(pos));
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

        public bool isEmpty(int x, int y)
        {
            return liste.FindAll(tower => (tower.position.X == x && tower.position.Y == y)).Count > 0 ? false : true ;
        }

        public Tower IsChoosed()
        {
            Tower testContainsMouse = null;
            MouseState mouseState = Mouse.GetState();
            filtred.ForEach(tower =>
            {
                if (tower.towerRect.Contains(mouseState.Position)) testContainsMouse = tower;
            });
            return testContainsMouse;
        }
    }
}
