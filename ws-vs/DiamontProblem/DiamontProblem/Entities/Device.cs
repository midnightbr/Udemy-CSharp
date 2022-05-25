namespace DiamontProblem.Entities
{
    abstract class Device
    {

        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(String document);

    }
}
