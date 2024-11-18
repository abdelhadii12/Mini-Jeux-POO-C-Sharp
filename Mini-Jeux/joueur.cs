using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Jeux
{
    public class Joueur
    {
        public string Nom;
        private int pointsDeVie;
        private De de;

        public Joueur(string nom)
        {
            Nom = nom;
            pointsDeVie = 100;
            de = new De();
        }

        public bool EstVivant()
        {
            return pointsDeVie > 0;
        }

        public void Attaquer(Monstre monstre)
        {
            int jetJoueur = de.JeterDe();
            int jetMonstre = monstre.JeterDe();

            if (jetJoueur >= jetMonstre)
            {
                monstre.RecoitDegat();
                Console.WriteLine($"Le joueur {Nom} a vaincu le monstre !");
            }
            else
            {
                Console.WriteLine($"Le joueur {Nom} a échoué à attaquer le monstre.");
            }
        }
        public int LancerDe()
        {
            return de.JeterDe();
        }
        public void RecoitDegat(int degats)
        {
            int jetBouclier = de.JeterDe();
            if (jetBouclier <= 2)
            {
                Console.WriteLine("Le bouclier a bloqué les dégâts !");
            }
            else
            {
                pointsDeVie -= degats;
                Console.WriteLine($"Le joueur {Nom} a subi {degats} points de dégâts. Points de vie restants : {pointsDeVie}");
            }
        }
    }

}

