using System.Globalization;

namespace Comparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", R$" + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        // Realizando a compração do objeto
        public int CompareTo(object? obj)
        {
            // Verificando se o objeto não é nulo
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            // Fazendo downCast de outro funcionario para comparação
            Employee other = obj as Employee;

            // Indicando qual parte do objeto sera comparada
            return Name.CompareTo(other.Name); 

            // return Salary.CompareTo(other.Salary); // -> comparação pelo salario e não pelo nome
        }
    }
}
