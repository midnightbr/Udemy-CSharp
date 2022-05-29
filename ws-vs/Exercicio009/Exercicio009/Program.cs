using Exercicio009.Entities;

HashSet<LogRecords> set = new HashSet<LogRecords>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecords { Username = name, Instant = instant });
        }
        Console.WriteLine("Total users: " + set.Count);
    }

} catch (IOException e)
{
    Console.Write("Error: " + e.Message);
}