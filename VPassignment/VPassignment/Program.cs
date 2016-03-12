using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeCalculator;

namespace VPassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice='y';
            do
            {
                int siblings, formate;
                Console.WriteLine("Please Enter Number of Siblings?");
                siblings = Convert.ToInt32(Console.ReadLine());
                if (siblings>0)
                {
                    Calculator obj_calculator = new Calculator();
                    if (siblings >= 1)
                    {
                        formate = obj_calculator.dateFormates();
                        string[] ages = obj_calculator.inputAges(siblings);
                        int[] days = new int[siblings];
                        int[] months = new int[siblings];
                        int[] years = new int[siblings];
                        obj_calculator.conversion(ref days, ref months, ref years, ages, formate);
                        if (obj_calculator.ageCalculation(ref days, ref months, ref years, siblings))
                        {
                            if (siblings > 1)
                            {
                                obj_calculator.difference(days, months, years, siblings);
                            }
                            else
                            {
                                Console.WriteLine("Can Not Calculate Age Difference in a single sibling");
                            }
                            Console.WriteLine("\nDo You Want To Run This Program Again??(y/n)");
                            choice = Convert.ToChar(Console.ReadLine());
                            if (choice == 'y' || choice == 'Y')
                            {
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nDo You Want To Run This Program Again??(y/n)");
                            choice = Convert.ToChar(Console.ReadLine());
                            if (choice == 'y' || choice == 'Y')
                            {
                                Console.Clear();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry!!! Invalid Input");
                        Console.WriteLine("\nDo You Want To Run This Program Again??(y/n)");
                        choice = Convert.ToChar(Console.ReadLine());
                        if (choice == 'y' || choice == 'Y')
                        {
                            Console.Clear();
                        }
                    }  
                }
                else
                {
                    Console.WriteLine("\nDo You Want To Run This Program Again??(y/n)");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice == 'y' || choice == 'Y')
                    {
                        Console.Clear();
                    }
                }
                
            } while (choice=='y' || choice=='Y');
            
        }
    }
}