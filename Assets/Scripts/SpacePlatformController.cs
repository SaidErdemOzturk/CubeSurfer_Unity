using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePlatformController : MonoBehaviour,IObstacle
{
    [SerializeField] private StackController stackController;
    public void Touch(GameObject obj)
    {
        TouchObstacle(obj);
    }
    public void TouchObstacle(GameObject obj)
    {
        obj.GetComponent<MeshCollider>().enabled = false;
        obj.GetComponent<BoxCollider>().enabled = false;
        stackController.ObstacleDestroyCube(obj);
    }
}
