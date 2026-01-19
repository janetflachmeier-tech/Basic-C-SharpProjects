using System;

namespace DailyReportAssignment
{
   class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Academy of Learning Career College");
                Console.WriteLine("Student Daily Report.");
                Console.WriteLine(); 

                // Ask for student's name and store it in a string variable
                Console.WriteLine("What is your name? ");
                string studentName = Console.ReadLine();

                // Ask for the course name and store it in a string variable
                Console.WriteLine("What course are you on? ");
                string courseName = Console.ReadLine();

                // Ask for the page number and store it in an integer variable
                Console.WriteLine("What page number? ");
                int pageNumber = Convert.ToInt32(Console.ReadLine());

                // Ask if the student needs help and store it in a boolean variable
                Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\": ");
                bool needsHelp = Convert.ToBoolean(Console.ReadLine());

                // Ask for positive experiences and store it in a string variable
                Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics: ");
                string positiveExperience = Console.ReadLine();

                // Ask for additional feedback and store it in a string variable
                Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific: ");
                string additionalFeedback = Console.ReadLine();

                // Ask for hours studied and store it in a double variable
                Console.WriteLine("How many hours did you study today? ");
                double studyHours = Convert.ToDouble(Console.ReadLine());

                // Print the closing message
                Console.WriteLine();
                Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        }
   }

}