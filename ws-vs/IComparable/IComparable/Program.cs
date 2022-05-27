// Padrão da linguagem para comparar um objeto a outro

using Comparable.Entities;

string path = @"C:\Users\marco\Documents\CSharp\ws-vs\IComparable\IComparable\text.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort();
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred:");
    Console.WriteLine(e.Message);
}