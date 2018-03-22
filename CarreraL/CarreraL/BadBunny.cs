using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraL
{
    class BadBunny:Animal
    {
        static private Random aleat = new Random(new DateTime().Millisecond);
        private string _tipoPaso;
        private int pasos=0;

        public int getPasos()
        {
            return pasos;
        }

        public string getPaso()
        {
            return _tipoPaso;
        }

        public override int correr()
        {
            int prob;
            prob = aleat.Next(1, 11);
            if (prob < 3)
            {
                _tipoPaso = "Dormir";
            }
            else if (prob < 5)
            {
                for(int i=0;i<10;i++)
                {
                    pasos += darPaso();
                }
                _tipoPaso = "Salto grande";
            }
            else if (prob < 6)
            {
                for (int i = 0; i < 13; i++)
                {
                    pasos += menosPaso();
                }
                _tipoPaso = "Resbalon grande";
            }
            else if (prob < 9)
            {
                pasos += darPaso();
                _tipoPaso = "Salto pequeño";
            }
            else if (prob < 11)
            {
                pasos += menosPaso()+menosPaso();
                _tipoPaso = "Resbalon pequeño";
            }
            return pasos;
        }

        public override string ToString()
        {
            return "Conejo: "+pasos+" pasos, "+_tipoPaso+Environment.NewLine;
        }
    }
}
