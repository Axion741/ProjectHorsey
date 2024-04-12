namespace ProjectHorsey;

class Program
{
    static void Main()
    {
        Console.WriteLine("Grand National Randomizer!\n");

        var players = new List<Player>();
        var playerNames = new List<string>(){"Peter", "Emily", "Carolyn", "Alastair"}.ToArray();
        Random.Shared.Shuffle(playerNames);
        var nameList = playerNames.ToList();
        nameList.Add("Kyle");
        playerNames = nameList.ToArray();
        
        foreach (var name in playerNames)
        {
            players.Add(new Player(name));
        }

        StreamReader reader = File.OpenText("runners.txt");
        var fullText = reader.ReadToEnd();
        var horseNames = fullText.Split("\r\n");

        var horseList = new List<Horse>();

        for (int i = 0; i < horseNames.Length; i++)
        {
            var name = horseNames[i];
            horseList.Add(new Horse(name, i + 1));
        }

        var horses = horseList.ToArray();
        Random.Shared.Shuffle(horses);

        var j = 0;

        foreach (var horse in horses)
        {
            players[j].Horses.Add(horse);

            //Console.ReadLine();
            Console.WriteLine($"{players[j].Name} drew: {horse.Number} {horse.Name}");

            if (j < 4)
                j++;
            else
                j = 0;
        }

        foreach(var player in players)
        {
            Console.WriteLine($"\n{player.Name}");

            foreach (var horse in player.Horses)
            {
                Console.WriteLine($"{horse.Number} {horse.Name}");
            }
        } 
    }
}