namespace Viritual_Companion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE DAY CARE\n");
            Console.WriteLine("Write your new pet's name \n or");
            Console.WriteLine("push 'enter' to generate a random pet.\n");
            var gameplay = new Gameplay();
            gameplay.InputChoice();
        }
    }
}