namespace Exercicio009.Entities
{
    internal class LogRecords
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecords))
            {
                return false;
            }
            LogRecords other = obj as LogRecords;
            return Username.Equals(other.Username);
        }
    }
}
