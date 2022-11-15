namespace LAB1;

public class Match
{
    public decimal Rate { get; }
    public DateTime Date { get; }
    public string Type { get; }
            
    public string UserName { get; }
            
    public string EnemyName { get; }

    public Match( string userName, string enemyName, string type, decimal rate, DateTime date)
    {
        UserName = userName;
        EnemyName = enemyName;
        Type = type;
        Rate = rate;
        Date = date;
    }
}