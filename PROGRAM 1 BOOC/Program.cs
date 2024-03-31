using System;

namespace PROGRAM_1_BOOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxAtmpt = 3;
            int IncAtmpt = 0;
            while (IncAtmpt < MaxAtmpt)
            {
                Console.WriteLine("Hey There!, What's Your Username?");
                string username = Console.ReadLine();
                if (username == ("Admin"))
                {
                    Console.WriteLine("Welcome Back! " + username + " What's Your Password?");
                    string password = Console.ReadLine();
                    if (password == ("Admin1234!"))
                    {
                        Console.WriteLine("Alrighty! " + username + " Your Login is Successful!"); break;
                    }
                    else
                    {
                        Console.WriteLine("OOPS! Incorrect... Try Again!");
                        IncAtmpt++;
                    }
                }
                else
                {
                    Console.WriteLine("OOPS! Incorrect... Try Again!");
                    IncAtmpt++;
                }
            }
            if (IncAtmpt == MaxAtmpt)
            {
                Console.WriteLine(" STOP IT... GET SOME HELP");
            }
        }
    }
}
