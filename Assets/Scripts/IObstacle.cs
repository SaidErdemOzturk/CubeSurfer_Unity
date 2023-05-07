using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObstacle : ITouchable
{
    void TouchObstacle(GameObject obj);
}
