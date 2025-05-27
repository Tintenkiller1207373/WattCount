using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattCount.Models
{
    public class Teams
    {
        public int TeamsId { get; set; }

        public string TeamName { get; set; }
        public int Bummerlen { get; set; }

        public Teams() : this(0, "", 0) { }
        public Teams(int teamsId, string teamName, int bummerlen) {
            TeamsId = teamsId;
            TeamName = teamName;
            Bummerlen = bummerlen;
        }

        public override string ToString() {
            return TeamName + " " + Bummerlen;
        }
    }

    
}
