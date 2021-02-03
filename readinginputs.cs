using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining
{
    class Reading_inputs
    {
        /*  Reading Integer input and displaying the same
    Author: Rahul M
    Date: 3/02/2021  */
        static void Main(string[] aregs)
        {
            Console.WriteLine("Enter the value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered value is:" + a);
        }
    }
}
