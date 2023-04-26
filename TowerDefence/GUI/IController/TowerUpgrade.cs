using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.DirectWrite;
using System.Collections.Generic;
using System.Diagnostics;

namespace TowerDefence
{
    public class TowerUpgrade : Controller
    {
        public void DrawUpgradeMenu(List<Texture2D> listTextures, List<Texture2D> infos_texture)
        {
            for (int i = 0; i < listTextures.Count; i++)
            {
                MainGame.spriteBatch.Draw(listTextures[i], StatsDB.upgrade_pos[i], Color.White);
            }
            for (int i = 0; i < infos_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(infos_texture[i], StatsDB.infos_pos[i], Color.White);
            }
        }
        public override void DrawGUI()
        {
            MainGame.spriteBatch.Draw(StatsDB.contener_texture, StatsDB.contener_pos, Color.White);
            MainGame.spriteBatch.Draw(StatsDB.afficher_texture, StatsDB.afficher_pos, Color.White);

            if (GUI.currentTower != null)
            {
                switch (GUI.currentTower.type)
                {
                    case ETower.FIRE:
                        DrawUpgradeMenu(StatsDB.upgrade_fire_texture, StatsDB.fire_infos_texture);
                        break;
                    case ETower.ICE:
                        DrawUpgradeMenu(StatsDB.upgrade_fire_texture, StatsDB.ice_infos_texture);
                        break;
                    case ETower.POISON:
                        DrawUpgradeMenu(StatsDB.upgrade_fire_texture, StatsDB.poison_infos_texture);
                        break;
                    case ETower.FLY:
                        DrawUpgradeMenu(StatsDB.upgrade_fire_texture, StatsDB.fly_infos_texture);
                        break;
                    case ETower.EARTH:
                        DrawUpgradeMenu(StatsDB.upgrade_fire_texture, StatsDB.earth_infos_texture);
                        break;
                    case ETower.SPECIAL1:
                        DrawUpgradeMenu(StatsDB.upgrade_fire_texture, StatsDB.special1_infos_texture);
                        break;
                    case ETower.SPECIAL2:
                        DrawUpgradeMenu(StatsDB.upgrade_fire_texture, StatsDB.special2_infos_texture);
                        break;
                    default:
                        break;
                }
            }
        }
        public override void DrawTowerOnMouse()
        {

        }


        public override void Afficher()
        {

        }

        public override void SelectCurrentButtonToDraw()
        {
        }

        public override void SelectCurrentCase()
        {
        }

        public override void Update()
        {
        }
    }
}




