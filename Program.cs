using System;
using System.Collections.Generic;


namespace Assisgnment_08
{
    public class SalaryCalculator
        {
            public static int CalculateSalary(string employeeType, int workingHours, int numberOfWorkingDays, int projectHandles = 1, int extras = 0)
            {
                int baseSalary = workingHours * numberOfWorkingDays * 100;
                int projectHandlesBonus = projectHandles * 3000;
                int extrasBonus = extras * 2000;

                int salary = baseSalary + projectHandlesBonus + extrasBonus;

                switch (employeeType)
                {
                    case "HR":
                        salary += 0;
                        break;
                    case "Admin":
                        salary += projectHandlesBonus;
                        break;
                    case "Software Developer":
                        salary += extrasBonus;
                        break;
                    default:
                        throw new Exception("Invalid employee type");
                }

                return salary;
            }

            public static void Main()
            {
                string employeeType;
                int workingHours;
                int numberOfWorkingDays;

                try
                {
                    Console.WriteLine("Enter employee type: ");
                    employeeType = Console.ReadLine();

                    Console.WriteLine("Enter working hours: ");
                    workingHours = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number of working days: ");
                    numberOfWorkingDays = int.Parse(Console.ReadLine());

          

                    int salary = CalculateSalary(employeeType, workingHours, numberOfWorkingDays);

                    Console.WriteLine("The salary for the employee is: " + salary);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Emp Not Found");
                }
            Console.ReadKey();
            }
        }
    }

   

       
       
    
}
