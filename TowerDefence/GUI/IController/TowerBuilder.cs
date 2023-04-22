using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Diagnostics;

namespace TowerDefence
{
    public class TowerBuilder : Controller
    {
        public EBuilder type;

        public EBuilder towerSelectedToDraw;
        public bool weWantToDrawTowerOnMouse = false;


        public TowerBuilder()
        {

        }

        public override void DrawGUI()
        {
            MainGame.spriteBatch.Draw(StatsDB.contener_texture, StatsDB.contener_pos, Color.White);
            MainGame.spriteBatch.Draw(StatsDB.afficher_texture, StatsDB.afficher_pos, Color.White);


            for (int i = 0; i < StatsDB.builder_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(StatsDB.builder_texture[i], StatsDB.builder_pos[i], Color.White);
            }
        }

        public override void DrawTowerOnMouse()
        {
            if (weWantToDrawTowerOnMouse)
            {
                MouseState mouseState = Mouse.GetState();
                Vector2 towerPosition = new Vector2(mouseState.X - 32, mouseState.Y - 32);
                MainGame.spriteBatch.Draw(TowerDB.tower_texture[(int)towerSelectedToDraw], towerPosition, Color.White);


                Mouse.SetCursor(MouseCursor.FromTexture2D(MainGame.mouseTransparent, 0, 0));
                Mouse.SetCursor(MouseCursor.Arrow);
            }
        }


        public override void Update()
        {
            weWantToDrawTowerOnMouse = Mouse.GetState().RightButton == ButtonState.Pressed ? false : weWantToDrawTowerOnMouse;
        }

        public override void Afficher()
        {
            if (boutonCliqueIndex != -1)
            {
                EBuilder type = (EBuilder)boutonCliqueIndex;
                switch (type)
                {
                    case EBuilder.FIRE_BUILD:
                        for (int i = 0; i < StatsDB.fire_infos_texture.Count; i++)
                        {
                            MainGame.spriteBatch.Draw(StatsDB.fire_infos_texture[i], StatsDB.infos_pos[i], Color.White);
                        }
                        break;
                    case EBuilder.ICE_BUILD:
                        for (int i = 0; i < StatsDB.ice_infos_texture.Count; i++)
                        {
                            MainGame.spriteBatch.Draw(StatsDB.ice_infos_texture[i], StatsDB.infos_pos[i], Color.White);
                        }
                        break;
                    case EBuilder.POISON_BUILD:
                        for (int i = 0; i < StatsDB.poison_infos_texture.Count; i++)
                        {
                            MainGame.spriteBatch.Draw(StatsDB.poison_infos_texture[i], StatsDB.infos_pos[i], Color.White);
                        }
                        break;
                    case EBuilder.FLY_BUILD:
                        for (int i = 0; i < StatsDB.fly_infos_texture.Count; i++)
                        {
                            MainGame.spriteBatch.Draw(StatsDB.fly_infos_texture[i], StatsDB.infos_pos[i], Color.White);
                        }
                        break;
                    case EBuilder.EARTH_BUILD:
                        for (int i = 0; i < StatsDB.earth_infos_texture.Count; i++)
                        {
                            MainGame.spriteBatch.Draw(StatsDB.earth_infos_texture[i], StatsDB.infos_pos[i], Color.White);
                        }
                        break;
                    case EBuilder.SPECIAL1_BUILD:
                        for (int i = 0; i < StatsDB.special1_infos_texture.Count; i++)
                        {
                            MainGame.spriteBatch.Draw(StatsDB.special1_infos_texture[i], StatsDB.infos_pos[i], Color.White);
                        }
                        break;
                    case EBuilder.SPECIAL2_BUILD:
                        for (int i = 0; i < StatsDB.special2_infos_texture.Count; i++)
                        {
                            MainGame.spriteBatch.Draw(StatsDB.special2_infos_texture[i], StatsDB.infos_pos[i], Color.White);
                        }
                        break;
                    default:
                        // Si le type ne correspond à aucun constructeur
                        Debug.WriteLine("Type de constructeur non valide");
                        break;
                }
                //boutonCliqueIndex = -1;
            }
        }

        public override void SelectCurrentButtonToDraw()
        {
            weWantToDrawTowerOnMouse = towerSelectedToDraw == (EBuilder)boutonCliqueIndex ? !weWantToDrawTowerOnMouse : false;
            towerSelectedToDraw = (EBuilder)boutonCliqueIndex;
        }


        public override void SelectCurrentCase()
        {
            if (weWantToDrawTowerOnMouse)
            {
                GUI.towerFilter
                    .Add(
                        (ETower)towerSelectedToDraw,
                        new Vector2(caseClickedX, caseClickedY));
            }
        }

    }
}
