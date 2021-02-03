using System;

namespace CsharpTraining
{
    class increment
    {
        static void Main(string[] args)
        {

            /*  incrementing the given value
        Author: Rahul M
        Date: 3/02/2021  */
            int a,b;
            a = 25;
            a++;
            Console.WriteLine(" post increment value is :" + a );
            b = a;
            ++b;
            Console.WriteLine("pre increment value is : " + b);

        }
    }
}
