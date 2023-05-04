

using Microsoft.Xna.Framework;

namespace TowerDefence
{
    public interface ISpell
    {
        public void UpdateSpell(Vector2 monsterPos);
        public void DrawSpell();

    }
}
