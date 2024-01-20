

namespace TowerDefence
{
    // Interface représentant les fonctionnalités communes à toutes les tours du jeu
    public interface ITower
    {
        // Méthode permettant d'ajouter un sort à la tour
        public void AddSpell();
        // Méthode permettant de dessiner la tour
        public void Draw();
    }
}
