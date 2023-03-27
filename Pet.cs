namespace Viritual_Companion
{
    public class Pet
    {
        private string Name { get; set; }
        private string Type { get; set; }
        private int Life { get; set; }

        public Pet(string name)
        {
            Name = name;
        }
        public Pet(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public Pet(string name, string type, int life)
        {
            Name = name;
            Type = type;
            Life = life;
        }
    }


}
