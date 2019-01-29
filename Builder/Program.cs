using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new StudentBuilder(10)
                .Setname("hassan")
                .Setfamiy("olfat")
                .Setage("28")
                .Setphone("0918")
                .build();


            Console.WriteLine(s.GetDetails());
            Console.ReadKey();
        }
    }
}
