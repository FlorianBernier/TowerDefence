using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace TowerDefence
{
    public class TowerBuilder : Controller
    {
        public EBuilder type;

        public bool drawTowerOnMouse = false;


        public TowerBuilder()
        {

        }

        
        public void DrawTowerOnMouse()
        {
            if (drawTowerOnMouse)
            {
                MouseState mouseState = Mouse.GetState();
                Vector2 towerPosition = new Vector2(mouseState.X - 32, mouseState.Y - 32);
                MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], towerPosition, Color.White);

                Mouse.SetCursor(MouseCursor.FromTexture2D(MainGame.mouseTransparent, 0, 0));
            }
            else
            {
                Mouse.SetCursor(MouseCursor.Arrow);
            }
        }

        public void DrawBuilderMenu(List<Texture2D> listTextures)
        {
            for (int i = 0; i < listTextures.Count; i++)
            {
                MainGame.spriteBatch.Draw(listTextures[i], StatsDB.infos_pos[i], Color.White);
            }
        }


        //-------------------------------//


        public override void DrawGUI()
        {
            MainGame.spriteBatch.Draw(StatsDB.contener_texture, StatsDB.contener_pos, Color.White);
            MainGame.spriteBatch.Draw(StatsDB.afficher_texture, StatsDB.afficher_pos, Color.White);

            for (int i = 0; i < StatsDB.builder_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(StatsDB.builder_texture[i], StatsDB.builder_pos[i], Color.White);
            }

            if (boutonCliqueIndex != -1)
            {
                EBuilder type = (EBuilder)boutonCliqueIndex;
                switch (type)
                {
                    case EBuilder.FIRE_BUILD:
                        DrawBuilderMenu(StatsDB.fire_infos_texture);
                        break;
                    case EBuilder.ICE_BUILD:
                        DrawBuilderMenu(StatsDB.ice_infos_texture);
                        break;
                    case EBuilder.POISON_BUILD:
                        DrawBuilderMenu(StatsDB.poison_infos_texture);
                        break;
                    case EBuilder.FLY_BUILD:
                        DrawBuilderMenu(StatsDB.fly_infos_texture);
                        break;
                    case EBuilder.EARTH_BUILD:
                        DrawBuilderMenu(StatsDB.earth_infos_texture);
                        break;
                    case EBuilder.SPECIAL1_BUILD:
                        DrawBuilderMenu(StatsDB.special1_infos_texture);
                        break;
                    case EBuilder.SPECIAL2_BUILD:
                        DrawBuilderMenu(StatsDB.special2_infos_texture);
                        break;
                    default:
                        // Si le type ne correspond à aucun constructeur
                        Debug.WriteLine("Type de constructeur non valide");
                        break;
                }
            }
            DrawTowerOnMouse();
        }

        public override void CheckClic()
        {
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

                for (int x = 0; x < Map.mapWidth; x++)
                {
                    for (int y = 0; y < Map.mapHeight; y++)
                    {
                        Rectangle gridPos = new Rectangle(x * 64 + (int)Map.offsetMap.X, y * 64 + (int)Map.offsetMap.Y, 64, 64);
                        if (gridPos.Contains(mouseState.Position) &&
                            mouseState.LeftButton == ButtonState.Pressed &&
                            mouseState.LeftButton != oldMouseState.LeftButton &&
                            Map.grid[y, x] == 1 &&
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




        public override void Update()
        {
            drawTowerOnMouse = Mouse.GetState().RightButton == ButtonState.Pressed ? false : drawTowerOnMouse;
        }

        

        public override void SelectCurrentButtonToDraw()
        {
            drawTowerOnMouse = type == (EBuilder)boutonCliqueIndex ? !drawTowerOnMouse : false;
            type = (EBuilder)boutonCliqueIndex;
        }


        public override void SelectCurrentCase()
        {
            if (drawTowerOnMouse)
            {
                GUI.towerFilter
                    .Add(
                        (ETower)type,
                        new Vector2(caseClickedX, caseClickedY));
            }
        }

    }
}
