using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace TowerDefence
{
    public class TowerBuilder : Controller
    {
        // Type de la tour en construction
        public EBuilder type;

        // Indique si une tour doit être affichée à la position de la souris
        public bool drawTowerOnMouse = false;
        // Indique si le curseur de la souris doit être transparent
        public bool cursorTransparent = false;

        // Constructeur de la classe TowerBuilder
        public TowerBuilder()
        {

        }

        // Méthode qui sélectionne le bouton actuel à dessiner sur la grille
        public void SelectCurrentButtonToDraw()
        {
            drawTowerOnMouse = type == (EBuilder)boutonCliqueIndex ? !drawTowerOnMouse : false;
            type = (EBuilder)boutonCliqueIndex;
        }

        // Méthode qui ajoute une tour à la case actuelle si possible
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

        // Implémentation de la méthode abstraite UpdateGUI de la classe parent Controller
        public override void UpdateGUI()
        {
            MouseState mouseState = Mouse.GetState();

            // Vérifie si un bouton est cliqué dans la barre de construction
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

            // Vérifie si la souris est cliquée sur la grille du jeu
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


        // Méthode qui dessine le conteneur de la barre de construction
        public void DrawContainer()
        {
            for (int i = 0; i < StatsDB.builder_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(StatsDB.builder_texture[i], StatsDB.builder_pos[i], Color.White);
            }
        }

        // Méthode qui dessine la tour à la position de la souris si nécessaire
        public void DrawTowerOnMouse()
        {
            if (drawTowerOnMouse)
            {
                MouseState mouseState = Mouse.GetState();
                Vector2 towerPosition = new Vector2(mouseState.X - 32, mouseState.Y - 32);
                MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)type], towerPosition, Color.White);

                if (!cursorTransparent)
                {
                    // Change le curseur de la souris pour un curseur transparent
                    Mouse.SetCursor(MouseCursor.FromTexture2D(MainGame.mouseTransparent, 0, 0));
                    cursorTransparent = true;
                }
            }
            else
            {
                // Rétablit le curseur de la souris par défaut
                Mouse.SetCursor(MouseCursor.Arrow);
                cursorTransparent = false;
            }
        }

        // Implémentation de la méthode abstraite DrawGUI de la classe parent Controller
        public override void DrawGUI()
        {
            // Dessine le conteneur et l'affichage
            MainGame.spriteBatch.Draw(StatsDB.container_texture, StatsDB.container_pos, Color.White);
            MainGame.spriteBatch.Draw(StatsDB.display_texture, StatsDB.display_pos, Color.White);

            // Dessine les boutons de la barre de construction
            DrawContainer();

            // Si un bouton est sélectionné, affiche les informations correspondantes
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
            // Dessine la tour à la position de la souris si nécessaire
            DrawTowerOnMouse();
        }
    }
}
