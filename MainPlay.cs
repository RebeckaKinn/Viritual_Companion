namespace Viritual_Companion
{
    public class MainPlay
    {
        public void Menu()
        {
            Console.WriteLine("1 - Play\n2 - Feed\n3 - See stats");
        }
        public void PetStartPage(Pet CurrentPet)
        {
            FeedPet(CurrentPet);
        }

        public void FeedPet(Pet CurrentPet)
        {
            var input = Console.ReadLine();
            var chosenFood = input == CurrentPet.GetFood() ? CurrentPet.GetFood() : input;
            CurrentPet.FeedPet(chosenFood);
        }
    }
}
