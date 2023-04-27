using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace TowerDefence
{
    public abstract class Controller : IController
    {
        public MouseState oldMouseState;
        public int boutonCliqueIndex = -1;
        public int caseClickedX = -1;
        public int caseClickedY = -1;

        public Controller() 
        {
        
        }

        public abstract void DrawGUI();

        public abstract void CheckClic();
        

        public abstract void Update();


        public abstract void SelectCurrentButtonToDraw();

        public abstract void SelectCurrentCase();

        

        
    }
}
