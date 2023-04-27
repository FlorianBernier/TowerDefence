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
            CheckControllerActive();


            controller.CheckClic();
            controller.Update();

        }

        public void Draw()
        {
            infos.Draw();
            controller.DrawGUI();
        }




        // Méthode GUI
        public void CheckControllerActive()
        {
            MouseState mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed && mouseState.LeftButton != oldMouseState.LeftButton)
            {
                currentTower = towerFilter.IsChoosed();
                if (currentTower != null)
                    this.controller = tUpgrade;
                else
                {
                    this.controller = tBuild;
                }
            }
            oldMouseState = Mouse.GetState();
        }
    }
}
