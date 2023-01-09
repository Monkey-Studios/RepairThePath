using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Craftables : MonoBehaviour
{
    AudioSource pickup;
    //Declaring variables
    public GameObject HUD;
    //Setting collision of craftables with player
    private void Start()
    {
        pickup = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider collidedObject)
    {
        if(collidedObject.tag == "Player")
        {
            HUD.GetComponent<CraftableController>().IncreaseScoreByTag(this.tag);
            pickup.Play();
            this.GetComponent<Collider>().enabled = false;
            this.GetComponent<Renderer>().enabled = false;
            Destroy(this.gameObject, 0.5f);
        }
    }
}
