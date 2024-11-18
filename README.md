# Mini-Jeux-POO-C-Sharp
TP Mini Jeu – POO C#
Version : 1.0

Description
Ce projet consiste à développer un mini-jeu en C# basé sur les principes de la programmation orientée objet (POO). Le joueur affronte des monstres de différents niveaux en lançant des dés pour déterminer les résultats des attaques.

Règles du jeu
Le joueur commence avec 100 points de vie.
Les monstres arrivent aléatoirement :
Monstre de niveau 1 : rapporte 1 point par victoire.
Monstre de niveau 2 : rapporte 2 points par victoire et utilise un sort magique.
Une attaque est déterminée par un jet de dé.
Conditions de victoire ou défaite :
Le joueur continue tant qu’il est vivant.
Le score est basé sur le nombre et le type de monstres vaincus.
Classes
Joueur
Attributs : nom, points de vie (lecture seule).
Méthodes principales :
EstVivant : vérifie si le joueur est vivant.
JeterDe : génère un jet de dé.
Attaquer : attaque un monstre.
RecoitDegat : gère les dégâts reçus avec un bouclier actif.
MonstreNiveau1
Attributs : dégâts, état (vivant ou non).
Méthodes principales :
JeterDe : génère un jet de dé.
Attaquer : attaque un joueur.
RecoitDegat : marque le monstre comme vaincu.
MonstreNiveau2
Hérite de MonstreNiveau1 avec une modification de Attaquer :
Utilise un sort magique qui inflige des dégâts supplémentaires.
De
Méthode principale :
JeterDe : retourne un entier simulant un jet de dé classique.
Instructions
Installation :

Cloner ce dépôt ou créer un nouveau projet console nommé TPMiniJeu.
Ajouter les 4 classes mentionnées ci-dessus.
Tests :

Créez un joueur.
Bouclez tant que le joueur est vivant.
Fabriquez des monstres aléatoires et lancez les combats.
Comptez les monstres vaincus et affichez les résultats à la fin.
Exemple de Résultat
Copier le code
Vous êtes mort...  
Bravo, vous avez tué 6 monstres de niveau 1 et 8 monstres de niveau 2.  
Vous avez gagné 22 points.  
Ressources
Classe Random
Amusez-vous bien ! 🎮