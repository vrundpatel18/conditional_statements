// Vrund Patel
// 1/20/23
// Conditional Statements Asssignment


namespace conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());
                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected grade for ISM 4300 is a " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected grade for ISM 4300 is a " + letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected grade for ISM 4300 is a " + letter);
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";  
                    Console.WriteLine("Your expected grade for ISM 4300 is a " + letter);
                }
                else if (grade >= 0 && grade < 60)
                {
                    letter = "F";
                    Console.WriteLine("Your expected grade for ISM 4300 is a " + letter);
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric grade: ");
            }

        }
    }
}