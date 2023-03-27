namespace Viritual_Companion
{
    public class Gameplay
    {
        public void InputChoice()
        {
            var input = Console.ReadLine();
            if (input == "1") ChooseName(input);
            else if (input == "2") ChooseType(input);
            else RegeneratePet(input, null);
        }

        public void ChooseName(string input)
        {
            Console.WriteLine("What is your pet's name?");
            var newName = Console.ReadLine();
            Console.WriteLine("Saved!");
            RegeneratePet(input, newName);
        }

        public void ChooseType(string input)
        {
            Console.WriteLine("What is your pet's breed?");
            var newType = Console.ReadLine();
            Console.WriteLine("Saved!");
            RegeneratePet(input, newType);
        }
        public void RegeneratePet(string? input, string? newPetInput)
        {
            var mainPlay = new MainPlay();
            if (input == null && newPetInput == null)
            {
                var myNewPet = new Pet();
                mainPlay.PetStartPage(myNewPet);
            }
        }
    }
}
