using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NSFL.Models.Team
{
    public class TeamViewModel
    {
        [Key]
        [DisplayName("Team ID")]
        public int TeamId { get; set; }

        [MaxLength(50)]
        [DisplayName("Team name")]
        public string TeamName { get; set; }

        [DisplayName("Players")]
        public List<Player.PlayerViewModel> Players { get; set; }
    }
}