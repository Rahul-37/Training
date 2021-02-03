using System;
/*  incrementing the given value
Author: Rahul M
Date: 3/02/2021  */
namespace CsharpTraining
{
    class increment
    {
        static void Main(string[] args)
        {


            int a,b;
            a = 25;
            /* post increment*/
            a++;
            Console.WriteLine(" post increment value is :" + a );
            b = a;
            /* pre increment*/
            ++b;
            Console.WriteLine("pre increment value is : " + b);

        }
    }
}
