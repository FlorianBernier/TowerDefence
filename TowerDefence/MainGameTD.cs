using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace TowerDefence
{
    public class MainGameTD
    {
        private Map map;
        private GUI gui;
        private MonsterFilter monsterFilter;
        private TowerFilter towerFilter;

        public MainGameTD()
        {
            this.map = new Map();
            this.gui = new GUI();
        }

        public void Initialize()
        {
        }

        public void LoadContent()
        {
            map.LoadContent();
            gui.LoadContent();
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw()
        {
            map.Draw();
            gui.Draw();
        }
    }
}
