namespace LAB1;

public abstract class Game
{
    protected GameAccount Player1 { get; set; }
    protected GameAccount Player2 { get; set; }

    protected enum GameType
    {
        Training,
        Bot,
        Ranking
    }

    protected decimal Rating { get; set; }

    public abstract void GameImitation();
}