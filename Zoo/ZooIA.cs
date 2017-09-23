using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoo
{
    class ZooIA
    {
        static void main()
        {
            Console.WriteLine("test");
            Zoo zoo = new Zoo();
            zoo.Caisse = 1500;
            bool jeuEnCours = true;
            int heure = 5;
            
            List<TypeVisiteur> listTypevisiteur = new List<TypeVisiteur>();
            listTypevisiteur.Add(new TypeVisiteur(0, "Junior", 8));
            listTypevisiteur.Add(new TypeVisiteur(1, "Etudiant", 12));
            listTypevisiteur.Add(new TypeVisiteur(2, "Senior", 16));
            listTypevisiteur.Add(new TypeVisiteur(3, "Normal", 20));
            List<Visiteur> listVisiteur = new List<Visiteur>();
            Visiteur visiteur;

            while (jeuEnCours == true)
            {
                Random rnd = new Random();
                int NombreVisiteurs = rnd.Next(1, 30);
                int i;
                for (i = 0; i < NombreVisiteurs; i++)
                {
                    int RndType = rnd.Next(0, 3);
                    visiteur = new Visiteur("didier",RndType);
                    zoo.Caisse += listTypevisiteur.ElementAt(visiteur.TypeId).tarif;
                    Console.WriteLine("Un visiteur entre dans le parc et paie " + listTypevisiteur.ElementAt(visiteur.TypeId).tarif);
                    Console.ReadLine();
                    Console.ReadKey();
                    listVisiteur.Add(visiteur);
                }
                jeuEnCours = false;
                Console.ReadLine();
                Console.WriteLine("test");

            }
        }

    }
}
