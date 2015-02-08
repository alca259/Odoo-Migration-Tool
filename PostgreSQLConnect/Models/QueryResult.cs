using System.Text;

namespace PostgreSQLConnect.Models
{
    public class QueryResult
    {
        public StringBuilder Querys { get; set; }
        public StringBuilder Results { get; set; }
        public bool CanBeExecuted { get; set; }
    }
}
