using Microsoft.Xna.Framework;

namespace TowerDefence
{
    public class TowerBuilder : IController
    {
        public void DrawButton()
        {
            for (int i = 0; i < StatsDB.builder_texture.Count; i++)
            {
                MainGame.spriteBatch.Draw(StatsDB.builder_texture[i], StatsDB.pos_builder_texture[i], Color.White);
            }
        }
    }
}
