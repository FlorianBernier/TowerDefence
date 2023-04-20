using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace TowerDefence
{
    public abstract class Controller : IController
    {
        public int boutonCliqueIndex = -1;
        public Controller() 
        {
        
        }

        public abstract void Draw();

        public abstract void Afficher();
        public abstract void cafaitca();

        public void CheckClic()
        {
            MouseState mouseState = Mouse.GetState();
            // Vérifie chaque bouton du builder
            for (int i = 0; i < StatsDB.builder_pos.Count; i++)
            {
                // Vérifie si la souris est en collision avec le bouton
                Rectangle buttonRectangle = new Rectangle((int)StatsDB.builder_pos[i].X, (int)StatsDB.builder_pos[i].Y, StatsDB.builder_texture[i].Width, StatsDB.builder_texture[i].Height);
                if (buttonRectangle.Contains(mouseState.Position) && mouseState.LeftButton == ButtonState.Pressed)
                {
                    boutonCliqueIndex = i;
                }
            }
        }

        
    }
}
