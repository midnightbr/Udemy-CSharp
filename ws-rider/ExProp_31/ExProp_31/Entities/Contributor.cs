namespace ExProp_31.Entities {
    abstract class Contributor {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Contributor(string name, double annualIncome) {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
