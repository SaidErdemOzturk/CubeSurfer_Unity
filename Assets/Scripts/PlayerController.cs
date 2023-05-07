using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float playerSpeed;
    [SerializeField] private float playerControllerSpeed;
    [HideInInspector] public bool isStartGame;
    [SerializeField] private GameObject cubes;
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Transform diamondIcon;
    private float horizontal;
    private bool horizontalControl;
    private float positionX;

    private void FixedUpdate()
    {

        trailRenderer.AddPosition(new Vector3(transform.position.x, cubes.transform.GetChild(cubes.transform.childCount - 1).position.y - 0.4F, transform.position.z));
        SetForwardMovementPlayer();
        SetHorizontalMovmentPlayer(horizontalControl);

    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            horizontalControl = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            horizontalControl = false;
        }
    }

    private void SetForwardMovementPlayer()
    {
        diamondIcon.Translate(Vector3.forward * playerSpeed * Time.fixedDeltaTime);
        transform.Translate(Vector3.forward * playerSpeed*Time.fixedDeltaTime);
    }

    private void SetHorizontalMovmentPlayer(bool control)
    {
        if (control)
        {
            horizontal = Input.GetAxis("Mouse X");
            positionX = transform.position.x + horizontal * playerControllerSpeed * Time.fixedDeltaTime;
            positionX = Mathf.Clamp(positionX, -2, 2);
            transform.position = new Vector3(positionX, transform.position.y, transform.position.z);
        }
        else
        {
            horizontal = 0;
        }
    }
}
