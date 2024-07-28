using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    internal class TeamStanding
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string TeamCity { get; set; }
        public int VinsCount { get; set; }
        public int LoosCount { get; set; }
        public int DravsCount { get; set; }
    }
}
