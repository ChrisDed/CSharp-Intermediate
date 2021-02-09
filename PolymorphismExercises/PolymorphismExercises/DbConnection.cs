using System;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection string should not be null or empty.");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
