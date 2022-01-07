namespace ExProp_27 {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            addSalary(salary);
        }

        public void addSalary(double salary) {
            Salary += salary;
        }
        
        public void increaseSalary(double percentage) {
            double rise = Salary * (percentage / 100);
            addSalary(rise);
        }

        public override string ToString() {
            return Id + ", " +  Name + ", " + "$" + Salary;
        }
    }
}
