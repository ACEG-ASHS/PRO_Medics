using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Promedics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Super Basic Version 
            Console.WriteLine("WELCOME TO PROMEDICS");
            Console.WriteLine("_DESCRIPTION_");

            Console.WriteLine();

            Console.WriteLine("PLEASE ENTER YOUR AGE:");
            int User_Age = int.Parse(Console.ReadLine());
            Console.WriteLine("PLEASE ENTER YOUR SEX AT BIRTH:");
            string User_Sex = Console.ReadLine();

            // Display Benefit Programs

            Console.WriteLine();

            string Run = "Yes";
            while (Run == "Yes") 
                {
                    Console.WriteLine("BENEFIT PROGRAMS");
                    Console.WriteLine(@"
                        1 - Outpatient Benefits  
                        2 - Senior Citizen Benefits 
                        3 - Inpatient Benefits 
                        4 - Z Benefits
                        5 - Maternity Benefits  
                        6 - HELP");
                    string BP_Choice = Console.ReadLine();
                    if (BP_Choice == "1")
                        {
                            /* Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location */
                        }
                    else if (BP_Choice == "2" && User_Age >= 60)
                        { 
                            /* Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location */
                        }
                    else if (BP_Choice == "3")
                        { 
                            /* Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location */
                        }
                    else if (BP_Choice == "4")
                        { 
                            /* Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location */
                        }
                    else if (BP_Choice == "5")
                        { 
                            /* Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location */
                        }
                    else if (BP_Choice == "6")
                        { 
                            /* Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location */
                        }
                    else 
                        { 
                    Console.WriteLine("ERROR");
                    Console.WriteLine("INVALID INPUT");
                    Console.WriteLine();
                    Console.WriteLine("RETURN TO SELECTION PAGE?");
                    Run = Console.ReadLine();
                        }
            }
            

            /* START
                Display Welcome Prompt
                Input Age
                Input Sex
                Display Interface of Benefit Programs
                Input Required Type of Benefit Program
                    1 - Outpatient Benefits  
                    2 - Senior Citizen Benefits 
                    3 - Inpatient Benefits 
                    4 - Z Benefits
                    5 - Maternity Benefits  
                    6 - HELP
                        If Input == 1
                            Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location
                        Else If Input == 2 && Age >= 60
                            Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location
                        Else If Input == 3
                            Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location
                        Else If Input == 4 
                            Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location :D
                        Else If Input == 5 && Sex == F
                            Display Summarized Outpatient Benefit Programs
                            Input Selected Program
                            Display Health Facilities with Available Selected Programs
                            Display Selected Health Facility’s Location
                        Else If Input == 6
                            Display Information of the Different Types of Benefit Programs
                            Loop back to Display Interface of Benefit Programs
                        Else
                            Display Invalid Prompt Message
                            Loop back to Display Interface of Benefit Programs
                        END */

        }
    }
}
