namespace Viritual_Companion
{
    public class Pet
    {
        private string Name { get; set; }
        private string Type { get; set; }
        private int Life { get; set; }

        public Pet(string name = "Pinkiepie", string type = "Cat")
        {
            Name = name;
            Type = type;
            Life = 5;
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
