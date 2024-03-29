﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class FuncionSigno : Señal
    {

        public FuncionSigno()
        {
            Muestras = new List<Muestra>();
        }

        override public double evaluar(double tiempo)
        {
            double resultado;
            if(tiempo > 0.0)
            {
                resultado = 1.0;
            }
            else if(tiempo < 0.0)
            {
                resultado = -1.0;
            }
            else
            {
                resultado = 0.0;
            }
            return resultado;
        }
    }
}
