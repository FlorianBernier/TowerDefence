
namespace TowerDefence
{
    public interface IController
    {
        public void DrawGUI();
        public void DrawTowerOnMouse();
        public void CheckClic();
        public void Afficher();
        public void SelectCurrentButtonToDraw();
        public void Update();
    }
}
