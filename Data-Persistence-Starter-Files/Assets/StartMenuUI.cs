using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartMenuUI : MonoBehaviour
{
    
    public void StartButton()
    {
        SaveSystem.Instance.SetUsername();
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        SaveSystem.Instance.SaveHighScore();
    }
}
