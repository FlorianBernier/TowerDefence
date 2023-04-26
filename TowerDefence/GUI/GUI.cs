using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TowerDefence
{
    public class GUI
    {
        public MouseState oldMouseState;

        public int boutonCliqueIndex = -1;
        public int caseClickedX = -1;
        public int caseClickedY = -1;

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

            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.A))
            {
                
            }
            if (state.IsKeyDown(Keys.Z))
            {
                this.controller = tBuild;
            }

            MouseState mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed &&
                        mouseState.LeftButton != oldMouseState.LeftButton)
            {
                currentTower = towerFilter.IsChoosed();
                if (currentTower != null)
                    this.controller = tUpgrade;
            }
            oldMouseState = Mouse.GetState();






            controller.CheckClic();

            controller.Update();

        }

        public void Draw()
        {
            infos.Draw();
            controller.DrawGUI();
            controller.Afficher();
            controller.DrawTowerOnMouse();

            //test
            //MainGame.spriteBatch.Draw(StatsDB.test, new Vector2(0,0), Color.White);
        }
    }
}
