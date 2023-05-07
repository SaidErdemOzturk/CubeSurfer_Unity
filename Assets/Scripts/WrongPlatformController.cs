using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongPlatformController : MonoBehaviour
{
    private GameManager gameManager;
    private StackController stackController;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        stackController = FindObjectOfType<StackController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.parent.childCount != 1)
        {
            stackController.ObstacleDestroyCube(collision.gameObject);
        }
        else
        {
            gameManager.LoseGame();
        }
    }
}
