namespace ExConjuntos.Entities
{
    internal class LogRecord
    {
        public int Id { get; set; }

        public LogRecord(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = obj as LogRecord;

            return Id.Equals(other.Id); 
        }
    }
}
