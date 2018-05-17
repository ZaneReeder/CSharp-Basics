using System;
using System.Collections.Generic;
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

            //MultiDimensional Array
            var rectMatrix = new int[3, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 }
            };
            var row1 = new int[5];
            for (int i = 0; i < 5; i++)
                row1[i] = rectMatrix[0, i];

            //IndexOf()
            int index = Array.IndexOf(row1, 4);
            Console.WriteLine("Index of 4: " + index);

            //Clear()
            Array.Clear(row1, 0, 2);
            Console.WriteLine("Cleared array:\t");
            foreach (var n in row1)
                Console.Write( n +"\t");
            Console.WriteLine();
            Console.WriteLine();

            //Copy()
            int[] arr = new int[5];
            Array.Copy(row1, arr, 5);
            Console.WriteLine("Copied array:\t");
            foreach (var n in arr)
                Console.Write(n + "\t");
            Console.WriteLine();
            Console.WriteLine();

            //Sort()
            var arr3 = new int[4] { 3, 5, 2, 4 };
            Console.WriteLine("Unsorted array:\t");
            foreach (var n in arr3)
                Console.Write(n + "\t");
            Console.WriteLine();

            Array.Sort(arr3);
            Console.WriteLine("Sorted array:\t");
            foreach (var n in arr3)
                Console.Write(n + "\t");
            Console.WriteLine();

            //Reverse()
            Array.Reverse(arr3);
            Console.WriteLine("Reversed array:\t");
            foreach (var n in arr3)
                Console.Write(n + "\t");
            Console.WriteLine();
            Console.WriteLine();

            //Lists

            var numeros = new List<int>() { 1, 2, 3, 4, 5 };
            numeros.Add(1); //append 1 to end of List
            numeros.AddRange(new int[4] { 5, 6, 7, 1 }); //append array or list

            var numeroIndex = numeros.LastIndexOf(1);
            numeroIndex = numeros.IndexOf(1);

            numeros.Remove(1);
            //foreach(var n in numeros) //modifications not allowed within foreach
            //{
            //    if (n == 1)
            //    {
            //        numeros.Remove(n);
            //    }
            //}


            //Date-Time
            var dateTime = new DateTime(2018, 5, 17);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Min: " + now.Minute);
            Console.WriteLine("Sec: " + now.Second);
            Console.WriteLine();

            //immutable objects
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            Console.WriteLine();
            

            //TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);//1hr 2min 3sec
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            Console.WriteLine("Mins: " + timeSpan.Minutes);
            Console.WriteLine("Total Mins: " + timeSpan.TotalMinutes);

            //immutable objects



        }
    }
}
