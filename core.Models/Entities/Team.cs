namespace Core.Models.Entities
{
    public enum Color
    {
        White,
        Red,
        Green,
        Blue
    }

    public class Team
    {
        public string Name { get; set; }

        public string NickName { get; set; }

        public Color ShirtColor { get; set; }

        public string HomeTown { get; set; }

        public string Ground { get; set; }

        public Team(
            string name,
            string nickName,
            Color shirtColor,
            string homeTown,
            string ground)
        {
            Name = name;
            NickName = nickName;
            ShirtColor = shirtColor;
            HomeTown = homeTown;
            Ground = ground;
        }
    }
}
