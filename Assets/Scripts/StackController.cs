using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private CanvasManager canvasManager;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject cubesObject;
    public List<GameObject> cubes = new List<GameObject>();
    private GameObject lastCube;
    private int finishCount = 0;
    private GameObject lastObstacle;
    private GameObject tempObj;
    private int sayac = 0;

    // Start is called before the first frame update
    void Start()
    {
        cubes.Add(cubesObject.transform.GetChild(0).gameObject);
        UpdateLastCube();
    }

    public void DestroyCube(GameObject cube)
    {
        Destroy(cube.GetComponent<StackCubeController>());
        cube.transform.SetParent(null);
        cubes.Remove(cube);
        UpdateLastCube();
    }
           
    public void AddCube(GameObject cube)
    {
        if(cube.transform.parent == null)
        {
            player.transform.position = player.transform.position + new Vector3(0, 1, 0);
            cube.transform.SetParent(cubesObject.transform);
            cube.transform.position = lastCube.transform.position - new Vector3(0, 1, 0);
            cubes.Add(cube);
            Destroy(cube.GetComponent<CubeController>());
            cube.AddComponent<StackCubeController>();
            UpdateLastCube();
        }
    }

    public void FinishCube(GameObject cube)
    {
        finishCount++;
        if (cubes.Count != 1)
        {
            DestroyCube(cube);
        }
        else
        {
            gameManager.FinishGame(finishCount);
        }
    }

    public void ObstacleDestroyCube(GameObject cube)
    {
        Destroy(cube.GetComponent<StackCubeController>());
        Destroy(cube);
        cubes.Remove(cube);
        UpdateLastCube();
    }

    public void DecreaseCube(GameObject cube,GameObject obstacle)
    {
        if (tempObj != cube)
        {
            if (cubes.Count != 1)
            {
                DestroyCube(cube);
            }
            else
            {
                gameManager.LoseGame();
            }
        }
        tempObj = cube.GetComponent<StackCubeController>().gameObject;
    }

    private void UpdateLastCube()
    {
        lastCube = cubes[cubes.Count - 1];
    }
}
