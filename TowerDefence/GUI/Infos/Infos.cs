using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1;
using SharpDX.MediaFoundation;

namespace TowerDefence
{
    public class Infos
    {
        public static Vector2 offsetBuilder = new Vector2(0, 50);
        private Texture2D infosTexture;
        private Texture2D builderTexture;
        public Infos() 
        {
        
        }

        public void LoadContent()
        {
            infosTexture = MainGame.content.Load<Texture2D>("GUI/Infos/Infos");
            builderTexture = MainGame.content.Load<Texture2D>("GUI/Infos/Builder");

        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(infosTexture, new Vector2(0, 0), Color.White);
            MainGame.spriteBatch.Draw(builderTexture, offsetBuilder, Color.White);

            MainGame.spriteBatch.DrawString(MainGame.font, ""+ StatsDB.playerPV, StatsDB.posPlayerPV, Color.Red);
            MainGame.spriteBatch.DrawString(MainGame.font, "" + StatsDB.playerOR, StatsDB.posPlayerOR, Color.White);
            MainGame.spriteBatch.DrawString(MainGame.font, "" + StatsDB.playerWood, StatsDB.posPlayerWood, Color.White);
            MainGame.spriteBatch.DrawString(MainGame.font, "" + StatsDB.playerWave, StatsDB.posPlayerWave, Color.White);
        }
    }
}
