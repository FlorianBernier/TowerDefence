using Microsoft.Xna.Framework;

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
        }

        public void Update(GameTime gameTime)
        {
            monsterFilter
                .all()
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
