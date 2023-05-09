using Microsoft.Xna.Framework;

namespace TowerDefence
{
    public class MainGameTD
    {
        private Map map;
        private GUI gui;

        private MonsterFilter monsterFilter;
        private TowerFilter towerFilter;
        public static SpellFilter spellFilter;

        

        public MainGameTD()
        {
            this.map = new Map();

            this.monsterFilter = new MonsterFilter();
            this.towerFilter = new TowerFilter();
            spellFilter = new SpellFilter();

            this.gui = new GUI(towerFilter);

            MonsterDB.waveTimer.stop();
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
            gui.Update(gameTime);

            WaveMonster();
            monsterFilter
                .all()
                   .Move()
                   .Remove();

            spellFilter
                .all()
                    .UpdateSpell();
                      

            towerFilter
                .all()
                    .AddSpell();

        }

        public void Draw()
        {
            map.Draw();
            gui.Draw();

            monsterFilter
                .all()
                    .Draw();

            towerFilter
                .all()
                    .Draw();

            spellFilter
                .all()
                    .DrawSpell();
        }


        private void WaveMonster()
        {
            if (MonsterDB.monsterCount < MonsterDB.monsterByWave && MonsterDB.monsterTimer.elapsed())
            {
                monsterFilter.Add( (EMonster) (MonsterDB.wave % 9) );
                MonsterDB.monsterCount++;
                MonsterDB.monsterTimer.restart();
            }

            if (MonsterDB.monsterCount == MonsterDB.monsterByWave && !MonsterDB.waveTimer.hasStart && MonsterFilter.liste.Count == 0)
            {
                MonsterDB.waveTimer.restart();
                StatsDB.playerWave++;
            }

            if (MonsterDB.waveTimer.elapsed() && MonsterDB.waveTimer.hasStart)
            {
                MonsterDB.wave++;
                MonsterDB.monsterCount = 0;
                MonsterDB.monsterByWave += 2;
                MonsterDB.waveTimer.stop();
            }
        }
    }
}
