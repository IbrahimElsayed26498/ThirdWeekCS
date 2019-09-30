// In the name of Allah, the Gracious, the Merciful
using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user;
            string name, job, phone, address, email, password;
            List<User> list = new List<User>();
            int numberOfUsers;

            Console.Write("Enter number of Users : ");
            numberOfUsers = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<numberOfUsers; i++)
            {
                Console.WriteLine("User number : {0}\n\n-----------------\n", i+1 );

                // taking data from user

                Console.Write("Enter name : ");
                name = Console.ReadLine();

                Console.Write("Enter job : ");
                job = Console.ReadLine();

                Console.Write("Enter phone : ");
                phone = Console.ReadLine();

                Console.Write("Enter address : ");
                address = Console.ReadLine();

                Console.Write("Enter email : ");
                email = Console.ReadLine();

                Console.Write("Enter password : ");
                password = Console.ReadLine();

                Console.WriteLine("\n\n");

                // adding user to list
                user = new User(name, job, phone, address, email, password);
                list.Add(user);
            }

            // printing data on the screen
            foreach(User u in list)
            {
                Console.WriteLine(u.ToString());
            }
        }
    }
}
