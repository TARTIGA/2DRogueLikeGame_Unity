using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public BoardManager boardScript;

    public int playerFoodPoint = 100;

    [HideInInspector] public bool playersTurn = true;

    private int level = 3;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);


        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    public void GameOver()
    {
        enabled = false;
    }

    void InitGame()
    {
        boardScript.SetupScene(level);
    }
}
