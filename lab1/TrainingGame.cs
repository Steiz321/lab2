namespace LAB1;

public class TrainingGame : Game
{

    private readonly string _type = GameType.Training.ToString();
    public override void GameImitation()
    { 
        var rnd = new Random();
        decimal number1 = rnd.Next(1, 7);
        decimal number2 = rnd.Next(1, 7);
        Player1.GamesCount++;
        Player2.GamesCount++;

        Console.WriteLine("Training match:");
        if (number1 > number2)
        {
            Player1.WinMatch(Player2.UserName, _type, 0);
            Player2.LoseMatch(Player1.UserName, _type, 0);
            Console.WriteLine($"{Player1.UserName} get {number1}");
            Console.WriteLine($"{Player2.UserName} get {number2}");
            Console.WriteLine($"{Player1.UserName} wins {Player2.UserName}!\n");
        }
        else if (number2 > number1) 
        {
            Player2.WinMatch(Player1.UserName, _type, 0);
            Player1.LoseMatch(Player2.UserName, _type, 0);
            Console.WriteLine($"{Player1.UserName} get {number1}");
            Console.WriteLine($"{Player2.UserName} get {number2}");
            Console.WriteLine($"{Player2.UserName} wins {Player1.UserName}!\n");
        }
        else
        {
            Player1.WinMatch(Player2.UserName, _type, 0);
            Player2.WinMatch(Player1.UserName, _type, 0);
            Console.WriteLine($"{Player1.UserName} get {number1}");
            Console.WriteLine($"{Player2.UserName} get {number2}");
            Console.WriteLine($"{Player1.UserName} and {Player2.UserName} have draw!\n");
        }
    }

    public TrainingGame(GameAccount player1, GameAccount player2)
    {
        Player1 = player1;
        Player2 = player2;
    }
}