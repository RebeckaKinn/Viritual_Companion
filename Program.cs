namespace Viritual_Companion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE DAY CARE\n");
            Console.WriteLine("1 - Custom name");
            Console.WriteLine("2 - Custom type");
            Console.WriteLine("3 - Custom life (default is 5)");
            Console.WriteLine("Push anything else to GENERATE PET");
            var gameplay = new Gameplay();
            gameplay.InputChoice();
        }
    }
}