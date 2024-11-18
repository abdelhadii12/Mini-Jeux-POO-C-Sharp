using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Jeux
{
    public abstract class Monstre
    {
        protected int degats;
        public bool estVivant;
        protected De de;

        public Monstre()
        {
            estVivant = true;
            de = new De();
        }

        public int JeterDe()
        {
            return de.JeterDe();
        }

        public abstract void Attaquer(Joueur joueur);

        public void RecoitDegat()
        {
            estVivant = false;
        }
    }
}