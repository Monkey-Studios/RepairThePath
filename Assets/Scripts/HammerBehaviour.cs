using UnityEngine;
using UnityEngine.SceneManagement;
public class HammerBehaviour : MonoBehaviour
{
    //Declaring variables
    public float range = 100f;
    const float rateofFire = 0.0f;
    float fireDelay;
    public Camera playerCam;
    public GameObject canvas;
    public CraftableController cc;
    //Getting player input to fire a raycast aswell as applying a shot deplay every shot
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > fireDelay)
        {
            Repair();
            fireDelay = Time.time + rateofFire;
        }

    }
    //This script is what tells the hammer to do when it sends a message via a raycast
    void Repair()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Debug.DrawLine(playerCam.transform.position, hit.point, Color.white);
        }
        if (hit.collider.tag == "Repairable")
        {
            if (cc.craftableCount < 3)
            {
                return;
            }
            hit.collider.SendMessage("ColourChange", SendMessageOptions.DontRequireReceiver);
            canvas.SendMessage("RemoveCraftable", SendMessageOptions.DontRequireReceiver);
        }
        else if(hit.collider.tag == "Button")
        {
         if (cc.score >= 4)
            {
                SceneManager.LoadScene("Victory");
            }
        }
    }

}
