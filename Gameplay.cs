namespace Viritual_Companion
{
    public class Gameplay
    {
        public void InputChoice()
        {
            var mainPlay = new MainPlay();
            var newPetList = new PetList();
            var input = Console.ReadLine();
            if (input == "\r" || input == null) RegeneratePet(mainPlay);
            else
            {
                var newPet = new Pet(input);
                newPetList.AddPet(newPet);
                mainPlay.PetStartPage(newPet);
            }
        }
        public void RegeneratePet(MainPlay mainPlay)
        {
            var newPet = new Pet();
            mainPlay.PetStartPage(newPet);
        }
    }
}
