namespace LAB1;

public class VipAccount : GameAccount
{
    public override void LoseMatch(string enemyName, string type, decimal rate)
    {
        base.LoseMatch(enemyName, type, rate/2);
    }

    public VipAccount(string username) : base(username)
    {
        AccountType = "VIP";
    }
}