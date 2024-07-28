using FootballLeague.Data;
using FootballLeague.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using (var context = new FootballLeagueContext())
{
    context.Database.EnsureCreated();
    context.teamStandings.Add(new TeamStanding
    {
        TeamName = "Real Madrid",
        TeamCity = "Barcelona",
        VinsCount = 20,
        LoosCount = 10,
        DravsCount = 5
    });
    context.teamStandings.Add(new TeamStanding
    {
        TeamName = "Dynamo Kiev",
        TeamCity = "Kiev",
        VinsCount = 20,
        LoosCount = 10,
        DravsCount = 5
    });
    context.SaveChanges();
    foreach (var team in context.teamStandings)
    {
        Console.WriteLine(team.TeamName, team.TeamCity, team.VinsCount, team.LoosCount, team.DravsCount);
    }
}