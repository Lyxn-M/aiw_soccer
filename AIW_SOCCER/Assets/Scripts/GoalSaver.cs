using UnityEngine;

public class GoalSaver : MonoBehaviour
{
   public static int KaiGoals = 0;

    public static void SaveScores()
    {
        PlayerPrefs.SetInt("KaiGoals", KaiGoals);
        PlayerPrefs.Save();
    }

    public static void LoadScores()
    {
        KaiGoals = PlayerPrefs.GetInt("KaiGoals", 0);
    }
}
