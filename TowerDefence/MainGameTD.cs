using Microsoft.Xna.Framework;

namespace TowerDefence
{
    public class MainGameTD
    {
        private Map map;
        private GUI gui;

        private MonsterFilter monsterFilter;
        private TowerFilter towerFilter;
        private SpellFilter spellFilter;

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
            this.spellFilter = new SpellFilter()
                .Add(ETower.FIRE, new Vector2(200,200));

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

            towerFilter
                .all();
                    

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

                switch (wave % 9)
                {
                    case 0:
                        monsterFilter.Add(EMonster.FIRE);
                        break;
                    case 1:
                        monsterFilter.Add(EMonster.ICE);
                        break;
                    case 2:
                        monsterFilter.Add(EMonster.POISON);
                        break;
                    case 3:
                        monsterFilter.Add(EMonster.WATER);
                        break;
                    case 4:
                        monsterFilter.Add(EMonster.WIND);
                        break;
                    case 5:
                        monsterFilter.Add(EMonster.LIGHT);
                        break;
                    case 6:
                        monsterFilter.Add(EMonster.DARK);
                        break;
                    case 7:
                        monsterFilter.Add(EMonster.ELECTRIC);
                        break;
                    case 8:
                        monsterFilter.Add(EMonster.PSYCHIC);
                        break;
                    default:
                        break;
                }

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
