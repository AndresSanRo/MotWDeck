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
    public class ImprovementController : ControllerBase
    {
        IRepositoryMotWDeck Repo;
        public ImprovementController(IRepositoryMotWDeck Repo)
        {
            this.Repo = Repo;
        }
        [HttpGet]
        public List<Improvement> Get()
        {
            return Repo.GetImprovements();
        }
        [HttpGet]
        [Route("{id}")]
        public Improvement Get(String id)
        {
            return Repo.GetImprovement(int.Parse(id));
        }
    }
}