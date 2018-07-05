using Core.Models.Entities;

namespace Core.Models.Builders
{
    public class TeamBuilder
    {
        private string _name;
        private string _nickName;
        private Color _shirtColor;
        private string _homeTown;
        private string _ground;

        public TeamBuilder CreateTeam(string name)
        {
            _name = name;
            return this;
        }

        public TeamBuilder WithNickName(string nickName)
        {
            _nickName = nickName;
            return this;
        }

        public TeamBuilder WithShirtColor(Color shirtColor)
        {
            _shirtColor = shirtColor;
            return this;
        }

        public TeamBuilder FromTown(string homeTown)
        {
            _homeTown = homeTown;
            return this;
        }

        public TeamBuilder PlayingAt(string ground)
        {
            _ground = ground;
            return this;
        }

        //public Team Build()
        //{
        //    return new Team(name, nickName, shirtColor, homeTown, ground);
        //}

        public static implicit operator Team(TeamBuilder tb)
        {
            return new Team(
                tb._name,
                tb._nickName,
                tb._shirtColor,
                tb._homeTown,
                tb._ground);
        }
    }
}
