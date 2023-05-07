using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour,ITakeble
{
    private PlayerController player;
    private StackController stackController;
    private void Start()
    {
        stackController=FindObjectOfType<StackController>();
    }

    public void Take(GameObject obj)
    {
        gameObject.tag = "PlayerCube";
        stackController.AddCube(gameObject);
    }

    public void Touch(GameObject obj)
    {
        Take(gameObject);
    }
}
