using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TotalGoalsLoader : MonoBehaviour
{
   public TMP_Text kaiText;

    void Start()
    {
        GoalSaver.LoadScores();

        kaiText.text = " " + GoalSaver.KaiGoals;
    }
}
