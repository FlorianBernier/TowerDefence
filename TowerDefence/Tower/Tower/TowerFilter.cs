using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

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

        public TowerFilter AddSpell()
        {
            filtred.ForEach((tower) => tower.AddSpell());
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

        public Tower TowerSelected()
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
