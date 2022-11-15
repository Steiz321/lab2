namespace LAB1;

public class GameList
{
    public static Game GetTrainingGame(GameAccount player1, GameAccount player2)
    {
        return new TrainingGame(player1, player2);
    }

    public static Game GetBotGame(GameAccount player1, decimal rate)
    {
        return new BotGame(player1, rate);
    }

    public static Game GetDiceGame(GameAccount player1, GameAccount player2, decimal rate)
    {
        return new DiceGame(player1, player2, rate);
    }
}