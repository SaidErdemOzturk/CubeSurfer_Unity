using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCubeController : MonoBehaviour
{
    private PlayerController player;
    private GameManager gameManager;
    private bool isFinished;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        gameManager= FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ITouchable obj = collision.gameObject.GetComponent<ITouchable>();
        if (obj != null)
        {
            obj.Touch(gameObject);
        }
    }
}
