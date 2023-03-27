namespace Viritual_Companion
{
    public class Pet
    {
        private string Name { get; set; }
        private string Type { get; set; }
        private int Life { get; set; }

        public Pet(string name = "Pinkiepie")
        {
            Name = name;
        }
        public Pet(string name = "Pinkiepie", string type = "Cat")
        {
            Name = name;
            Type = type;
        }
        public Pet(string name = "Pinkiepie", string type = "Cat", int life = 5)
        {
            Name = name;
            Type = type;
            Life = life;
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
