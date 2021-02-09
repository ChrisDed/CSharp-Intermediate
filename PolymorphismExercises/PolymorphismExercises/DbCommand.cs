using System;

namespace PolymorphismExercises
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("Cannot pass a null DbConnection");

            if (String.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Cannot pass null or empty string for DB instruction");

            _dbConnection = dbConnection;
            _instruction = instruction;

        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
        }
    }
}
