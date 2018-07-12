namespace Core.DesignPatterns.Creational
{
    public class Person
    {
        public string Name;

        public string Position;

        private class Builder : PersonInfoBuilder<Builder> { /* degenerate */ }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }

    internal abstract class PersonBuilder<TSelf>
      where TSelf : PersonBuilder<TSelf>
    {
        protected Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }

    class PersonInfoBuilder<TSelf> : PersonBuilder<PersonInfoBuilder<TSelf>>
      where TSelf : PersonInfoBuilder<TSelf>
    {
        public TSelf Called(string name)
        {
            Person.Name = name;
            return (TSelf)this;
        }
    }

    internal class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>>
      where TSelf : PersonJobBuilder<TSelf>
    {
        public TSelf WorksAsA(string position)
        {
            Person.Position = position;
            return (TSelf)this;
        }
    }

}