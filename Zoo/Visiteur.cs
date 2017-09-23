using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Visiteur
    {
        private string Nom;
        public int TypeId { get; set; }

        public Visiteur(string nom, int typeId)
        {
            Nom = nom;
            TypeId = typeId;
        }

        public TypeVisiteur TypeVisiteur
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}