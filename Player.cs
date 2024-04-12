namespace ProjectHorsey;

class Player
{
    public string Name { get; set; }
    public List<Horse> Horses { get; set; } = new List<Horse>();

    public Player(string name)
    {
        Name = name;
    }
}