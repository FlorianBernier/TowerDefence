using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace TowerDefence
{
    public class TowerBuilder : Controller
    {
        public EBuilder type;

        public bool drawTowerOnMouse = false;
        public bool cursorTransparent = false;


        public TowerBuilder()
        {

        }

        
        // CheckClic
        public void SelectCurrentButtonToDraw()
        {
            drawTowerOnMouse = type == (EBuilder)boutonCliqueIndex ? !drawTowerOnMouse : false;
            type = (EBuilder)boutonCliqueIndex;
        }

        public void AddTowerCurrentCase()
        {
            if (drawTowerOnMouse)
            {
                GUI.towerFilter
                    .Add(
                        (ETower)type,
                        new Vector2(caseClickedX, caseClickedY));
            }
        }

        public override void UpdateGUI()
        {
            MouseState mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed &&
                mouseState.LeftButton != oldMouseState.LeftButton)
            {
                for (int i = 0; i < StatsDB.builder_pos.Count; i++)
                {
                    Rectangle buttonRectangle =
                        new Rectangle((int)StatsDB.builder_pos[i].X,
                                     (int)StatsDB.builder_pos[i].Y,
                                     StatsDB.builder_texture[i].Width,
                                     StatsDB.builder_texture[i].Height);

                    if (buttonRectangle.Contains(mouseState.Position))
                    {
                        boutonCliqueIndex = i;
                        SelectCurrentButtonToDraw();
                    }
                }
            }
            
            
            for (int x = 0; x < Map.mapWidth; x++)
            {
                for (int y = 0; y < Map.mapHeight; y++)
                {
                    Rectangle gridPos = 
                        new Rectangle(x * 64 + (int)Map.offsetMap.X,
                                      y * 64 + (int)Map.offsetMap.Y,
                                      64, 64);

                    if (gridPos.Contains(mouseState.Position) &&
                        mouseState.LeftButton == ButtonState.Pressed &&
                        mouseState.LeftButton != oldMouseState.LeftButton &&
                        Map.grid[y, x] == 1 &&
                        GUI.towerFilter.isEmpty(x, y))
                    {
                        caseClickedX = x;
                        caseClickedY = y;
                        AddTowerCurrentCase();
                    }
                }
            }
            oldMouseState = Mouse.GetState();
            drawTowerOnMouse = Mouse.GetState().RightButton == ButtonState.Pressed ? false : drawTowerOnMouse;
        }


        // Draw GUI
        public void DrawContainer()
        {
            for (int i = 0; i < StatsDB.builder_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(StatsDB.builder_texture[i], StatsDB.builder_pos[i], Color.White);
            }
        }

        public void DrawTowerOnMouse()
        {
            if (drawTowerOnMouse)
            {
                MouseState mouseState = Mouse.GetState();
                Vector2 towerPosition = new Vector2(mouseState.X - 32, mouseState.Y - 32);
                MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], towerPosition, Color.White);

                if (!cursorTransparent)
                {
                    Mouse.SetCursor(MouseCursor.FromTexture2D(MainGame.mouseTransparent, 0, 0));
                    cursorTransparent = true;
                }
            }
            else
            {
                Mouse.SetCursor(MouseCursor.Arrow);
                cursorTransparent = false;
            }
        }

        public override void DrawGUI()
        {
            // Container
            MainGame.spriteBatch.Draw(StatsDB.container_texture, StatsDB.container_pos, Color.White);
            // Display
            MainGame.spriteBatch.Draw(StatsDB.display_texture, StatsDB.display_pos, Color.White);

            DrawContainer();

            if (boutonCliqueIndex != -1)
            {
                EBuilder type = (EBuilder)boutonCliqueIndex;
                switch (type)
                {
                    case EBuilder.FIRE_BUILD:
                        DrawDisplay(StatsDB.infos_fire_texture, StatsDB.infos_fire_texte);
                        break;
                    case EBuilder.ICE_BUILD:
                        DrawDisplay(StatsDB.infos_ice_texture, StatsDB.infos_ice_texte);
                        break;
                    case EBuilder.POISON_BUILD:
                        DrawDisplay(StatsDB.infos_poison_texture, StatsDB.infos_poison_texte);
                        break;
                    case EBuilder.FLY_BUILD:
                        DrawDisplay(StatsDB.infos_fly_texture, StatsDB.infos_fly_texte);
                        break;
                    case EBuilder.EARTH_BUILD:
                        DrawDisplay(StatsDB.infos_earth_texture, StatsDB.infos_earth_texte);
                        break;
                    case EBuilder.SPECIAL1_BUILD:
                        DrawDisplay(StatsDB.infos_special1_texture, StatsDB.infos_special1_texte);
                        break;
                    case EBuilder.SPECIAL2_BUILD:
                        DrawDisplay(StatsDB.infos_special2_texture, StatsDB.infos_special2_texte);
                        break;
                    default:
                        Debug.WriteLine("ERROR TowerBuidler : invalid constructor");
                        break;
                }
            }
            DrawTowerOnMouse();
        }
    }
}
