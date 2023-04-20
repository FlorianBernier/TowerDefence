using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TowerDefence
{
    public class GUI
    {

        
        private Infos infos;
        

        private TowerBuilder tBuild = new();
        private TowerUpgrade tUpgrade = new();

        private IController controller;

        public GUI() 
        {
            this.infos = new Infos();

        }

        public void Initialize()
        {

        }

        public void LoadContent()
        {
            infos.LoadContent();
            this.controller = tBuild;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.A))
            {
                this.controller = tUpgrade;
            }
            if (state.IsKeyDown(Keys.Z))
            {
                this.controller = tBuild;
            }

            controller.CheckClic();

            controller.cafaitca();


        }

        public void Draw()
        {
            infos.Draw();
            controller.Draw();
            controller.Afficher();
            

            //MainGame.spriteBatch.Draw(StatsDB.fire_infos_texture[0], StatsDB.infos_pos[0], Color.White);
        }
    }
}
