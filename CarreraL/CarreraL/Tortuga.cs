using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraL
{
    class Tortuga:Animal
    {
        static private Random aleat = new Random(new DateTime().Millisecond);
        private string _tipoPaso;
        private int pasos=0;

        public string getPaso()
        {
            return _tipoPaso;
        }

        public int getPasos()
        {
            return pasos;
        }

        public override int correr()
        {
            int prob;
            prob = aleat.Next(1, 11);
            if (prob < 6)
            {
                for(int i=0;i<4 ; i++)
                {
                    pasos +=darPaso();
                }
                _tipoPaso = "Paso rapido";
            }
            else if (prob < 8)
            {
                for (int i = 0; i < 7; i++)
                {
                    pasos += menosPaso();
                }
                _tipoPaso = "Resbalon";
            }
            else if (prob < 11)
            {
                pasos += darPaso();
                _tipoPaso = "Paso lento";
            }
            return pasos;
        }

        public override string ToString()
        {
            return "Tortuga: " + pasos + " pasos, " + _tipoPaso+Environment.NewLine;
        }
    }
}
