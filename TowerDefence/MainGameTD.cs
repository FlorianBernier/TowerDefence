using Microsoft.Xna.Framework;

namespace TowerDefence
{
    public class MainGameTD
    {
        // Instances des composants du jeu
        private Map map;
        private GUI gui;
        private MonsterFilter monsterFilter;
        private TowerFilter towerFilter;
        public static SpellFilter spellFilter;

        // Constructeur de la classe MainGameTD
        public MainGameTD()
        {
            // Initialisation des composants du jeu
            this.map = new Map();
            this.monsterFilter = new MonsterFilter();
            this.towerFilter = new TowerFilter();
            spellFilter = new SpellFilter();
            this.gui = new GUI(towerFilter);

            // Arrêt du minuteur de la vague de monstres au début du jeu
            MonsterDB.waveTimer.stop();
        }

        public void Initialize()
        {
            
        }

        // Méthode appelée lors du chargement des contenus du jeu
        public void LoadContent()
        {
            // Chargement des contenus de la carte et de l'interface utilisateur
            map.LoadContent();
            gui.LoadContent();
        }

        // Méthode appelée à chaque mise à jour du jeu
        public void Update(GameTime gameTime)
        {
            // Mise à jour de l'interface utilisateur
            gui.Update(gameTime);

            // Appel des méthodes de gestion des monstres, tours et sorts
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

        // Méthode appelée à chaque frame pour le rendu
        public void Draw()
        {
            // Dessin de la carte et de l'interface utilisateur
            map.Draw();
            gui.Draw();

            // Dessin des monstres, tours et sorts
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

        // Méthode de gestion de la vague de monstres
        private void WaveMonster()
        {
            // Ajout de monstres à la vague en fonction du temps écoulé et du nombre de monstres créés
            if (MonsterDB.monsterCount < MonsterDB.monsterByWave && MonsterDB.monsterTimer.elapsed())
            {
                monsterFilter.Add( (EMonster) (MonsterDB.wave % 9) );
                MonsterDB.monsterCount++;
                MonsterDB.monsterTimer.restart();
            }

            // Démarrage du minuteur de vague et incrémentation du nombre de vagues terminées
            if (MonsterDB.monsterCount == MonsterDB.monsterByWave && !MonsterDB.waveTimer.hasStart && MonsterFilter.liste.Count == 0)
            {
                MonsterDB.waveTimer.restart();
                StatsDB.playerWave++;
            }

            // Réinitialisation des compteurs et arrêt du minuteur à la fin de la vague
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
