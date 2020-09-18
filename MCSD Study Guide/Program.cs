using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSD_Study_Guide
{
    class Calculator
    {
        static void Main()
        {
            Operation();           
        }       
        static void Operation()
        {            
            Console.WriteLine("Press any following key to perform an arithmetic operation:" +
                "1-Addittion " +
                "2-Substraction " +
                "3-Multipliation " +
                "4-Division ");
            int caseSwitch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 1:");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 2:");
            int value2 = int.Parse(Console.ReadLine());
            Switch(caseSwitch, value1, value2);
            Console.WriteLine("Do you want to continue again (Y/N)?");           
            while (Console.ReadLine() == "Y")
                Operation();
        }
        static void Switch(int caseSwitch, int value1, int value2)
        {
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine(value1 + value2);
                    break;
                case 2:
                    Console.WriteLine(value1 - value2);
                    break;
                case 3:
                    Console.WriteLine(value1 * value2);
                    break;
                case 4:
                    Console.WriteLine(value1 / value2);
                    break;
            }
        }
    }
}

