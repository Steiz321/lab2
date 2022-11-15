namespace LAB1;

public class BotGame : Game
{
     private readonly string _type = GameType.Bot.ToString();
     public override void GameImitation()
     {
          var rnd = new Random();
          decimal number1 = rnd.Next(1, 7);
          decimal number2 = rnd.Next(1, 7);
          Player1.GamesCount++;

          Console.WriteLine("Bot match:");
          if (number1 > number2)
          {
               Player1.WinMatch("Bot", _type, Rating);
               Console.WriteLine($"{Player1.UserName} get {number1}");
               Console.WriteLine($"Bot get {number2}");
               Console.WriteLine($"{Player1.UserName} wins Bot!\n");
          }
          else if (number2 > number1) 
          {
               Player1.LoseMatch("Bot", _type, Rating);
               Console.WriteLine($"{Player1.UserName} get {number1}");
               Console.WriteLine($"Bot get {number2}");
               Console.WriteLine($"Bot wins {Player1.UserName}!\n");
          }
          else
          {
               Player1.WinMatch("Bot", _type,0);
               Console.WriteLine($"{Player1.UserName} get {number1}");
               Console.WriteLine($"Bot get {number2}");
               Console.WriteLine($"{Player1.UserName} and Bot have draw!\n");
          }
     }
     
     public BotGame(GameAccount player1, decimal rate)
     {
          Player1 = player1;
          Rating = rate;
     }
}