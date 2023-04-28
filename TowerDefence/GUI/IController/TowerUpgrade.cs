using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace TowerDefence
{

    public class TowerUpgrade : Controller
    {


        public TowerUpgrade() 
        {
        
        }

        // CheckClic
        public override void UpdateGUI()
        {
            MouseState mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed &&
                mouseState.LeftButton != oldMouseState.LeftButton)
            {

                for (int i = 0; i < StatsDB.upgrade_pos.Count; i++)
                {
                    Rectangle buttonRectangle =
                        new Rectangle((int)StatsDB.upgrade_pos[i].X,
                                        (int)StatsDB.upgrade_pos[i].Y,
                                        StatsDB.upgrade_fire_texture[i].Width,
                                        StatsDB.upgrade_fire_texture[i].Height);

                    if (buttonRectangle.Contains(mouseState.Position))
                    {
                        GUI.currentTower.competence = i;
                    }
                }
            }
        }

        // Draw GUI
        public void DrawContainer(List<Texture2D> listTextures)
        {
            for (int i = 0; i < listTextures.Count; i++)
            {
                MainGame.spriteBatch.Draw(listTextures[i], StatsDB.upgrade_pos[i], Color.White);
            }
        }

        public override void DrawGUI()
        {
            // Container
            MainGame.spriteBatch.Draw(StatsDB.container_texture, StatsDB.container_pos, Color.White);
            // Display
            MainGame.spriteBatch.Draw(StatsDB.display_texture, StatsDB.display_pos, Color.White);
            // Return Builder
            MainGame.spriteBatch.Draw(StatsDB.return_builder_texture, StatsDB.return_builder_pos, Color.White);

            if (GUI.tower != null)
            {
                GUI.currentTower = GUI.tower;
            }
            if (GUI.currentTower != null)
            { 
                switch (GUI.currentTower.type)
                {
                    case ETower.FIRE:
                        DrawContainer(StatsDB.upgrade_fire_texture);
                        DrawDisplay(StatsDB.infos_fire_texture, StatsDB.infos_fire_texte);
                        break;
                    case ETower.ICE:
                        DrawContainer(StatsDB.upgrade_ice_texture);
                        DrawDisplay(StatsDB.infos_ice_texture, StatsDB.infos_ice_texte);
                        break;
                    case ETower.POISON:
                        DrawContainer(StatsDB.upgrade_poison_texture);
                        DrawDisplay(StatsDB.infos_poison_texture, StatsDB.infos_poison_texte);
                        break;
                    case ETower.FLY:
                        DrawContainer(StatsDB.upgrade_fly_texture);
                        DrawDisplay(StatsDB.infos_fly_texture, StatsDB.infos_fly_texte);
                        break;
                    case ETower.EARTH:
                        DrawContainer(StatsDB.upgrade_earth_texture);
                        DrawDisplay(StatsDB.infos_earth_texture, StatsDB.infos_earth_texte);
                        break;
                    case ETower.SPECIAL1:
                        DrawContainer(StatsDB.upgrade_special1_texture);
                        DrawDisplay(StatsDB.infos_special1_texture, StatsDB.infos_special1_texte);
                        break;
                    case ETower.SPECIAL2:
                        DrawContainer(StatsDB.upgrade_special2_texture);
                        DrawDisplay(StatsDB.infos_special2_texture, StatsDB.infos_special2_texte);
                        break;
                    default:
                        Debug.WriteLine("ERROR TowerUpgrade : invalid constructor");
                        break;
                }
                Mouse.SetCursor(MouseCursor.Arrow);

                if (GUI.currentTower.competence >= 0)
                {
                    Vector2 position = StatsDB.upgrade_pos[GUI.currentTower.competence];
                    MainGame.spriteBatch.Draw(StatsDB.upgrade_active_texture, position, Color.White); 
                }
            }
        }
    }
}




