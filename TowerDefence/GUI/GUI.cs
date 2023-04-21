using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TowerDefence
{
    public class GUI
    {

        
        private Infos infos;

        public static TowerFilter towerFilter;



        private TowerBuilder tBuild = new();
        private TowerUpgrade tUpgrade = new();

        private IController controller;

        public GUI(TowerFilter towerFilter) 
        {
            this.infos = new Infos();

            GUI.towerFilter = towerFilter;
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

            controller.Update();

        }

        public void Draw()
        {
            infos.Draw();
            controller.DrawGUI();
            controller.Afficher();
            controller.DrawTowerOnMouse();
        }
    }
}
