using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TowerDefence
{
    public class GUI
    {
        public MouseState oldMouseState;
        


        private Infos infos;

        public static TowerFilter towerFilter;
        public static Tower currentTower;

        private TowerBuilder towerBuild = new();
        private TowerUpgrade towerUpgrade = new();

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
            this.controller = towerBuild;
            
        }

        public void Update(GameTime gameTime)
        {
            SelectCurrentController();

            controller.UpdateGUI();

        }

        public void Draw()
        {
            infos.Draw();
            controller.DrawGUI();
        }




        // Méthode GUI
        public void SelectCurrentController()
        {
            MouseState mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed && 
                mouseState.LeftButton != oldMouseState.LeftButton)
            {
                currentTower = towerFilter.TowerSelected();
                if (currentTower != null)
                    this.controller = towerUpgrade;
                else
                {
                    this.controller = towerBuild;
                }
            }
            oldMouseState = Mouse.GetState();
        }

    }
}
