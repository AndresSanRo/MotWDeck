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

        public List<GearItem> GetGear()
        {
            return Context.Gear.ToList();
        }

        public GearItem GetGearItem(int id)
        {
            return Context.Gear.SingleOrDefault(item => item.ID.Equals(id));
        }

        public void InsertGearItem(string name, string tags)
        {
            GearItem item = new GearItem()
            {
                ID = Context.Gear.Max(gearItem => gearItem.ID) + 1,
                Name = name,
                Tags = tags
            };
            Context.Gear.Add(item);
            Context.SaveChanges();
        }

        public void DeleteGearitem(int id)
        {
            GearItem deletedItem = this.GetGearItem(id);
            Context.Gear.Remove(deletedItem);
            Context.SaveChanges();
        }
    }
}
