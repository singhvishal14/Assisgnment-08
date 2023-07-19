using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.Write("Enter your choice (1-3): ");
            int employeeType = int.Parse(Console.ReadLine());

            switch (employeeType)
            {
                case 1:
                    Console.WriteLine("1. HR");
                    CalculateSalaryForHR();
                    break;
                case 2:
                    Console.WriteLine("2. ADMIN");
                    CalculateSalaryForAdmin();
                    break;
                case 3:
                    Console.WriteLine("3. SOFTWARE DEVELOPER");
                    CalculateSalaryForSoftwareDeveloper();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ReadLine();
        }

        // Method to calculate salary for HR employee
        static void CalculateSalaryForHR()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());
            //Console.Write("Enter project handles: ");
            //int projectHandles = int.Parse(Console.ReadLine());

            // Calculate the monthly salary using the CalculateSalary method with appropriate parameters
            int monthlySalary = CalculateSalary(workingHours, numberOfWorkingDays, 1, 0);
            Console.WriteLine("Monthly Salary: Rs" + monthlySalary);
        }

        // Method to calculate salary for Admin employee
        static void CalculateSalaryForAdmin()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());
            Console.Write("Enter project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());

            // Calculate the monthly salary using the CalculateSalary method with appropriate parameters
            int monthlySalary = CalculateSalary(workingHours, numberOfWorkingDays, projectHandles, 0);
            Console.WriteLine("Monthly Salary: Rs" + monthlySalary);
        }

        // Method to calculate salary for Software Developer employee
        static void CalculateSalaryForSoftwareDeveloper()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());
            Console.Write("Enter project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());
            Console.Write("Enter extras: ");
            int extras = int.Parse(Console.ReadLine());

            // Calculate the monthly salary using the CalculateSalary method with appropriate parameters
            int monthlySalary = CalculateSalary(workingHours, numberOfWorkingDays, projectHandles, extras);
            Console.WriteLine("Monthly Salary: Rs" + monthlySalary);
        }

        // Method to calculate the monthly salary based on provided parameters
        static int CalculateSalary(int workingHours, int numberOfWorkingDays, int projectHandles = 0, int extras = 0)
        {
            // Calculate the basic salary based on working hours and number of working days
            int basicSalary = workingHours * numberOfWorkingDays * 100;

            // Calculate the project salary based on the number of project handles
            int projectSalary = projectHandles * 3000;

            // Calculate the extra salary based on the number of extras
            int extrasSalary = extras * 2000;

            // Calculate the total monthly salary
            int monthlySalary = basicSalary + projectSalary + extrasSalary;

            return monthlySalary;
        }
    }
 }
     
   

       
       
    

