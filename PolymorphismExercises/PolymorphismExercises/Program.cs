using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sql = new SqlConnection("a8643hdugfw72");
            OracleConnection oracle = new OracleConnection("if83473ujdhw");
            DbCommand command = new DbCommand(oracle, "SELECT * FROM EX_TABLE");
            command.Execute();
        }
    }
}
