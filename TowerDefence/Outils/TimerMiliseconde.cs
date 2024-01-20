using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace TowerDefence
{
    public class TimerMiliseconde
    {
        // Durée du timer en millisecondes
        private int miliseconds;
        // Temps actuel en millisecondes
        private long currentMs;
        // Indique si le timer a été démarré
        public bool hasStart = true;

        // Constructeur
        public TimerMiliseconde(int pMs)
        {
            miliseconds = pMs;
            currentMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        // Vérifie si le temps écoulé dépasse la durée du timer
        public bool elapsed()
        {
            return currentMs + miliseconds < DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        // Redémarre le timer
        public void restart()
        {
            hasStart = true;
            currentMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        // Arrête le timer
        public void stop()
        {
            hasStart = false;
        }

        // Modifie la durée du timer
        public void changeTimer(int pMs)
        {
            miliseconds = pMs;
        }
    }


}
