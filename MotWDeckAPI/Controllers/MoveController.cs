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
    public class MoveController : ControllerBase
    {
        IRepositoryMotWDeck Repo;
        public MoveController(IRepositoryMotWDeck Repo)
        {
            this.Repo = Repo;
        }
        [HttpGet]
        public List<Move> Get()
        {
            return Repo.GetMoves();
        }
        [HttpGet]
        [Route("{id}")]
        public Move Get(int id)
        {
            return Repo.GetMove(id);
        }
        [HttpGet]
        [Route("GetMovesByPlaybook/{playbook}")]
        public List<Move> GetMovesByPlaybook(String playbook)
        {
            return Repo.GetMovesByPlaybook(int.Parse(playbook));
        }
    }
}