namespace DejesusFirstProject
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {


                Console.WriteLine("    LOGIN     ");
                string user = "tomjustine";
                string pass = "bsitoverallchampion123";
                Console.Write("Enter username: ");
                string inputUser = Console.ReadLine();

                Console.Write("Enter password: ");
                string inputPassword = Console.ReadLine();  

                if (inputUser == user && inputPassword == pass)
                {
                    Console.WriteLine("Login Successful! Welcome.");
                }
                else
                {
                    Console.WriteLine("Incorrect password! Please Try Again.");
                }
            }
        }
    }

