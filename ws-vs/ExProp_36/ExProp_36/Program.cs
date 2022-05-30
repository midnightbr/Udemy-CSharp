Dictionary<string, int> vote = new Dictionary<string, int>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int wishes = int.Parse(line[1]);
            if (!vote.ContainsKey(name))
            {
                vote[name] = wishes;
            }
            else
            {
                vote[name] += wishes;
            }
        }

        foreach (var item in vote)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Error: " + e.Message);
}

/**
 * Solução feita pelo professor: https://github.com/acenelio/dictionary1-csharp
 */