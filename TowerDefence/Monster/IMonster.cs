using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    // Interface décrivant le comportement général d'un monstre
    public interface IMonster
    {
        // img
        // position
        // vitesse
        // logique de deplacement

        // add
        // timer
        // delete


        // PV
        // Mana 
        // air
        // sol
        // invisible 

        // Méthodes pour dessiner, déplacer et construire le monstre
        public void Draw();
        public void Move();
        public void Build();

    }
}
