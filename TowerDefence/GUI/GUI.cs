using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class GUI
    {

        
        private Infos infos;
        private TowerBuilder towerBuilder;
        private TowerUpgrade towerUpgrade;
        public GUI() 
        {
            this.infos = new Infos();
            this.towerBuilder = new TowerBuilder();
            this.towerUpgrade = new TowerUpgrade();
        }

        public void Initialize()
        {

        }

        public void LoadContent()
        {
            infos.LoadContent();
        }

        public void Update(GameTime gameTime)
        {
            towerBuilder.Check();
            towerBuilder.cafaitca();
        }

        public void Draw()
        {
            infos.Draw();
            towerBuilder.DrawButton();
            towerUpgrade.DrawButton();
        }


    }
}
