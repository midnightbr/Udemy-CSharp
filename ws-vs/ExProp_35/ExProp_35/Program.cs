using ExProp_35.Entities;

HashSet<Student> students = new HashSet<Student>();

Console.Write("How many students for course A? ");
int courseA = int.Parse(Console.ReadLine());
for (int i = 0; i < courseA; i++)
{
    Console.Write("Student code: ");
    int studentCode = int.Parse(Console.ReadLine());
    students.Add(new Student { Course = "A", StudentCode = studentCode });
}

Console.Write("How many students for course B? ");
int courseB = int.Parse(Console.ReadLine());
for(int i = 0; i < courseB; i++)
{
    Console.Write("Student code: ");
    int studentCode = int.Parse(Console.ReadLine());
    students.Add(new Student { Course= "B", StudentCode = studentCode });
}

Console.Write("How many students for course C? ");
int courseC = int.Parse(Console.ReadLine());
for (int i = 0; i < courseC; i++)
{
    Console.Write("Student code: ");
    int studentCode = int.Parse(Console.ReadLine());
    students.Add(new Student { Course = "C", StudentCode = studentCode });
}

Console.Write("Total students: " + students.Count);

/*
 * Solução feita pelo professor: https://github.com/acenelio/set2-csharp
 */