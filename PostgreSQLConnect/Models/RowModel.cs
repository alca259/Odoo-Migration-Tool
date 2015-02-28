using System.Collections.Generic;

namespace PostgreSQLConnect.Models
{
    public class RowModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Fields { get; set; }
    }
}
