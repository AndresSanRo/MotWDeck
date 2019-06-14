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
        /// <summary>
        /// Get all the playbooks.
        /// </summary>
        /// <returns>List<Playbook>.</returns>
        public List<Playbook> GetPlaybooks()
        {
            return Context.Playbooks.ToList();
        }
        /// <summary>
        /// Get a playbook by his id.
        /// </summary>
        /// <param name="id">int.</param>
        /// <returns>Playbook.</returns>
        public Playbook GetPlaybook(int id)
        {
            return Context.Playbooks.SingleOrDefault(playbook => playbook.ID.Equals(id));
        }
        /// <summary>
        /// Get all the improvements.
        /// </summary>
        /// <returns>List<Improvement>.</returns>
        public List<Improvement> GetImprovements()
        {
            return Context.Improvements.ToList();
        }
        /// <summary>
        /// Get an improvement by his id.
        /// </summary>
        /// <param name="id">int.</param>
        /// <returns>Improvement.</returns>
        public Improvement GetImprovement(int id)
        {
            return Context.Improvements.SingleOrDefault(improvement => improvement.ID.Equals(id));
        }
        /// <summary>
        /// Get al the gear items.
        /// </summary>
        /// <returns>List<GearItem>.</returns>
        public List<GearItem> GetGear()
        {
            return Context.Gear.ToList();
        }
        /// <summary>
        /// Get a gear item by his id.
        /// </summary>
        /// <param name="id">int.</param>
        /// <returns>GearItem.</returns>
        public GearItem GetGearItem(int id)
        {
            return Context.Gear.SingleOrDefault(item => item.ID.Equals(id));
        }
        /// <summary>
        /// Inserts a new gear item.
        /// It auto-calculates the id.
        /// </summary>
        /// <param name="name">String.</param>
        /// <param name="tags">String.</param>
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
        /// <summary>
        /// Delete a gear item by his id.
        /// </summary>
        /// <param name="id">int.</param>
        public void DeleteGearitem(int id)
        {
            GearItem deletedItem = this.GetGearItem(id);
            Context.Gear.Remove(deletedItem);
            Context.SaveChanges();
        }
        /// <summary>
        /// Get all the moves.
        /// </summary>
        /// <returns>List<Move>.</returns>
        public List<Move> GetMoves()
        {
            return Context.Moves.ToList();
        }
        /// <summary>
        /// Get a move by his id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Move GetMove(int id)
        {
            return Context.Moves.SingleOrDefault(move => move.ID.Equals(id));
        }
        /// <summary>
        /// Get a list of moves by his playbook id.
        /// </summary>
        /// <param name="playbookId">int.</param>
        /// <returns>List<Move>.</returns>
        public List<Move> GetMovesByPlaybook(int playbookId)
        {
            return Context.Moves.Where(move => move.PlaybookId.Equals(playbookId)).ToList();
        }
    }
}
