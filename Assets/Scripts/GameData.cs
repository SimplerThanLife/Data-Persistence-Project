using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
public static string PlayerName {get; set; }

public static int HighScore
{
    get => PlayerPrefs.GetInt("HighScore", 0);
    set
    {
        PlayerPrefs.SetInt("HighScore", value);
        PlayerPrefs.Save();
    }
}

public static string HighScorePlayerName
{
    get => PlayerPrefs.GetString("HighScorePlayerName", "");
    set
    {
        PlayerPrefs.SetString("HighScorePlayerName", value);
        PlayerPrefs.Save();
    }
}
}
