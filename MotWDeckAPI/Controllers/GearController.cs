using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotWDeckAPI.Models;
using MotWDeckAPI.Repositories;

namespace MotWDeckAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearController : ControllerBase
    {
        IRepositoryMotWDeck Repo;
        public GearController(IRepositoryMotWDeck Repo)
        {
            this.Repo = Repo;
        }
        [HttpGet]
        public List<GearItem> Get()
        {
            return Repo.GetGear();
        }
        [HttpGet]
        [Route("{id}")]
        public GearItem Get(String id)
        {
            return Repo.GetGearItem(int.Parse(id));
        }
        [HttpPut]
        public void Put([FromBody] GearItem newItem)
        {
            Repo.InsertGearItem(newItem.Name, newItem.Tags);
        }
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Repo.DeleteGearitem(id);
        }
    }
}