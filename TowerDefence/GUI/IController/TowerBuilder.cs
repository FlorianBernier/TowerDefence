using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Diagnostics;

namespace TowerDefence
{
    public class TowerBuilder : IController
    {
        public EBuilder type;
        private int boutonCliqueIndex = -1;

        public TowerBuilder()
        {

        }

        public void DrawButton()
        {
            MainGame.spriteBatch.Draw(StatsDB.contener_texture, StatsDB.contener_pos, Color.White);

            for (int i = 0; i < StatsDB.builder_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(StatsDB.builder_texture[i], StatsDB.builder_pos[i], Color.White);
            }
        }

        public void Check()
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
        public void cafaitca()
        {
            if (boutonCliqueIndex != -1)
            {
                EBuilder type = (EBuilder)boutonCliqueIndex;
                switch (type)
                {
                    case EBuilder.FIRE_BUILD:
                        // Action pour le constructeur de feu
                        Debug.WriteLine("Action pour le constructeur de feu");
                        break;
                    case EBuilder.ICE_BUILD:
                        // Action pour le constructeur de glace
                        Debug.WriteLine("Action pour le constructeur de glace");
                        break;
                    case EBuilder.POISON_BUILD:
                        // Action pour le constructeur de poison
                        Debug.WriteLine("Action pour le constructeur de poison");
                        break;
                    case EBuilder.FLY_BUILD:
                        // Action pour le constructeur de volants
                        Debug.WriteLine("Action pour le constructeur de volants");
                        break;
                    case EBuilder.EARTH_BUILD:
                        // Action pour le constructeur de terre
                        Debug.WriteLine("Action pour le constructeur de terre");
                        break;
                    case EBuilder.SPECIAL1_BUILD:
                        // Action pour le constructeur spécial 1
                        Debug.WriteLine("Action pour le constructeur spécial 1");
                        break;
                    case EBuilder.SPECIAL2_BUILD:
                        // Action pour le constructeur spécial 2
                        Debug.WriteLine("Action pour le constructeur spécial 2");
                        break;
                    default:
                        // Si le type ne correspond à aucun constructeur
                        Debug.WriteLine("Type de constructeur non valide");
                        break;
                }
                boutonCliqueIndex = -1;
            }
        }
    }
}
