# 🎲 TP Mini-Jeu – POO C#  
**Version : 1.0**

## **Introduction**  
Ce projet est un mini-jeu console développé en C#. Le but est de combattre des monstres de différents niveaux en utilisant des règles basées sur des jets de dés. Le joueur accumule des points en fonction des monstres vaincus et joue jusqu'à épuisement de ses points de vie.

---

## **Règles du Jeu**  
1. **Départ :** Le joueur commence avec **100 points de vie**.  
2. **Monstres :** Deux types de monstres peuvent apparaître :  
   - **Monstre Niveau 1** : Attaque simple, rapporte 1 point lorsqu’il est vaincu.  
   - **Monstre Niveau 2** : Attaque avec un sort magique supplémentaire, rapporte 2 points.  
3. **Combat :**  
   - Le joueur attaque en lançant un dé. Si son score est supérieur ou égal à celui du monstre, ce dernier est vaincu.  
   - Les monstres ripostent avec leurs propres jets de dés et infligent des dégâts si leurs scores sont supérieurs à celui du joueur.  
4. **Bouclier :** Lorsqu’un monstre attaque, le joueur peut activer un bouclier (jet de dé). Si le score est inférieur ou égal à 2, aucun dégât n'est reçu.  
5. **Fin de Partie :** La partie se termine lorsque les points de vie du joueur atteignent 0.  

---

## **Points Forts**  
- **POO Structurée** : Utilisation de classes pour représenter le joueur, les monstres et les dés.  
- **Aléatoire Dynamique** : Basé sur des jets de dés pour plus de rejouabilité.  
- **Score Final :** Calcul automatique des points pour chaque type de monstre vaincu.  

---

## **Structure des Classes**  
- **Joueur** : Gère le nom, les points de vie, les attaques et la réception des dégâts.  
- **MonstreNiveau1** : Monstre basique avec des attaques simples.  
- **MonstreNiveau2** : Hérite de MonstreNiveau1 avec des attaques spéciales et un sort magique.  
- **De** : Simule un dé classique pour générer des nombres aléatoires.  

---

## **Exemple de Résultat**  
> *Bravo, vous avez tué 6 monstres de niveau 1 et 8 monstres de niveau 2.*  
> *Score final : 22 points.*  

---

**Amusez-vous bien ! 🎉**
