namespace PostgreSQLConnect.Models
{
    public class TableSequence
    {
        public bool Active { get; set; }
        public string Sequence { get; set; }
        public string Table { get; set; }
        public int MaxId { get; set; }
    }
}
