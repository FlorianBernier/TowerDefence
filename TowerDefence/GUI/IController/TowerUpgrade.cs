using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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

            if (GUI.currentTower != null)
            {
                switch (GUI.currentTower.type)
                {
                    case ETower.FIRE:
                        DrawContainer(StatsDB.upgrade_fire_texture);
                        DrawDisplay(StatsDB.infos_fire_texture);
                        break;
                    case ETower.ICE:
                        DrawContainer(StatsDB.upgrade_ice_texture);
                        DrawDisplay(StatsDB.infos_ice_texture);
                        break;
                    case ETower.POISON:
                        DrawContainer(StatsDB.upgrade_poison_texture);
                        DrawDisplay(StatsDB.infos_poison_texture);
                        break;
                    case ETower.FLY:
                        DrawContainer(StatsDB.upgrade_fly_texture);
                        DrawDisplay(StatsDB.infos_fly_texture);
                        break;
                    case ETower.EARTH:
                        DrawContainer(StatsDB.upgrade_earth_texture);
                        DrawDisplay(StatsDB.infos_earth_texture);
                        break;
                    case ETower.SPECIAL1:
                        DrawContainer(StatsDB.upgrade_special1_texture);
                        DrawDisplay(StatsDB.infos_special1_texture);
                        break;
                    case ETower.SPECIAL2:
                        DrawContainer(StatsDB.upgrade_special2_texture);
                        DrawDisplay(StatsDB.infos_special2_texture);
                        break;
                    default:
                        break;
                }
                Mouse.SetCursor(MouseCursor.Arrow);
            }
        }

        
    }
}




