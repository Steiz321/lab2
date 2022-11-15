
namespace LAB1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new GameAccount("player1");
            var player2 = new GameAccount("player2");
            var player3 = new VipAccount("player3");
            var player4 = new PlatinumAccount("player4");

            var gameList = new GameList();

            player1.GetPlayerInfo();
            player2.GetPlayerInfo();
            player3.GetPlayerInfo();
            player4.GetPlayerInfo();

            var game1 = GameList.GetBotGame(player1, 200);
            var game2 = GameList.GetTrainingGame(player2, player4);
            var game3 = GameList.GetDiceGame(player4, player1, 200);
            var game4 = GameList.GetDiceGame(player3, player4, 100);
            var game5 = GameList.GetBotGame(player2, 100);
            var game6 = GameList.GetDiceGame(player3, player1, 100);

            game1.GameImitation();
            game2.GameImitation();
            game3.GameImitation();
            game4.GameImitation();
            game5.GameImitation();
            game6.GameImitation();

            player1.GetGameHistory();
            player2.GetGameHistory();
            player3.GetGameHistory();
            player4.GetGameHistory();
            
            player1.GetPlayerInfo();
            player2.GetPlayerInfo();
            player3.GetPlayerInfo();
            player4.GetPlayerInfo();
        }
    }
}