using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    public class TeamRepository
    {
        List<Team> teams = new List<Team>() {
        new Team(1,"Ferrari"),
        new Team(2,"Mclaren"),
            new Team(3,"Renault"),
            new Team(4,"Rebull")
        };
        public Team getTeam(int teamId)
        {
            var team = teams.Find(team => team.Id == teamId);
            if (team != null)
            {
                return team;
            }

            return new NoTeam();
        }
    }
}
