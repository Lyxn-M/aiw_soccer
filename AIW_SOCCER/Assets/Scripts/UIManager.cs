using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public const string FieldScene = "Field";
    public const string SmallRoom = "Small Room";
    public const string MainScene = "Main Scene";
    public const string GameModes = "GameModes";
    public void StartGame()
    {
        SceneManager.LoadScene(FieldScene);
    }

    public void StartTrainingGame(){
        SceneManager.LoadScene(SmallRoom);            
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(MainScene);
    }
    public void GoGameModes()
    {
        SceneManager.LoadScene(GameModes);
    }
     public void SelectSkin(int skinIndex)
    {
        PlayerPrefs.SetInt("SelectedSkin", skinIndex);
        PlayerPrefs.Save();
        Debug.Log("Skin " + skinIndex + " selected.");
    }
}