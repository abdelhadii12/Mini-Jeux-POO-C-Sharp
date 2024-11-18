using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Jeux
{
    class MonstreNiveau1 : Monstre
    {
        public MonstreNiveau1()
        {
            degats = 10;
        }

        public override void Attaquer(Joueur joueur)
        {
            int jetMonstre = JeterDe();
            int jetJoueur = joueur.LancerDe();

            if (jetMonstre > jetJoueur)
            {
                joueur.RecoitDegat(degats);
                Console.WriteLine("Le monstre de niveau 1 attaque !");
            }
            else
            {
                Console.WriteLine("Le monstre de niveau 1 a échoué son attaque.");
            }
        }
    }
}

