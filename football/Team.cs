using football.Models;

namespace football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public string Name { get; internal set; }

        public double AveragePlayerAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Count;
        }
        public string PlayerCountPerTeam()
        {
            string result = "";
            if (Players.Count <= 22 && Players.Count >= 11)
            {
                result = "The match can start";
            }
            else
            {
                result = "The players are not the required count. The match cannot start";
            }
            return result;
        }

    }
}
