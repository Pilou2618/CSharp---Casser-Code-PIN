﻿using System;
using System.Threading;
using System.Xml.Serialization;



namespace CasserCodePIN
{
    class Program
    {
        public static void Main(string[] args)
        {
            // start représente l'heure de démarrage du programme
            DateTime start = DateTime.Now;
            Console.WriteLine("Début du programme");

            // Générateur de nombre aléatoire
            Random rnd = new Random();

            // code secret compris entre 0 et 9999
            int codeSecret = rnd.Next(9999);

            // booléen qui indique si on a trouvé le code secret
            bool trouve = false;

            // compteur de boucle
            int i = 0;
            while (i < 10000 && trouve == false)
            {
                Console.Write(i + " ");
                // si on trouve le code PIN, il faut afficher i et interrompre la boucle
                if (i == codeSecret)
                {
                    Console.WriteLine("\nCode PIN trouvé : " + i);
                    trouve = true;
                }

                // Temporisation pour ralentir le programme
                Thread.Sleep(1000);

                i++;
            }




            Console.WriteLine("Fin du programme");

            // durée du programme = heure de fin - heure de démarrage
            TimeSpan duree = DateTime.Now - start;
            Console.WriteLine("durée du programme : " + duree);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
