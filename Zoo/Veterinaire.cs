using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Veterinaire : Employe
    {
        public Animal Animal
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Animal Soigner()
        {
            throw new System.NotImplementedException();
        }
    }
}