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
        public static int caseClickedX = -1;
        public static int caseClickedY = -1;

        public Controller() 
        {
        
        }

        // IController
        public abstract void UpdateGUI();
        public abstract void DrawGUI();


        // Méthode commune 
        public void DrawDisplay(List<Texture2D> listTextures, List<string> listeTextes)
        {
            for (int i = 0; i < listTextures.Count; i++)
            {
                MainGame.spriteBatch.Draw(listTextures[i], StatsDB.infos_texture_pos[i], Color.White);
            }
            for (int i = 0; i < listeTextes.Count; i++)
            {
                MainGame.spriteBatch.DrawString(MainGame.font, listeTextes[i], StatsDB.infos_texte_pos[i], Color.White);
            }
        }

        

    }
}
