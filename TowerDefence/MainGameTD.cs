using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            this.monsterFilter = new MonsterFilter()
                .Add(EMonster.FIRE)
                .Add(EMonster.ICE);
        }



        public void Initialize()
        {
            map.Initialize();
        }

        public void LoadContent()
        {
            map.LoadContent();
            gui.LoadContent();
        }

        public void Update(GameTime gameTime)
        {
            monsterFilter
                .all()
                    .MoveMonsters();
        }

        public void Draw()
        {
            map.Draw();
            gui.Draw();

            monsterFilter
                .all()
                    .Draw();
        }
    }
}
