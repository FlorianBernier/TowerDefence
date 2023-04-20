using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Diagnostics;

namespace TowerDefence
{
    public class TowerBuilder : Controller
    {
        public EBuilder type;
        

        public TowerBuilder()
        {

        }

        public override void Draw()
        {
            MainGame.spriteBatch.Draw(StatsDB.contener_texture, StatsDB.contener_pos, Color.White);
            MainGame.spriteBatch.Draw(StatsDB.afficher_texture, StatsDB.afficher_pos, Color.White);


            for (int i = 0; i < StatsDB.builder_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(StatsDB.builder_texture[i], StatsDB.builder_pos[i], Color.White);
            }
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

        public override void cafaitca()
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
                //boutonCliqueIndex = -1;
            }
        }
    }
}
