using System.Globalization;
using System.Xml.Linq;
using Ex_Prop37.Entities;

namespace Ex_Prop37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary)); 
                }
            }

            Console.Write("Enter salary: $");
            double avg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Email of people whose salary is more than ${avg.ToString("F2", CultureInfo.InvariantCulture)}");
            var emails = list.Where(px => px.Salary > avg).OrderBy(px => px.Email).Select(px => px.Email);

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            var employees = list.Where(px => px.Name.StartsWith("M")).OrderByDescending(px => px.Salary)
                .Select(px => px.Salary);

            double sum = 0;
            foreach (var employee in employees)
            {
                sum += employee;
            }

            Console.WriteLine($"Sum of salary of people whose name starts with 'M': ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}