using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool gameStarted { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Destroyed Instance");
            Destroy(gameObject);
            return;
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Instance = this;
        gameStarted = false;
    }
    

    public void InitGame()
    {
        gameStarted = true;
    }
}
