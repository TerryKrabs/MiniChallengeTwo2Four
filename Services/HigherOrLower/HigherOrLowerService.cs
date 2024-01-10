using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeTwo2Four.Services.HigherOrLower
{
    public class HigherOrLowerService : IHigherOrLowerService
    {
        public string HigherOrLower(int num1, int num2)
        {
            if (num1 > num2)
            {
                return ($"{num1} is greater than {num2}, and {num2} is less than {num1}");
            }

            else if (num1 < num2)
            {
                return ($"{num1} is less than {num2}, and {num2} is greater than {num1}");
            }

            else
            {
                return ($"{num1} is equal to {num2}");
            }
        }




    }
}