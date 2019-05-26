using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    class Operators
    {
        int value;
        char sign;

        public Operators(char symbol)
        {
            try
            {
                value = Convert.ToInt32(symbol);
            }
            catch (Exception ex)
            {
                value = 0;
            }
        }
    }
}
