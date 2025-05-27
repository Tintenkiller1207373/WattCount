using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattCount.Models
{
    class Teams
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }
        public int Bummerlen { get; set; }

        public Teams() : this(0, "", 0) { }
        public Teams(int teamId, string teamName, int bummerlen) {
            TeamId = teamId;
            TeamName = teamName;
            Bummerlen = bummerlen;
        }

        public override string ToString() {
            return TeamName + " " + Bummerlen;
        }
    }

    
}
