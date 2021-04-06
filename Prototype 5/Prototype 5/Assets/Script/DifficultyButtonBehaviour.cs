using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonBehaviour : MonoBehaviour
{
    public int difficulty;
    
    private GameManagerBehaviour gameManager;
    private Button button;
    
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManagerBehaviour>();
        
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
        Debug.Log(button.gameObject.name + "was clicked ");
    }
}
