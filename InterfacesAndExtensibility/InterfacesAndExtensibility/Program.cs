using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new FileLogger("C:\\bin\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
