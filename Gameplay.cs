namespace Viritual_Companion
{
    public class Gameplay
    {
        public void InputChoice()
        {
            var input = Console.ReadLine();
            if (input == "1") ChooseName(input);
            else if (input == "2") ChooseType(input);
            else RegeneratePet(input);
        }

        public void ChooseName(string input)
        {
            Console.WriteLine("What is your pet's name?");
            var newName = Console.ReadLine();
            Console.WriteLine("Saved!");
            RegeneratePet(newName);
        }

        public void ChooseType(string input)
        {
            Console.WriteLine("What is your pet's breed?");
            var newType = Console.ReadLine();
            Console.WriteLine("Saved!");
            RegeneratePet(newType);
        }
        public void RegeneratePet(string? input)
        {
            var mainPlay = new MainPlay();
            switch (input)
            {
                case "1":
            }

            if (newPetInput == null)
            {
                var myNewPet = new Pet();
                mainPlay.PetStartPage(myNewPet);
            }
            else
            {

            }
        }
    }
}
