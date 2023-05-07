using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObstacleController : MonoBehaviour, IObstacle
{
    [SerializeField] private GameObject cubes;
    private StackController stack;
    public void Touch(GameObject obj)
    {
        TouchObstacle(obj);
    }

    public void TouchObstacle(GameObject obj)
    {
        Destroy(GetComponent<ObstacleController>());
        stack.DecreaseCube(obj,gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        stack = FindObjectOfType<StackController>();
    }
}
