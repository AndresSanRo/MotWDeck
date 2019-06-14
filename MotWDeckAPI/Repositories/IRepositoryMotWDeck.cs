using MotWDeckAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotWDeckAPI.Repositories
{
    public interface IRepositoryMotWDeck
    {
        List<Playbook> GetPlaybooks();
        Playbook GetPlaybook(int id);
        List<Improvement> GetImprovements();
        Improvement GetImprovement(int id);
        List<GearItem> GetGear();
        GearItem GetGearItem(int id);
        void InsertGearItem(String name, String tags);
        void DeleteGearitem(int id);
    }
}
