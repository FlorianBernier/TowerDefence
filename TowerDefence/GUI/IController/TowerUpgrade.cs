using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TowerDefence
{
    public class TowerUpgrade : IController
    {
        public void DrawButton()
        {
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.A))
            {
                MainGame.spriteBatch.Draw(StatsDB.contener_texture, StatsDB.contener_pos, Color.White);
            }
        }
    }
}
