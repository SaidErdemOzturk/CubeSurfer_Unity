using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastObstacleController : MonoBehaviour,IObstacle
{
    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public void Touch(GameObject obj)
    {
        TouchObstacle(obj);
    }

    public void TouchObstacle(GameObject obj)
    {
        Debug.Log("lastobstacle");
        Destroy(gameObject.GetComponent<LastObstacleController>());
        gameManager.FinishGame(10);
    }
}
