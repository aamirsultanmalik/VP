using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public class Calculator
    {
        public int dateFormates()
        {
            int format;
            Console.WriteLine("Please Select Date of Birth's Format\n\t1:\tDD/MM/YYYY\n\t2:\tMM/DD/YYYY\n\t3:\tYYYY/MM/DD");
            format = Convert.ToInt32(Console.ReadLine());
            return format;
        }
        public string[] inputAges(int siblings)
        {
            string[] ages = new string[siblings];
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine("Please Enter date of birth of Sibling {0}", i + 1);
                ages[i] = Console.ReadLine();
            }
            return ages;
        }
        public void conversion(ref int[] days, ref int[] months, ref int[] years, string[] ages, int formate)
        {
            if (formate == 1)
            {
                for (int i = 0; i < ages.Length; i++)
                {
                    char[] arr = ages[i].ToCharArray();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr.Length==10)
                        {
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 2)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 2 && j < 5)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 5 && j < arr.Length)
                                {
                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                            }
                        }
                        else if (arr.Length==9)
                        {
                            if (arr[2]=='-' ||arr[2]=='\\'|| arr[2]=='/')
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 2)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 2 && j < 4)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < arr.Length)
                                {

                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                               
                            }
                            else if (arr[1]=='-' ||arr[1]=='\\'|| arr[1]=='/')
                            {
                                if ((arr[j] != '-' ||arr[j] != '\\' ||arr[j] != '/'  ) && j < 1)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 1 && j < 4)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < arr.Length)
                                {

                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                            }
                        }
                        else if (arr.Length==8)
                        {
                            if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 1)
                            {
                                days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                            }
                            else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 1 && j < 3)
                            {
                                months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                            }
                            else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 3 && j < arr.Length)
                            {

                                years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                            }
                        }
                        
                    }
                }
            }
            else if (formate==2)
            {
                for (int i = 0; i < ages.Length; i++)
                {
                    char[] arr = ages[i].ToCharArray();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr.Length == 10)
                        {
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 2)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 2 && j < 5)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 5 && j < arr.Length)
                                {
                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                            }
                        }
                        else if (arr.Length == 9)
                        {
                            if (arr[2] == '-' || arr[2] == '\\' || arr[2] == '/')
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 2)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 2 && j < 4)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < arr.Length)
                                {

                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }

                            }
                            else if (arr[1] == '-' || arr[1] == '\\' || arr[1] == '/')
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 1)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 1 && j < 4)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < arr.Length)
                                {

                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                            }
                        }
                        else if (arr.Length == 8)
                        {
                            if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 1)
                            {
                                months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                            }
                            else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 1 && j < 3)
                            {
                                days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                            }
                            else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 3 && j < arr.Length)
                            {

                                years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                            }
                        }

                    }
                }
            }
            else if (formate==3)
            {
                for (int i = 0; i < ages.Length; i++)
                {
                    char[] arr = ages[i].ToCharArray();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr.Length == 10)
                        {
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 4)
                                {
                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < 7)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 7 && j < arr.Length)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                            }
                        }
                        else if (arr.Length == 9)
                        {
                            if (arr[6] == '-' || arr[6] == '\\' || arr[6] == '/')
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 4)
                                {
                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < 6)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 6 && j < arr.Length)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }

                            }
                            else if (arr[7] == '-' || arr[7] == '\\' || arr[7] == '/')
                            {
                                if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 4)
                                {
                                    years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < 7)
                                {
                                    months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                                }
                                else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 7 && j < arr.Length)
                                {
                                    days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                                }
                            }
                        }
                        else if (arr.Length == 8)
                        {
                            if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j < 4)
                            {
                                years[i] = int.Parse(years[i].ToString() + arr[j].ToString());
                            }
                            else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 4 && j < 6)
                            {
                                months[i] = int.Parse(months[i].ToString() + arr[j].ToString());
                            }
                            else if ((arr[j] != '-' || arr[j] != '\\' || arr[j] != '/') && j > 6 && j < arr.Length)
                            {
                                days[i] = int.Parse(days[i].ToString() + arr[j].ToString());
                            }
                        }

                    }
                }
            }
        }
        public bool ageCalculation(ref int[] days, ref int[] months, ref int[] years, int siblings)
        {
            bool value=false;
            for (int i = 0; i < siblings; i++)
            {
                if ((days[i]<32))
                {
                    if ((months[i]<13))
                    {
                        days[i] = DateTime.Now.Day - days[i];
                        months[i] = DateTime.Now.Month - months[i];
                        years[i] = DateTime.Now.Year - years[i];
                        if (days[i] < 0)
                        {
                            days[i] = days[i] - (days[i] * 2);
                            days[i] = 30 - days[i];
                            months[i]--;
                        }
                        if (months[i] < 0)
                        {
                            months[i] = months[i] - (months[i] * 2);
                            months[i] = 12 - months[i];
                        }
                        Console.WriteLine("\n\t\tAge of sibling {0} ", i + 1);
                        Console.WriteLine("\n{0}Years  {1} Month {2} Days", years[i], months[i], days[i]);
                        value= true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry Date Of Birth is Incorrect!!! Please Review It Again");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry Date Of Birth is Incorrect!!! Please Review It Again");
                    return false;
                }
            }
            return value;
        }
        public void difference(int[] days, int[] months, int[] years, int siblings)
        {
            int dayDiff, monDiff, yearDiff;
            for (int i = 0; i < days.Length; i++)
            {
                if (i != days.Length - 1)
                {
                    yearDiff = years[i] - years[i + 1];
                    monDiff = months[i] - months[i + 1];
                    dayDiff = days[i] - days[i + 1];
                    if (dayDiff < 0)
                    {
                        dayDiff = dayDiff - (dayDiff * 2);
                        dayDiff = 30 - dayDiff;
                        monDiff--;
                    }
                    if (monDiff < 0)
                    {
                        monDiff = monDiff - (monDiff * 2);
                        monDiff = 12 - monDiff;
                    }
                    if (yearDiff < 0)
                    {
                        yearDiff = yearDiff - (yearDiff * 2);
                    }
                    Console.WriteLine("\n\t\tDifference Between sibling {0} and {1}", i + 1, i + 2);
                    Console.WriteLine("\n{0}Years  {1} Month {2} Days", yearDiff, monDiff, dayDiff);
                    i++;
                }
                else
                {
                    yearDiff = years[i] - years[i - 1];
                    monDiff = months[i] - months[i - 1];
                    dayDiff = days[i] - days[i - 1];
                    if (dayDiff < 0)
                    {
                        dayDiff = dayDiff - (dayDiff * 2);
                        dayDiff = 30 - dayDiff;
                        monDiff--;
                    }
                    if (monDiff < 0)
                    {
                        monDiff = monDiff - (monDiff * 2);
                        monDiff = 12 - monDiff;
                    }
                    if (yearDiff < 0)
                    {
                        yearDiff = yearDiff - (yearDiff * 2);
                    }
                    Console.WriteLine("\n\t\tDifference Between sibling {0} and {1}", i, i + 1);
                    Console.WriteLine("\n{0}Years  {1} Month {2} Days", yearDiff, monDiff, dayDiff);
                }
            }
        }
    }
}
