namespace ExProp_35.Entities
{
    internal class Student
    {
        public string Course { get; set; }
        public int StudentCode { get; set; }

        public override int GetHashCode()
        {
            return StudentCode.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return StudentCode.Equals(other.StudentCode);
        }
    }
}
