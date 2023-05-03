using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace TowerDefence
{
    public class SpellFilter
    {
        List<Spell> liste;
        List<Spell> filtred;
        public SpellFilter() 
        {
            this.liste = new List<Spell>();
            this.filtred = liste;
        }

        public SpellFilter Add(ETower type, Vector2 pos)
        {
            switch (type)
            {
                case ETower.FIRE:
                    this.liste.Add(new SpellFire(pos));
                    break;
                case ETower.ICE:
                    this.liste.Add(new SpellIce(pos));
                    break;
                case ETower.POISON:
                    this.liste.Add(new SpellPoison(pos));
                    break;
                case ETower.FLY:
                    this.liste.Add(new SpellFly(pos));
                    break;
                case ETower.EARTH:
                    this.liste.Add(new SpellEarth(pos));
                    break;
                case ETower.SPECIAL1:
                    this.liste.Add(new SpellSpecial1(pos));
                    break;
                case ETower.SPECIAL2:
                    this.liste.Add(new SpellSpecial2(pos));
                    break;
                default:
                    throw new Exception("SpellFilter : ERROR TYPE INCONNU");
            }
            return this;
        }

        public SpellFilter all()
        {
            filtred = liste;
            return this;
        }

        public SpellFilter DrawSpell()
        {
            filtred.ForEach(spell => spell.DrawSpell());
            return this;
        }
    }
}
