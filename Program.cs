using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Requirements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            int choice;

            do
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3. Get Player By Id 4. Get Player by Name 5. Get All Players:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Player Id: ");
                        int playerId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Player Name: ");
                        string playerName = Console.ReadLine();

                        Console.Write("Enter Player Age: ");
                        int playerAge = Convert.ToInt32(Console.ReadLine());

                        Player newPlayer = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
                        team.Add(newPlayer);
                        break;

                    case 2:
                        Console.Write("Enter Player Id to Remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        team.Remove(removeId);
                        break;

                    case 3:
                        Console.Write("Enter Player Id to Get: ");
                        int getPlayerId = Convert.ToInt32(Console.ReadLine());
                        Player getPlayer = team.GetPlayerById(getPlayerId);
                        if (getPlayer != null)
                        {
                            Console.WriteLine($"Player ID: {getPlayer.PlayerId}, Name: {getPlayer.PlayerName}, Age: {getPlayer.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Player Name to Get: ");
                        string getPlayerName = Console.ReadLine();
                        Player getPlayerByName = team.GetPlayerByName(getPlayerName);
                        if (getPlayerByName != null)
                        {
                            Console.WriteLine($"Player ID: {getPlayerByName.PlayerId}, Name: {getPlayerByName.PlayerName}, Age: {getPlayerByName.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;

                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        if (allPlayers.Count > 0)
                        {
                            Console.WriteLine("All Players:");
                            foreach (var player in allPlayers)
                            {
                                Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No players in the team.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Exiting.");
                        break;
                }

                Console.Write("Do you want to continue (yes/no)? ");
                string continueChoice = Console.ReadLine();

                if (continueChoice.ToLower() != "yes")
                {
                    break;
                }
            } while (true);
        }
    }
}
