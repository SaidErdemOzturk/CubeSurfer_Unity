using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSpawner : MonoBehaviour
{
    private int levelCount;
    public void LevelSpawn()
    {
        levelCount = PlayerPrefs.GetInt("Level");
        Debug.Log(levelCount);
        Debug.Log(levelCount%4);
        SceneManager.LoadScene((levelCount % 4));
    }
}
