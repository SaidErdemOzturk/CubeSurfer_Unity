using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetController : MonoBehaviour,ITakeble
{
    [SerializeField] private PlayerController player;
    private float currentTime;
    private bool isTakeMagnet;
    void Update()
    {
        if (isTakeMagnet)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0.0F)
            {
                currentTime = 0;
                isTakeMagnet = false;
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        ITakeble take = other.GetComponent<ITakeble>();
        if (take != null)
        {
            take.Take(other.gameObject);
        }
    }
    public void Touch(GameObject obj)
    {
        Take(obj);
    }
    public void Take(GameObject obj)
    {
        transform.SetParent(player.transform);
        currentTime = 2F;
        isTakeMagnet = true;
        transform.GetComponent<MeshRenderer>().enabled = false;
    }
}
