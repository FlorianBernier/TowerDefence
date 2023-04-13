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
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw()
        {
            infos.Draw();
        }


    }
}
