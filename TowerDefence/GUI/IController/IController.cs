
namespace TowerDefence
{
    // Interface définissant les méthodes nécessaires pour la mise à jour et le dessin de l'interface utilisateur
    public interface IController
    {
        // Méthode appelée pour mettre à jour l'interface utilisateur
        public void UpdateGUI();
        // Méthode appelée pour dessiner l'interface utilisateur
        public void DrawGUI();
    }
}
