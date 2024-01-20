using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TowerDefence
{
    public class GUI
    {
        // État de la souris précédent
        public MouseState oldMouseState;

        // Composants de l'interface utilisateur
        private Infos infos;
        private TowerBuilder towerBuild = new();
        private TowerUpgrade towerUpgrade = new();

        // Contrôleur actuel
        private IController controller;

        // Filtre de tours
        public static TowerFilter towerFilter;

        // Tour actuelle sélectionnée
        public static Tower tower;
        public static Tower currentTower;

        // Constructeur
        public GUI(TowerFilter towerFilter) 
        {
            this.infos = new Infos();
            GUI.towerFilter = towerFilter;
        }

        // Initialisation
        public void Initialize()
        {

        }

        // Chargement des contenus
        public void LoadContent()
        {
            infos.LoadContent();
            this.controller = towerBuild;
        }

        // Mise à jour de l'interface utilisateur
        public void Update(GameTime gameTime)
        {
            // Sélection du contrôleur actuel en fonction de l'interaction de la souris
            SelectCurrentController();

            // Mise à jour du contrôleur actuel
            controller.UpdateGUI();

        }

        // Dessin de l'interface utilisateur
        public void Draw()
        {
            // Dessin des composants de l'interface utilisateur
            infos.Draw();
            controller.DrawGUI();
        }

        // Méthode pour sélectionner le contrôleur actuel en fonction de l'interaction de la souris
        public void SelectCurrentController()
        {
            MouseState mouseState = Mouse.GetState();

            // Vérifie si le bouton gauche de la souris est enfoncé
            if (mouseState.LeftButton == ButtonState.Pressed && 
                mouseState.LeftButton != oldMouseState.LeftButton)
            {
                // Obtient la tour sélectionnée
                tower = towerFilter.TowerSelected();

                // Si une tour est sélectionnée, le contrôleur devient celui de la mise à niveau de la tour
                if (tower != null)
                {
                    this.controller = towerUpgrade;
                }

                // Vérifie si la position de la souris se trouve dans la zone du bouton de retour au constructeur de tours
                Rectangle buttonRectangle =
                        new Rectangle((int)StatsDB.return_builder_pos.X,
                                     (int)StatsDB.return_builder_pos.Y,
                                     StatsDB.return_builder_texture.Width,
                                     StatsDB.return_builder_texture.Height);

                // Si la souris est dans la zone du bouton, le contrôleur devient celui du constructeur de tours
                if (buttonRectangle.Contains(mouseState.Position))
                {
                    this.controller = towerBuild;
                }
            }
            // Met à jour l'état précédent de la souris
            oldMouseState = Mouse.GetState();
        }
    }
}
