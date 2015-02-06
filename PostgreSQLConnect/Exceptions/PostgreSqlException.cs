using System;

namespace PostgreSQLConnect.Exceptions
{
    public class PostgreSqlException : Exception
    {
        public PostgreSqlException()
        {
        }

        public PostgreSqlException(string message) : base(message)
        {
        }

        public PostgreSqlException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
