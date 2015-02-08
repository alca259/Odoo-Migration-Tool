
using System.Collections.Generic;

namespace PostgreSQLConnect.Models
{
    public class TableModel
    {
        public string TableName { get; set; }
        public List<string> Columns { get; set; }
    }
}
