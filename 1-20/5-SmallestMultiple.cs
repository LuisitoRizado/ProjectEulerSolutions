using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems._1_20
{
    public class SmallestMultiple
    {
        //Problem 5.- Smallest Multiple
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder
        //What is the smalles positive number that is evenly divisible
        //by all of the numbers from 1 to 20

        public static int SmallestEvenlyMultiple()
        {

            //Ya puedes empezar desde 2520, ya tienes la mitad
            int value = 2520;
            while (true)
            {
                //
                if(value % 15 == 0 && value % 16 == 0 && value % 17 == 0 && value % 18 == 0 && value % 19 == 0 && value % 20 == 0)
                {
                    break;
                }
                value++;
            }

            return value;
        }
    }
}