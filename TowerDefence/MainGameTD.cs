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

        // Wave
        private TimerMiliseconde monsterTimer;
        private TimerMiliseconde waveTimer;
        private int wave = 0;
        private int monsterByWave = 10;
        private int monsterCount = 0;


        public MainGameTD()
        {
            this.map = new Map();

            this.monsterFilter = new MonsterFilter();
            this.towerFilter = new TowerFilter();
            spellFilter = new SpellFilter();

            this.gui = new GUI(towerFilter);

            // Wave
            monsterTimer = new TimerMiliseconde(500);
            waveTimer = new TimerMiliseconde(5000);
            waveTimer.stop();
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
            if (monsterCount < monsterByWave && monsterTimer.elapsed())
            {
                monsterFilter.Add( (EMonster) (wave % 9) );
                monsterCount++;
                monsterTimer.restart();
            }

            if (monsterCount == monsterByWave && !waveTimer.hasStart && MonsterFilter.liste.Count == 0)
            {
                waveTimer.restart();
            }

            if (waveTimer.elapsed() && waveTimer.hasStart)
            {
                wave++;
                monsterCount = 0;
                monsterByWave += 2;
                waveTimer.stop();
            }
        }
    }
}
