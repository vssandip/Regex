using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~ Welcome To User Registration ~~");
            //UC1
            Validation person = new Validation();
            Console.WriteLine("Enter The First Name: ");
            string firstName = Console.ReadLine();
            person.ValidateFirstName(firstName);
            //UC2
            Validation1 person1 = new Validation1();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Last Name: ");
            string lastName = Console.ReadLine();
            person1.ValidLastName(lastName);

            //UC3
            Validation2 person2 = new Validation2();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Email_ID: ");
            string EmailID = Console.ReadLine();
            person2.EmailID(EmailID);

            //UC4
            Validation3 person3 = new Validation3();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Phone_Number: ");
            string Phone_Number = Console.ReadLine();
            person3.Phonenumber(Phone_Number);

            //UC5
            Validation4 person4 = new Validation4();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The Password: ");
            string Password = Console.ReadLine();
            person4.Password(Password);
        }
    }
}