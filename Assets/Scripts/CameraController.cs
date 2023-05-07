using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private GameObject cubes;
    private float cubeY;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - cubes.transform.GetChild(0).gameObject.transform.position;
        cubeY = cubes.transform.GetChild(0).gameObject.transform.position.y;
    }


    // Update is called once per frame

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, offset + cubes.transform.GetChild(cubes.transform.childCount - 1).position, 0.1F);
    }
}
