namespace Viritual_Companion
{
    public class Pet
    {
        private string Name { get; set; }
        private string FavFood { get; set; }
        private int Life { get; set; }

        public Pet(string name = "Pusur", string food = "Lasagna")
        {
            Name = name;
            FavFood = food;
            Life = 5;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetLife()
        {
            return Life;
        }

        public string GetFood()
        {
            return FavFood;
        }

        public void FeedPet()
        {
            Life++;
        }

        public void PlayWithPet()
        {
            Life--;
        }
    }


}
