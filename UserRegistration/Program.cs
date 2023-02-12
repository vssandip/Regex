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
        }
    }
}