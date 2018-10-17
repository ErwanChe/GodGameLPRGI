using System;

namespace GodGame
{
    class theGodGame
    {
        public static void Afficher(){
            Console.WriteLine("Bonjour bienvenu dans le GODGame de qualité");
            Console.WriteLine("Voulez vous : créer, reproduire ou tuer");
            Console.WriteLine("Votre monde : nombre d'être vivant : {0}", GestionDeVie.getNumberOfLiving());
            Console.WriteLine("Liste d'être vivant et ce qu'il font : {0}", GestionDeVie.getLivingCreatures());
            Console.WriteLine("Que voulez faire ? Créer, Accoupler ou tuer ?");
        }

        static void Main(string[] args)
        {
            while (true || Console.ReadLine().ToLower() == "exit")
            {
                String userChoice;
                bool goodChoice = false;
                Afficher();
                userChoice = Console.ReadLine().ToLower();
                do
                {
                    switch (userChoice)
                    {
                        case "créer":
                            GestionDeVie.Create();
                            goodChoice = true;
                            break;
                        case "accoupler":
                            GestionDeVie.Reproduction();
                            goodChoice = true;
                            break;
                        case "tuer":
                            GestionDeVie.Kill();
                            goodChoice = true;
                            break;
                        default:
                            Console.WriteLine("Veuillez entrer une action valide");
                            goodChoice = false;
                            break;
                    }
                } while (goodChoice != true);

                Console.WriteLine("Voici ce qui c'est passé : {0}", GestionDeVie.WhatHappend());
            }
        }
    }
}
