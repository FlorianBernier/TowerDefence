using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;


namespace TowerDefence
{
    // Classe abstraite représentant un sort générique
    public abstract class Spell : ISpell
    {
        // Information générale des sorts
        public ESpell type;
        public Vector2 spellPos;
        public Vector2 spellPosOffset;
        public Rectangle spellRect;
        private Vector2 velocity;

        // Constructeur de la classe Spell
        public Spell(Vector2 pos) 
        {
            this.spellPos = pos;
            // Calcul de la position ajustée pour l'affichage
            spellPosOffset = new Vector2(spellPos.X * 64 + (int)Map.offsetMap.X+32-8, spellPos.Y * 64 + (int)Map.offsetMap.Y+32-8);
            // Initialisation du rectangle représentant la zone d'impact
            spellRect = new Rectangle((int)spellPosOffset.X, (int)spellPosOffset.Y, 16, 16);
        }

        // Méthode de mise à jour du sort, gérant le mouvement
        public void UpdateSpell()
        {

            if (MonsterFilter.liste.Count > 0)
            {
                // Logique de tir sur le monstre (par exemple, le premier monstre dans la liste)
                Monster targetMonster = MonsterFilter.liste[0];

                // Calcul de la direction vers le monstre
                Vector2 direction = targetMonster.pos - spellPosOffset;
                direction.Normalize();

                // Ajustement de la position du sort en fonction de la direction
                velocity = direction * SpellDB.spell_speed[(int)type];
                spellPosOffset += velocity;


                

            }

        }

        // Méthode de rendu du sort, affichant l'image associée
        public void DrawSpell()
        {
            MainGame.spriteBatch.Draw(SpellDB.spell_texture[(int)type], spellPosOffset, Color.White);
        }
    }
}
