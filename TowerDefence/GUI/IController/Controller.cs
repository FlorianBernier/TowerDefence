using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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

        // IController
        public abstract void UpdateGUI();
        public abstract void DrawGUI();


        // Méthode

       

        public void DrawDisplay(List<Texture2D> listTextures)
        {
            for (int i = 0; i < listTextures.Count; i++)
            {
                MainGame.spriteBatch.Draw(listTextures[i], StatsDB.infos_pos[i], Color.White);
            }
        }

        

    }
}
