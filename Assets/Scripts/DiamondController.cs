using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondController : MonoBehaviour,ITakeble
{
    private CanvasManager canvasController;
    [SerializeField] private Transform icon;
    [SerializeField] private SpriteRenderer diamondRenderer;
    private SpriteRenderer image;
    private bool isTaked;

    public void Take(GameObject obj)
    {
        image = Instantiate(diamondRenderer);
        image.transform.position = obj.transform.position;
        isTaked = true;
        canvasController.AddDiamond(transform);
        Destroy(image,2F);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<MeshCollider>().isTrigger = true;
        Destroy(gameObject,2F);
    }

    public void Touch(GameObject obj)
    {
        Take(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        canvasController = FindObjectOfType<CanvasManager>();
    }

    private void Update()
    {
        if (isTaked)
        {
            image.transform.position = Vector3.Lerp(image.transform.position,icon.position, 1F * Time.deltaTime);
        }
    }

}
