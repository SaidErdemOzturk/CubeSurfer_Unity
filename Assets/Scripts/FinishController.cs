using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : MonoBehaviour,IObstacle
{

    [SerializeField] private GameObject cubes;
    private int finishCount = 0;
    private CubeController cube;
    private StackController stack;
    private bool isActive = true;
    public void Touch(GameObject obj)
    {
        TouchObstacle(obj);
    }

    public void TouchObstacle(GameObject obj)
    {
        Destroy(GetComponent<FinishController>());
        finishCount++;
        stack.FinishCube(obj);
    }

    // Start is called before the first frame update
    void Start()
    {
        stack = FindObjectOfType<StackController>();
    }


}
