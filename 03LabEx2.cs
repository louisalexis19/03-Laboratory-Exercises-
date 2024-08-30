using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Good day, welcome to STI Dasmariñas!");
        Console.WriteLine("The following documents must be submitted upon enrolling:");
        Console.WriteLine("1. Form 137");
        Console.WriteLine("2. Medical Certificate");
        Console.WriteLine("3. PSA Certificate");
        Console.WriteLine("4. Diploma");
        Console.WriteLine();

        while (true)
        {
            // asking the user if they want to enroll
            Console.WriteLine("Do you want to enroll? (yes/no)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                // required files
                string[] requiredFiles = { "Form137.pdf", "MedCert.pdf", "PSA.pdf", "Diploma.pdf" };

                // array to store user-uploaded files' paths
                string[] uploadedFiles = new string[requiredFiles.Length];

                // sample path for the user
                string samplePath = @"C:\Users\louis\Downloads\";
                Console.WriteLine();

                // ask the user to upload filepath
                for (int i = 0; i < requiredFiles.Length; i++)
                {
                    Console.WriteLine($"Please enter the full path for {requiredFiles[i]} (e.g., {samplePath}{requiredFiles[i]}):");
                    uploadedFiles[i] = Console.ReadLine();
                }
                Console.WriteLine();

                // checking files
                bool allFilesExist = true;
                for (int i = 0; i < requiredFiles.Length; i++)
                {
                    Console.WriteLine($"Checking path: {uploadedFiles[i]}");  // Debugging output
                    if (File.Exists(uploadedFiles[i]))
                    {
                        Console.WriteLine($"{requiredFiles[i]} is uploaded and exists.");
                    }
                    else
                    {
                        Console.WriteLine($"{requiredFiles[i]} is missing.");
                        allFilesExist = false;
                    }
                }
                Console.WriteLine();

                // conclusion
                if (allFilesExist)
                {
                    Console.WriteLine("All files are present. You can enroll.");
                    break;
                }
                else
                {
                    Console.WriteLine("Some files are missing. You cannot enroll at the moment.");
                    break;
                }
            }
            else if (answer.ToLower() == "no")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for your time.");
                break;
            }
            else
            {
                Console.WriteLine("Error: Please answer 'yes' or 'no' only.");
            }

            Console.WriteLine();
        }
    }
}
