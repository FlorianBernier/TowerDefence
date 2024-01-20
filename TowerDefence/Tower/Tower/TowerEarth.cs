using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    // Classe représentant une tour de type "Terre" dans le jeu
    public class TowerEarth : Tower
    {
        // Constructeur de la classe TowerEarth
        public TowerEarth(Vector2 pos) : base(pos)
        {
            type = ETower.EARTH;
        }

    }
}
