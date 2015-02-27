using System.Text;

namespace PostgreSQLConnect.Models
{
    public class QueryResult
    {
        public StringBuilder QuerysDisableConstraints { get; set; }
        public StringBuilder QuerysEnableConstraints { get; set; }
        public bool DisableConstraints { get; set; }
        public StringBuilder Querys { get; set; }
        public int NumberOfTables { get; set; }
        public StringBuilder Results { get; set; }
        public bool CanBeExecuted { get; set; }
    }
}
