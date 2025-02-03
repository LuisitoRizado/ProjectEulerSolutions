
namespace ProjectEulerProblems._1_20
{
    public class SumSquareDifference
    {
        //DESCRIPTION: 
        //The sum of the squares of the first ten natural numbers is
        //1^2 + 2^2 +... +10^2 = 385
        //The square of the sum of the first ten natural numbers is,
        //(1 + 2 + ... +10)^2 = 3025

        //Hence the difference between the sum of the squares of the first ten natural
        //numbers and the square of the sum is 3025 - 385 = 2640
        
        //SOLVE:
        //Find the difference between the sum of the squares of the
        //first one hundred natural numbers and the square of the sum.

        public static double CalculateSumSquareDifference(int limit)
        {
            int totalDifference = 0;
            double squareNumbersSum = 0;
           
            //First calculate the sum of the square of each number
            for (int i = 0; i <= limit; i++)
                squareNumbersSum += Math.Pow(i,2);

            double acumulatedSumSquare = Math.Pow((limit * (limit + 1) / 2),2);


            return acumulatedSumSquare - squareNumbersSum ;
        }

    }
}
