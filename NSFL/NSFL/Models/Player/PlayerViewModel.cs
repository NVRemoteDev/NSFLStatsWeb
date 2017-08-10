using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NSFL.Models.Player
{
    public class PlayerViewModel
    {
        [DisplayName("Team")]
        public string TeamName { get; set; }

        [DisplayName("First name")]
        public string PlayerFirstName { get; set; }

        [DisplayName("Last name")]
        public string PlayerLastName { get; set; }

        [DisplayName("TPE")]
        public decimal PlayerTPE { get; set; }

        [MaxLength(2)]
        [DisplayName("Position")]
        public string PlayerPosition { get; set; }
    }
}