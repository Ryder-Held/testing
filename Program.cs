// Creator: Ryder Held
// Date: 1/27/2025
using System.ComponentModel.Design;

namespace QuizCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            a_quiz_calculator aQuizCalculator = new a_quiz_calculator();

            aQuizCalculator.Quiz1 = 80.00;
            aQuizCalculator.Quiz2 = 85.00;
            aQuizCalculator.Quiz3 = 75.00;
            aQuizCalculator.Quiz4 = 80.00;

            Console.WriteLine("Total: " + aQuizCalculator.CalcTotal());
            Console.WriteLine("Average: " + aQuizCalculator.CalcAverage());
            Console.WriteLine("Letter Grade: " + aQuizCalculator.CalcLetterGrade());

            TempFind fah = new TempFind();
            fah.Fahrenheit = 32;
            bool erg = true;
            while (erg == true)
            {
                if(fah.Fahrenheit < -459.67)
                {
                    Console.WriteLine("try again");
                }
                else
                {
                    erg = false;
                }
                
            }
        }
    }
}
