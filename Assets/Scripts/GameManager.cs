using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameEvent onGameOver;
    [SerializeField] private GameEvent onLevelComplete;

    public void FailGame()
    {
        onGameOver?.Raise();
    }

    public void CompleteLevel()
    {
        onLevelComplete?.Raise();
    }
}
