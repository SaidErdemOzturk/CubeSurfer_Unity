using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CanvasManager canvasManager;
    [SerializeField] private PlayerController player;
    private LevelSpawner levelSpawner;
    private void Start()
    {
        levelSpawner = FindObjectOfType<LevelSpawner>();
    }

    public void LoseGame()
    {
        canvasManager.RestartGameChange();
        player.playerSpeed = 0;
    }

    public void StartGame()
    {
        canvasManager.StartGameChange();
        player.GetComponent<Rigidbody>().isKinematic = false;
        player.isStartGame = true;
    }

    public void FinishGame(int finishCount)
    {
        canvasManager.NextGameChange();
        canvasManager.UpdateDiamondCount(finishCount);
        PlayerPrefs.SetInt("Level",PlayerPrefs.GetInt("Level")+1);
        player.playerSpeed = 0;
    }
    public void RestartGame()
    {
        levelSpawner.LevelSpawn();
    }
}
