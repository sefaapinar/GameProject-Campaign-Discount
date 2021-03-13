using GameProject.Adapters;
using GameProject.Entities;
using System;

namespace GameProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            UserManager users1 = new UserManager();
            users1.Add(new User { BirthYear = 2000, FirstName = "Sefa", LastName = "Pınar", IdentityNumber = 21321321321 });

            UserManager usermanager = new UserManager(new MernisServiceAdapter());
            usermanager.Add(users1);
            Console.WriteLine( );



        }
    }
}
