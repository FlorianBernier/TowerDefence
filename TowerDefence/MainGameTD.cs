using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TowerDefence
{
    public class MainGameTD
    {
        private Map map;
        private GUI gui;

        public List<Monster> waveList = new();

        private MonsterFilter monsterFilter;
        private TowerFilter towerFilter;



        public MainGameTD()
        {
            this.map = new Map();
            this.gui = new GUI();

           

            this.monsterFilter = new MonsterFilter()
                .Add(EMonster.FIRE)
                .Add(EMonster.ICE)
                .Add(EMonster.POISON);

            
        }



        public void Initialize()
        {
            
        }

        public void LoadContent()
        {
            map.LoadContent();
            gui.LoadContent();
            monsterFilter.LoadWave(this);
        }

        public void Update(GameTime gameTime)
        {
            monsterFilter
                .all()
                    .StartWave(this)
                        .Move()
                        .Remove();
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
