using System;

namespace CsharpTraining
{
    class decrement
    {
        static void Main(string[] args)
        {

            /*  Decrementing the given value
        Author: Rahul M
        Date: 3/02/2021  */
            int a, b;
            a = 50;
            a--;
            Console.WriteLine(" post decrement value is :" + a);
            b = a;
            --b;
            Console.WriteLine("pre decrement value is : " + b);

        }
    }
}
