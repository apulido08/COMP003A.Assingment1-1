/* namespace level
 * Author: Alvaro Pulido
 * Course: [COMP003A]
 * Faculty: Jonathan Cruz
 * Purpose: Basic COnsole App.
 */ 
namespace COMP003A.Assingment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");

            string username = Console.ReadLine();

            Console.WriteLine("Hello " + username + "!. My name is Alvaro!");

            Console.WriteLine("Here are 10 things about me:");
            Console.WriteLine("1. I build computers for fun.");
            Console.WriteLine("2. I work in the Ag Industry.");
            Console.WriteLine("3. I am a metal head for life!!");
            Console.WriteLine("4. I am a father of 3.");
            Console.WriteLine("5. Driving for me feels like a chore.");
            Console.WriteLine("6. I have always been facinated by technology.");
            Console.WriteLine("7. English was always a strong subject for me in school.");
            Console.WriteLine("8. I collect anime figures.");
            Console.WriteLine("9. I will always be a kid at heart.");
            Console.WriteLine("10. i want to travel to Europe one day.");
        }
    }
}
