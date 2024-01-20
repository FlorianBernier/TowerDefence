using Microsoft.Xna.Framework;

namespace TowerDefence
{
    // Classe abstraite représentant un monstre dans le jeu
    public abstract class Monster : IMonster
    {
        // Type du monstre (défini par l'énumération EMonster)
        public EMonster type;

        // Position et déplacement
        public Vector2 pos = MonsterDB.start_pos;
        public Vector2 velocity;
        public int lastDir;
        // Indique si le monstre doit être supprimé
        public bool remove = false;

        // Constructeur de la classe Monster
        public Monster() 
        {
            
        }

        // Méthode pour dessiner le monstre à l'écran
        public void Draw()
        {
            MainGame.spriteBatch.Draw(MonsterDB.monster_texture[(int)type],pos,Color.White);
        }

        // Méthode pour gérer le déplacement du monstre sur la carte
        public void Move()
        {
            // Calcul des coordonnées de la tuile sur laquelle se trouve le monstre
            int tileX = (int)((pos.X - Map.offsetMap.X) / Map.tileWidth);
            int tileY = (int)((pos.Y - Map.offsetMap.Y) / Map.tileHeight);

            // Gestion du déplacement en fonction de la dernière direction prise par le monstre
            switch (lastDir)
            {
                case 4:
                    tileX++;
                    break;
                case 8:
                    tileY++;
                    break;

                default:
                    break;
            }

            // Sélection de la prochaine tuile en fonction de la direction
            switch (Map.grid[tileY, tileX])
            {
                case 2:
                    // Déplacement vers la droite
                    lastDir = 2;
                    pos.X = tileX * Map.tileWidth + Map.offsetMap.X;
                    velocity.X = 0;
                    velocity.Y = MonsterDB.speed[(int)type];
                    break;
                case 4:
                    // Déplacement vers le haut
                    lastDir = 4;
                    pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    velocity.X = MonsterDB.speed[(int)type] * -1;
                    velocity.Y = 0;
                    break;
                case 6:
                    // Déplacement vers le bas
                    lastDir = 6;
                    pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    velocity.X = MonsterDB.speed[(int)type];
                    velocity.Y = 0;
                    break;
                case 8:
                    // Déplacement vers la gauche
                    lastDir = 8;
                    pos.X = tileX * Map.tileWidth + Map.offsetMap.X;
                    velocity.X = 0;
                    velocity.Y = MonsterDB.speed[(int)type] * -1;
                    break;
                case 3:
                    // Déplacement vertical
                    velocity.X = 0;
                    velocity.Y = MonsterDB.speed[(int)type];
                    break;
                case 5:
                    // Le monstre a atteint la fin du parcours, le joueur perd des points de vie
                    pos.Y = tileY * Map.tileHeight + Map.offsetMap.Y;
                    velocity.X = 0;
                    velocity.Y = 0;
                    remove = true;
                    StatsDB.playerPV--;
                    break;
                default:
                    break;
            }
            // Mise à jour de la position du monstre
            pos += velocity;
        }

        // Méthode pour construire le monstre
        public void Build()
        {
            
        }
    }
}
