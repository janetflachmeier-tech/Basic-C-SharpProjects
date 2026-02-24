using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;

namespace CodeFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data");

            // Ensure directory exists before creating context
            if (!System.IO.Directory.Exists(dataDirectory))
            {
                System.IO.Directory.CreateDirectory(dataDirectory);
            }

            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);

            using (var context = new SchoolContext())  // Use default constructor to use App.config connection string
            {
                var student = new Student()
                {
                    StudentName = "John Smith",
                    DateOfBirth = new DateTime(2000, 5, 15),
                    Height = 5.8m,
                    Weight = 165.5f
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Student Name: {student.StudentName}");
                Console.ReadLine();
            }
        }
    }
}
