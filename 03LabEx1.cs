using System;

namespace frmStudentGradeProgram
{
    class frmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            // welcome message and introduction
            Console.WriteLine("Hola! This is Average App Calculator!");
            Console.WriteLine("Kindly fill up the following information to compute your average. Thank you");
            Console.WriteLine("");

            //get student name
            Console.Write("Name: ");
            string studentName = Console.ReadLine();

            //get program course
            Console.Write("Enter your course: ");
            string course = Console.ReadLine();

            // array to store grades
            double[] grades = new double[5];
            Console.WriteLine("");

            // loop to get grades for each subject 
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write("Enter grade for Subject " + (i + 1) + ": ");
                    string gradeInput = Console.ReadLine();
                    if (double.TryParse(gradeInput, out double grade))
                    {
                        grades[i] = grade;
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade format. Please enter a number.");
                    }
                }
            }

            //calculate total grade
            double total = 0;
            foreach (double grade in grades)
            {
                total += grade;
            }

            //calculate average grade
            double average = total / 5;
            
            // display results
            Console.WriteLine("");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Grades:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + grades[i].ToString("F2"));
            }
            Console.WriteLine("Total: " + total.ToString("F2"));
            Console.WriteLine("General Average: " + average.ToString("F2"));
            Console.WriteLine("");
            if (average >= 75.00)
            {
                Console.WriteLine("The student passed. The general average of " + studentName + " is " + average.ToString("F2"));
            }
            else
            {
                Console.WriteLine("The student failed. The general average of " + studentName + " is " + average.ToString("F2"));  
            }
        }
    }
}