using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion2_Estadistica
{
    class estadistica
    {
        public double suma = 0;
        private string valor;

        public double media(String[] serie)
        {
            foreach (string valor in serie)
            {
                suma += int.Parse(valor);

            }
            return suma / serie.Length;
        }
    }
}