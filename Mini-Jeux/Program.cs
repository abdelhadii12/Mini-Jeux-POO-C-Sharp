namespace Mini_Jeux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le mini-jeu ! Entrez le nom du joueur :");
            string nomJoueur = Console.ReadLine();
            Joueur joueur = new Joueur(nomJoueur);

            int monstresNiveau1Tues = 0;
            int monstresNiveau2Tues = 0;

            while (joueur.EstVivant())
            {
                Monstre monstre;
                if (new Random().Next(0, 2) == 0)
                    monstre = new MonstreNiveau1();
                else
                    monstre = new MonstreNiveau2();

                Console.WriteLine(monstre is MonstreNiveau1 ? "Un monstre de niveau 1 apparaît !" : "Un monstre de niveau 2 apparaît !");
                while (monstre.estVivant && joueur.EstVivant())
                {
                    joueur.Attaquer(monstre);
                    if (monstre.estVivant)
                    {
                        monstre.Attaquer(joueur);
                    }
                }

                if (!monstre.estVivant)
                {
                    if (monstre is MonstreNiveau1)
                    {
                        monstresNiveau1Tues++;
                    }
                    else
                    {
                        monstresNiveau2Tues++;
                    }
                }
            }

            int points = monstresNiveau1Tues * 1 + monstresNiveau2Tues * 2;
            Console.WriteLine($"Le joueur est mort. Vous avez tué {monstresNiveau1Tues} monstres de niveau 1 et {monstresNiveau2Tues} monstres de niveau 2.");
            Console.WriteLine($"Vous avez gagné {points} points.");
        }
    }
}
    


