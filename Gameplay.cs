namespace Viritual_Companion
{
    public class Gameplay
    {
        public void InputChoice()
        {
            var input = Console.ReadLine();
            if (input == "1") ChooseName();
            else if (input == "2") ChooseType();
            else if (input == "3") ChooseHealth();
            else RegeneratePet();
        }

        public void ChooseName()
        {
            Console.WriteLine("What is your pet's name?");
            var newName = Console.ReadLine();
            new Pet(newName);
            Console.WriteLine("Saved!");
            InputChoice();
        }
        public void RegeneratePet()
        {

        }
    }
}
