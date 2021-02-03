using System;
/*  Decrementing the given value
        Author: Rahul M
        Date: 3/02/2021  */

namespace CsharpTraining
{
    class decrement
    {
        static void Main(string[] args)
        {

            
            int a, b;
            a = 50;
            /* post decrement*/
            a--;
            Console.WriteLine(" post decrement value is :" + a);
            b = a;
            /* pre decrement*/
            --b;
            Console.WriteLine("pre decrement value is : " + b);

        }
    }
}
