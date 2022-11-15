namespace LAB1;
public class GameAccount
        {
            public string AccountId { get; }
            public decimal GamesCount { get; set; }
            public string UserName { get; }
            protected List<Match> AllMatches = new List<Match>();

            protected string AccountType { get; set; }

            public decimal CurrentRate
            {
                get
                {
                    return AllMatches.Sum(match => match.Rate);
                }
            }

            private const decimal InitialRate = 1000;
            private static decimal _accountIdSeed = 1;
            private const decimal InitialGamesCount = 0;

            public virtual void WinMatch (string enemyName, string type, decimal rate)
            {
                if (rate < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(rate), "Rating can't be negative!");
                }
                
                var match = new Match(UserName, enemyName, type, rate, DateTime.Now);
                AllMatches.Add(match);
            }

            public virtual void LoseMatch(string enemyName, string type, decimal rate)
            {
                if (rate < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(rate), "Rating can't be negative!");
                }

                if (CurrentRate - rate < 0)
                {
                    throw new InvalidOperationException("You need more rating to create this game!");
                }
                
                var match = new Match(UserName, enemyName, type, -rate, DateTime.Now);
                AllMatches.Add(match);
            }

            public void GetGameHistory()
            {
                var report = new System.Text.StringBuilder();

                decimal rating = 0;
                report.AppendLine("--------------------------------------------------------------------------------------------------");
                report.AppendLine($"{UserName} game log:");
                report.Append(
                    $"\n|{"Enemy_name",20}|{"Game_Type",20}|{"Rate_change",20}|{"Current_rating",20}|{"Match_Date",20}|\n");
                foreach (var match in AllMatches)
                {
                    rating += match.Rate;
                    report.Append(
                        $"|{match.EnemyName,20}|{match.Type,20}|{match.Rate,20}|{rating,20}|{match.Date,20}|\n");
                }
                report.AppendLine("-------------------------------------------------------------------------------------------------\n");

                Console.WriteLine(report.ToString());
            }

            public void GetPlayerInfo()
            {
                Console.WriteLine($"\n{UserName} info:");
                Console.WriteLine($"Player ID: {AccountId}");
                Console.WriteLine($"Player Status: {AccountType}");
                Console.WriteLine($"Player Rate: {CurrentRate}");
                Console.WriteLine($"Player games played: {GamesCount}\n");
            }

            public GameAccount(string username)
            {
                UserName = username;
                GamesCount = InitialGamesCount;
                AccountId = _accountIdSeed.ToString();
                AccountType = "default";
                _accountIdSeed++;
                
                WinMatch("init", "init", InitialRate);
            }
            
        }