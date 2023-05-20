// See https://aka.ms/new-console-template for more information
using football;
using football.Models;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        FootballPlayer player1 = new Striker { Name = "Player 1", Number = 11, Age = 20, Height = 190 };
        FootballPlayer player2 = new Midfielder { Name = "Player 2", Number = 5, Age = 33, Height = 167 };
        FootballPlayer player3 = new Defender { Name = "Player 3", Number = 2, Age = 24, Height = 193 };
        FootballPlayer player4 = new Goalkeeper { Name = "Player 4", Number = 1, Age = 28, Height = 200 };

        Coach coach1 = new Coach { Name = "Coach 1", Age = 56 };
        Coach coach2 = new Coach { Name = "Coach 2", Age = 71 };

        Team team1 = new Team { Coach = coach1, Players = new List<FootballPlayer> { player1, player2 } };
        Team team2 = new Team { Coach = coach2, Players = new List<FootballPlayer> { player3, player4 } };
        
        Referee referee = new Referee { Name = "Referee 1", Age = 35 };
        AssisstantReferee assistantReferee1 = new AssisstantReferee { Name = "AssistantReferee 1", Age = 31 };
        AssisstantReferee assistantReferee2 = new AssisstantReferee { Name = "AssistantReferee 2", Age = 33 };

        Game game = new Game { Team1 = team1, Team2 = team2, Referee = referee, AssisstantReferee = assistantReferee1, Goals = new List<string>(), Result = "0:0", Winner = null };
       
        Console.WriteLine("Game Result:");

        Console.WriteLine("Team 1: " + game.Team1.Name);
        Console.WriteLine("Team 2: " + game.Team2.Name);
        Console.WriteLine("Result: " + game.Result);
        if (game.Winner != null)
        {
            Console.WriteLine("Winner: " + (game.Winner.Name));
        }
        else
        {
            Console.WriteLine("There is no winner. The result is Draw");
        }
    }

}