namespace ExProp_31.Entities {
    class PrivatePerson : Contributor{
        public double Health { get; set; }

        public PrivatePerson(string name, double annualIncome, double health) : base(name, annualIncome) {
            Health = health;
        }

        public override double Tax() {
            if (AnnualIncome <= 20000 && Health != null) {
                return (AnnualIncome * 0.15) - (Health * 0.50);
            }
            else if (AnnualIncome <= 20000 && Health == null) {
                return AnnualIncome * 0.15;
            }
            else if (AnnualIncome > 20000 && Health != null) {
                return (AnnualIncome * 0.25) - (Health * 0.50);
            }
            else {
                return AnnualIncome * 0.25;
            }
        }
    }
}
