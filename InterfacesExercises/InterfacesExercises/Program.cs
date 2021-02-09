using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflow.Add(new MailNotification());
            workflow.Add(new ChangeVideoRecord());

            WorkflowEngine engine = new WorkflowEngine();
            engine.Run(workflow);
        }
    }
}
