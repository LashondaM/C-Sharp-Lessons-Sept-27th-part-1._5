using System;

namespace C_Sharp_Lessons_Sept_27th_part_1._5
{
    class Program
    {
        static void Main(string[] args)
        {

            var mathlib = new MathLib();

            //var mod = mathlib.Mod(17, 2);
            //Console.WriteLine(mod);

            //var inc = mathlib.Inc(4);
            //Console.WriteLine(inc);

            //var addResult = mathlib.Add(1, 6);
            //Console.WriteLine($"Answer is {addResult}");

            //var math2 = new MathLib();
            //var subResult = math2.Sub(10, 2);
            //Console.WriteLine($"Answer is {subResult}");

            //var subResult = mathlib.Sub(10, 2); //use this way instead
            //Console.WriteLine(subResult);

            //var math3 = new MathLib();
            //var multResult = math3.Mult(100, 500);
            //Console.WriteLine($"Answer is {multResult}");

            var multResult = mathlib.Mult(10, 2);
            Console.WriteLine(multResult);

            //var math4 = new MathLib();
            //var divResult = math4.Sub(250, 2);
            //Console.WriteLine($"Answer is {divResult}");

            // Print is a method

            // apart of the Student class section
            //var fred = new Student();
            //fred.Name = "Fred";
            //fred.SAT = 1000;
            //var debra = new Student();
            //debra.Name = "Debra";
            //debra.SAT = 2000;

            //var barney = new Student();
            //barney.Name = "Barney";
            //barney.SAT = 1200;

            ////debra.Print(1);
            //var message = debra.Print(1);
            //Console.WriteLine(message);

            //message = fred.Print(2);
            //Console.WriteLine(message);

            ////fred.Print(2);
            //barney.Print(3);

            //barney.SAT += 20;
            //barney.Print(4);


        }
    }
}
