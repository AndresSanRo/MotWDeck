using MotWDeckAPI.Data;
using MotWDeckAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotWDeckAPI.Repositories
{
    public class RepositoryMotWDeck : IRepositoryMotWDeck
    {
        IContextMotWDeck Context;
        public RepositoryMotWDeck(IContextMotWDeck Context)
        {
            this.Context = Context;
        }
        public List<Playbook> GetPlaybooks()
        {
            return Context.Playbooks.ToList();
        }
        public Playbook GetPlaybook(int id)
        {
            return Context.Playbooks.SingleOrDefault(playbook => playbook.ID.Equals(id));
        }
        public List<Improvement> GetImprovements()
        {
            return Context.Improvements.ToList();
        }
        public Improvement GetImprovement(int id)
        {
            return Context.Improvements.SingleOrDefault(improvement => improvement.ID.Equals(id));
        }
    }
}
