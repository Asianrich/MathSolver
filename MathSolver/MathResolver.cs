using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    class MathResolver
    {




        public static string resolve(string problem)
        {
            int solution;
            List<Operators> operators = new List<Operators>();

            char value = problem.First();
            problem = problem.Remove(0,1);

            foreach(char symbol in problem)
            {
                operators.Add(new Operators(symbol));
            }






            return problem.ToString();
            //return solution;
        }






    }
}
