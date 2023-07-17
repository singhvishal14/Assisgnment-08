using System;
using System.Collections.Generic;


namespace Assisgnment_08
{
    public class Salary
    {
        public static int Calculator(string Emp, int wHour, int nWdays, int projectHandle = 1, int extra = 0)
        {
            int baseSalary = wHour * nWdays;
            int projectBonus = projectHandle * 3000;
            int extraBous = extra * 2000;
            int salry = baseSalary + projectBonus + extraBous;
            switch (Emp)
            {
                case "HR":
                    salry += 0;
                    break;
                case "Admin":
                    salry += projectBonus;
                    break;
                case "SE":
                    baseSalary += extraBous;
                    break;
                default:
                    throw new Exception("Please Enter");
            }
            return salry;

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                
                int salry = Calculator("HR", 8, 20);
                Console.WriteLine("the Salary for HR is: "+salry);

                salry = Calculator("Admin", 8, 20,2);
                Console.WriteLine("the Salary for Admin is: " + salry);

                salry = Calculator("SE", 8, 20,1,1000);
                Console.WriteLine("the Salary for SE is: " + salry);
                Console.ReadKey();
            }
            
        }
       
    }
}
