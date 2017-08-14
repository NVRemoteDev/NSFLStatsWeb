using NSFL.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NSFL.Helpers
{
    public static class PlayerHelper
    {
        public static Player GetPlayerFromPlayerLine(PlayerFileLine playerFileLine)
        {
            try
            {
                if (playerFileLine.PlayerLine.Split('-').Length < 2 || playerFileLine.PlayerLine.Split(',').Length < 2)
                {
                    return new Player(); // Probably an inconsistenly formatted roster title
                }

                var player = new Player();
                player.PlayerSeasonDrafted = playerFileLine.PlayerLine.Split(')')[0].Replace("(", "").Trim();
                player.PlayerFirstName = playerFileLine.PlayerLine.Split('-')[1].Trim().Split(' ')[0].Trim();
                player.PlayerLastName = playerFileLine.PlayerLine.Split('-')[1].Trim().Split(' ')[1].Trim();
                player.PlayerTPE = int.Parse(playerFileLine.PlayerLine.Split(',')[1].Split(':').Last().Trim());
                player.PlayerPosition = playerFileLine.PlayerLine.Split('-').Last().Split(',')[0].Trim();
                player.PlayerProfileURL = playerFileLine.PlayerLine.Split(',')[2].Trim();

                return player;
            }
            catch
            {
                return new Player();
            }
        }
    }
}