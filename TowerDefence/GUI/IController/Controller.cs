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
        public abstract void DrawTowerOnMouse();

        public abstract void Afficher();
        public abstract void SelectCurrentButtonToDraw();

        public abstract void SelectCurrentCase();

        public abstract void Update();

        public void CheckClic()
        {
            MouseState mouseState = Mouse.GetState();
            // Vérifie chaque bouton du builder
            for (int i = 0; i < StatsDB.builder_pos.Count; i++)
            {
                // Vérifie si la souris est en collision avec le bouton
                Rectangle buttonRectangle = new Rectangle((int)StatsDB.builder_pos[i].X, (int)StatsDB.builder_pos[i].Y, StatsDB.builder_texture[i].Width, StatsDB.builder_texture[i].Height);
                if (buttonRectangle.Contains(mouseState.Position) && mouseState.LeftButton == ButtonState.Pressed && mouseState.LeftButton != oldMouseState.LeftButton)
                {
                    boutonCliqueIndex = i;
                    SelectCurrentButtonToDraw();
                }
            }
            //oldMouseState = Mouse.GetState();

            for (int x = 0; x < Map.mapWidth; x++)
            {
                for (int y = 0; y < Map.mapHeight; y++)
                {
                    Rectangle gridPos = new Rectangle(x * 64 + (int)Map.offsetMap.X, y * 64 + (int)Map.offsetMap.Y, 64, 64);
                    if (gridPos.Contains(mouseState.Position) && 
                        mouseState.LeftButton == ButtonState.Pressed && 
                        mouseState.LeftButton != oldMouseState.LeftButton &&
                        Map.grid[y,x] == 1 &&
                        GUI.towerFilter.isEmpty(x, y))
                    {
                        caseClickedX = x;
                        caseClickedY = y;
                        SelectCurrentCase();
                    }
                }
            }
            oldMouseState = Mouse.GetState();
        }
    }
}
