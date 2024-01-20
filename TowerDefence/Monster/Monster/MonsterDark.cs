using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    // Classe représentant un monstre de type DARK (ténèbres) dans le jeu
    public class MonsterDark : Monster
    {
        // Constructeur de la classe MonsterDark
        public MonsterDark()
        {
            // Définition du type du monstre comme étant DARK
            type = EMonster.DARK;
        }
    }
}