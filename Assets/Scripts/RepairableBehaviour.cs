using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairableBehaviour : MonoBehaviour
{
    //Declare variables
    public Material colour;
    AudioSource repair;
    //
    void ColourChange()
    {
        GetComponent<Renderer>().material = colour;
        repair = GetComponent<AudioSource>();
        repair.Play();
    }
}
