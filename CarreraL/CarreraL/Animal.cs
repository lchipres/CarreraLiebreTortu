using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraL
{
     abstract class Animal
    {

        public Animal()
        {

        }

        public int darPaso()
        {
            return 1;
        }

        public int menosPaso()
        {
            return -1;
        }

        public abstract int correr();
    }
}
