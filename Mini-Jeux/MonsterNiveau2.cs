using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Jeux
{
    public class MonstreNiveau2 : Monstre
    {
        public MonstreNiveau2()
        {
            degats = 15;
        }

        public override void Attaquer(Joueur joueur)
        {
            int jetMonstre = JeterDe();
            int jetJoueur = joueur.LancerDe();

            if (jetMonstre > jetJoueur)
            {
                joueur.RecoitDegat(degats);
                Console.WriteLine("Le monstre de niveau 2 attaque avec une attaque normale !");

                int jetSort = JeterDe();
                if (jetSort != 6)
                {
                    int degatsSort = jetSort * 5;
                    joueur.RecoitDegat(degatsSort);
                    Console.WriteLine($"Le monstre de niveau 2 utilise un sort magique pour infliger {degatsSort} dégâts supplémentaires !");
                }
            }
            else
            {
                Console.WriteLine("Le monstre de niveau 2 a échoué son attaque.");
            }
        }
    }
}
