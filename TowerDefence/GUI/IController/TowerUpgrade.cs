﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SharpDX.DirectWrite;

namespace TowerDefence
{
    public class TowerUpgrade : Controller
    {

        public override void DrawGUI()
        {
            MainGame.spriteBatch.Draw(StatsDB.contener_texture, StatsDB.contener_pos, Color.White);
            MainGame.spriteBatch.Draw(StatsDB.afficher_texture, StatsDB.afficher_pos, Color.White);

        }
        public override void DrawTowerOnMouse()
        {

        }


        public override void Afficher()
        {

        }

        public override void SelectCurrentButtonToDraw()
        {
        }

        public override void SelectCurrentCase()
        {
        }

        public override void Update()
        {
        }
    }
}




