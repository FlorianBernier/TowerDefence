using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public interface IController
    {

        public void DrawGUI();

        public void DrawTowerOnMouse();
        public void CheckClic();

        public void Afficher();
        public void SelectCurrentButtonToDraw();

        public void Update();

    }
}
