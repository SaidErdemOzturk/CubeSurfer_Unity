using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    [SerializeField] private TMPro.TextMeshProUGUI diamondCountText;

    [SerializeField] private TMPro.TextMeshProUGUI newDiamondText;
    [SerializeField] private Button tapToPlay;
    [SerializeField] private Button restartGame;
    [SerializeField] private Button nextGame;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private SpriteRenderer diamondRenderer;
    [SerializeField] private Transform diamondIconTransform;
    [SerializeField] private GameObject area;
    private bool isTaked;
    private SpriteRenderer image;
    private int diamondCount;
    // Start is called before the first frame update
    void Start()
    {
        diamondCountText.text = PlayerPrefs.GetInt("Diamond",0).ToString();
        newDiamondText.text = "0";
    }

    public void UpdateDiamondCount(int finishCount)
    {
        PlayerPrefs.SetInt("Diamond", PlayerPrefs.GetInt("Diamond")+(diamondCount*finishCount));
        diamondCountText.text = PlayerPrefs.GetInt("Diamond").ToString();

    }

    public void AddDiamond(Transform diamondTransform)
    {
        diamondCount++;
        newDiamondText.text = diamondCount.ToString();
    }

    public void StartGameChange()
    {
        tapToPlay.gameObject.SetActive(!tapToPlay.IsActive());
    }

    public void RestartGameChange()
    {
        restartGame.gameObject.SetActive(true);
    }

    public void NextGameChange()
    {
        nextGame.gameObject.SetActive(true);
    }

    public void AddCube()
    {

    }
}
