using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TowerDefence
{
    public class GUI
    {
        public MouseState oldMouseState;

        private Infos infos;

        public static TowerFilter towerFilter;

        public static Tower tower;
        public static Tower currentTower;

        //public static SpellFilter spellFilter;

        private TowerBuilder towerBuild = new();
        private TowerUpgrade towerUpgrade = new();

        private IController controller;

        public GUI(TowerFilter towerFilter, SpellFilter spellFilter) 
        {
            this.infos = new Infos();

            GUI.towerFilter = towerFilter;
            //GUI.spellFilter = spellFilter;
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
                tower = towerFilter.TowerSelected();
                if (tower != null)
                {
                    this.controller = towerUpgrade;
                }
                Rectangle buttonRectangle =
                        new Rectangle((int)StatsDB.return_builder_pos.X,
                                     (int)StatsDB.return_builder_pos.Y,
                                     StatsDB.return_builder_texture.Width,
                                     StatsDB.return_builder_texture.Height);

                if (buttonRectangle.Contains(mouseState.Position))
                {
                    this.controller = towerBuild;
                }
            }
            oldMouseState = Mouse.GetState();
        }

    }
}
