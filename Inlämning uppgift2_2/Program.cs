using System;

namespace uppgift2_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt har Elin hoppat?");
            int X=int.Parse(Console.ReadLine());
            Console.WriteLine("hur långt har Alma hoppat?");
            int Y=int.Parse(Console.ReadLine());
            Console.WriteLine("skillnade mellan Eling och Alma är..");
            int sum = X - Y;
            Console.WriteLine(sum);
                



        }


    }

}