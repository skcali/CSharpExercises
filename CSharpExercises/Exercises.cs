using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name) 
        {
            return "Hello " + name + "!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int one, int two) 
        {
            return one + two;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static double Divide(double one, double two)
        {
            return Math.Round(one/two, 2);
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18) {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string FullName)
        {
            string[] FirstName = FullName.Split(' ');
            return FirstName[0];
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string quote)
        {
            char[] cArray = quote.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string quote)
        {
            char[] charArray = quote.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
         public static string PrintTimesTable(int number)
        {
            string FinalTable = String.Empty;
            for (int i = 1; i < 11; i++)
                {
                    FinalTable += number + " * " + i + " = " + (number * i);
                    if(i != 10)
                    {
                    FinalTable += Environment.NewLine;
                    }
                }
            return FinalTable;
        }
        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double Kel)
        {
            return Math.Round(1.8 * (Kel - 273.15) + 32, 2);
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average =  sum / numbers.Length;
            return average;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] numbers)
        {
            double average = numbers.Average();
            return average;
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
         public static string DrawTriangle(int numbers, int width)
        {
            string number = numbers.ToString();
            int Width = width;
            string FinalTri = String.Empty;
            for (int i = numbers; i > 0; i--)
            {
                for (int x = 0; x < Width; x++)
                {
                    FinalTri += number;
                }
                if (Width > 1)
                {
                    FinalTri += Environment.NewLine;
                }
                Width--;
            }
            return FinalTri;
        }
        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int min, int seconds)
        {
            double ConvertTime = hours + ((double) min / 60) + ((double) seconds / 3600);
            double MPH = Math.Round(distance / ConvertTime, 0);
            return MPH + "MPH";
        }
        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char newChar)
        {
            Char.ToLower(newChar);
            if (newChar == 'a' | newChar == 'e' | newChar == 'i' | newChar == 'o' | newChar == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char newChar)
        {
            Char.ToLower(newChar);
            if (newChar == 'a' | newChar == 'e' | newChar == 'i' | newChar == 'o' | newChar == 'u')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. 
        // Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int Collatz)
        {
            int counter = 0;
            while (Collatz != 1)
            {
                if (Collatz % 2 == 0)
                {
                    Collatz = Collatz / 2;
                    counter += 1;
                }
                else
                {
                    Collatz = (Collatz * 3) + 1;
                    counter += 1;
                }
            }
            return counter;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime dt)
        {
            DateTime[] aDate = new DateTime[7];
            for(int i = 0; i < aDate.Length; i++)
            {
                aDate[i] = dt.AddDays(i);
            }
            return aDate;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(DateTime dt)
        {
            if (DateTime.IsLeapYear(dt.Year))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double loan, double intrestRate, int loanTerm, int payPeriod)
        {
            intrestRate = intrestRate / 100;
            double LoanTerm = loanTerm * payPeriod;
            double multiplier = intrestRate / payPeriod;
            double TopPayment = multiplier * Math.Pow((1 + multiplier), LoanTerm);
            double BotPayment = Math.Pow((1 + multiplier), LoanTerm) - 1;
            return Math.Round(loan * (TopPayment/BotPayment), 2);
        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        public static string DuckGoose(int iterate)
        {
            string DuckGoosePrint = String.Empty;
            for(int i = 1; i < iterate + 1; i++)
            {
                if (!(i % 3 == 0) && !(i % 5 == 0))
                {
                    DuckGoosePrint += i.ToString();
                }
                if (i % 3 == 0)
                {
                    DuckGoosePrint += "Duck";
                }
                if (i % 5 == 0)
                {
                    DuckGoosePrint += "Goose";
                }
                if (i != iterate)
                {
                    DuckGoosePrint += Environment.NewLine;
                }
            }
            return DuckGoosePrint;
        }
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}