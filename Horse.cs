namespace ProjectHorsey;

class Horse
{
    public string Name { get; set; }
    public int Number  { get; set; }

    public Horse(string name, int number)
    {
        Name = name;
        Number = number;
    }
}