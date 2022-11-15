namespace LAB1;

public class PlatinumAccount : VipAccount
{
    private decimal WinStreak { get; set; }

    public override void WinMatch(string enemyName, string type, decimal rate)
    {
        base.WinMatch(enemyName, type,rate + WinStreak * 10);
        WinStreak++;
    }

    public override void LoseMatch(string enemyName, string type, decimal rate)
    {
        base.LoseMatch(enemyName, type, rate);
        WinStreak = 0;
    }

    public PlatinumAccount(string username) : base(username)
    {
        AccountType = "PLATINUM";
        WinStreak = 0;
    }
}