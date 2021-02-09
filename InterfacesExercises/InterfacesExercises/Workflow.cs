using System.Collections.Generic;

namespace InterfacesExercises
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activites;

        public Workflow()
        {
            _activites = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activites.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activites.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activites;
        }
    }
}
