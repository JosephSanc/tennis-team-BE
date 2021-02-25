using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace NotSoCrud.Controllers
{
    
    public class PlayerController : ControllerBase
    {
        public PlayerController() { }

        private List<Player> databaseListOfPlayers = new List<Player>();

        [HttpGet]
        [Route("players")]
        public List<Player> GetPlayers()
        {
            var context = new TeamContext();

            databaseListOfPlayers = context.Players.ToList();

            return databaseListOfPlayers;
        }

        [HttpGet]
        [Route("players/{playerId}")]
        public Player GetPlayer(int playerId)
        {
            var context = new TeamContext();

            Player routedPlayer = context.Players.Where(s => s.PlayerId == playerId).FirstOrDefault();
            return routedPlayer;
        }

        [HttpDelete]
        [Route("players/delete/{playerId}")]
        public void DeletePlayer(int playerId)
        {
            var context = new TeamContext();

            var routedPlayer = context.Players.SingleOrDefault(a => a.PlayerId == playerId);

            context.Remove(routedPlayer);
            context.SaveChanges();



        }

        [HttpPut]
        [Route("/players/update/{playerId}")]
        public void UpdatePlayer(int playerId, [FromBodyAttribute] Player player)
        {
            var context = new TeamContext();
            
            context.Update(player);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("/players/add-player")]
        public void AddPlayer([FromBodyAttribute] Player player)
        {
            var context = new TeamContext();

            context.Players.Add(player);
            context.SaveChanges();
        }

    }
}
