using System;

namespace KEK
{
    class Program
    {
        static void Main(string[] args)
        {
            //login:admin
            //password: pass1234
            
            //deslare variablas
            //assing value -
            string login = "admin";
            string password = "pass1234";

            string userName, userPassword;

            Console.WriteLine("enthe your login:");
            userName = Console.ReadLine();
            Console.WriteLine("enthe your password:");
            userPassword = Console.ReadLine();

            if (login==userName && password==userPassword)
                Console.WriteLine("Welcome!");
            else
                Console.WriteLine("Oops!");

        }
    }
}
