using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        private string Nom;
        private DateTime DateNaissance;

        public Enclos Enclos
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public NourritureAnimal NourritureAnimal
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }
    }
}