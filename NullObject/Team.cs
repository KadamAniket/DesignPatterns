namespace NullObject
{
    public class Team
    {
        public Team(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; }

        public int Id { get; }

    }

    public class NoTeam : Team
    {
        public NoTeam() : base(-1, "No Team available")
        {

        }

    }
}

