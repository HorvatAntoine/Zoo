using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class TypeVisiteur
    {
        public int id;
        public string libelle;
        public float tarif;

        public TypeVisiteur(int id, string libelle, float tarif)
        {
            this.id = id;
            this.libelle = libelle;
            this.tarif = tarif;
        }
    }
}