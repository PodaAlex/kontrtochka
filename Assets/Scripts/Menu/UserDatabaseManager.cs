using UnityEngine;

public static class UserDatabaseManager
{
    private const string BestScoreKey = "BestScoreKey";
    private const string WinnerNameKey = "WinnerNameKey";
    
    public static int GetBestScore()
    {
        return PlayerPrefs.GetInt(BestScoreKey,0);
    }

    public static void SetBestScore(int value)
    {
        PlayerPrefs.SetInt(BestScoreKey,value);
    }

    public static string GetWinnerName()
    {
        return PlayerPrefs.GetString(WinnerNameKey, string.Empty);
    }

    public static void SetWinnerName(string value)
    {
        PlayerPrefs.SetString( WinnerNameKey,value);
    }
}