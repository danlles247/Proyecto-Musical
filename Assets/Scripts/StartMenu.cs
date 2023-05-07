using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HeneGames.Airplane;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class StartMenu : MonoBehaviour
{

    public void StartGame()
    {
        gameObject.SetActive(false);
        GameManager.Instance.InitGame();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
