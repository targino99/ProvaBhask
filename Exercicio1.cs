using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExBhaskara
{
    public class Exercicio
    {
        public float Calculo(float a, float b, float c)
        {
            float delta= (b * b) - (4 * b * c); 
            float raiz= Math.Sqrt(delta);
            
             if (delta > 0)
            {
                var x1 = (-B + Math.Sqrt(delta)) / (2 * A);

                var x2 = (-B - Math.Sqrt(delta)) / (2 * A);

                return Math.Max(x1, x2);
            }
            if (delta == 0)
            {
                return 0;
            }
            return -1
            
        }

    }
}
