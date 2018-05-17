using System;
using Fundamentals.Math;
using Fundamentals.Enums;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();
            Console.WriteLine();

            //Non-Static method
            Calculator calc1 = new Calculator();
            var result = calc1.Add(1, 2);
            Console.WriteLine(result);
            Console.WriteLine();

            //identity of int
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine();

            //identity of bool
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            Console.WriteLine();

            //Join using sperators
            var names = new string[] { "Jack", "Mary", "Zachary" };
            string list = string.Join(", ", names);
            Console.WriteLine(list);
            Console.WriteLine();

            //verbatum string
            string verbStr = @"path:zaner\documents\udemy\CSharpBasics";
            Console.WriteLine(verbStr);
            Console.WriteLine();

            //convert to integer
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //convert to enum
            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            //convert int to string enum key
            Console.WriteLine(method.ToString());

            //parsing string to ShippingMethod type
            string methodName = "Express";
            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);


            //Value Type assignment. Value in stack is copied. 
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //Reference Type assignment. Pointer to object is copied.
            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;
            arr2[0] = 0;
            Console.WriteLine(string.Format("arr1[0]: {0}, arr2[0]: {1}", arr1[0], arr2[0]));
            Console.WriteLine();


            //switch statements
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer.");
                    break;
                default:
                    Console.WriteLine("I do not understand that season.");
                    break;
            }

            switch (season)
            {
                case Season.Autumn:
                case Season.Winter:
                    Console.WriteLine("Second Half of the Year.");
                    break;
                default:
                    Console.WriteLine("I do not understand that season.");
                    break;
            }


            //LOOPS
            int x = 0;
            int y = 1;
            int c;
            for (var i = 0; i < 10; i++)
            {
                c = x;
                x = x + y;
                y = c;
                Console.WriteLine("a: {0} \n b: {1} \n\n", x, y);
            }

            var fullName = "Zane Reeder";

            //ForEach
            foreach(var n in fullName)
            {
                Console.WriteLine(n);
            }

            var nums = new int[] { 1, 2, 3, 4 };

            int q;
            foreach (var num in nums)
            {
                q = num + 10;
                Console.WriteLine(q);
            }
            Console.WriteLine();


            //Random Class
            var random = new Random();
            const int PasswordLength = 10;

            var buffer = new char[PasswordLength];
            for (var i = 0; i<PasswordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
