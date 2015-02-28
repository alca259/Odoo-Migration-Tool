namespace PostgreSQLConnect.Models
{
    public class FieldResult
    {
        #region Properties
        public bool Migrate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Query { get; set; }
        #endregion
    }
}
