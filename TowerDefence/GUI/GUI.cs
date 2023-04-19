using Microsoft.Xna.Framework;
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
        private TowerBuilder builder;
        //private IController controller;
        public GUI() 
        {
            this.infos = new Infos();
            this.builder = new TowerBuilder();
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
        }

        public void Draw()
        {
            infos.Draw();
            builder.DrawButton();
        }


    }
}
