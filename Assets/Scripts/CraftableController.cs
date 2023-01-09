using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CraftableController : MonoBehaviour
{
    //Declare Variables
    public int craftableCount = 0;
    public int score = 0;
    public Text craftableText;
    public float gameTime;
    public Text gameText;
    //Grabs the score text score
    private void Start()
    {
        craftableText.text = craftableCount.ToString();
    }
    void Update()
    {
        //This allows the games timer to tick downwards a second at a time.
        gameTime -= Time.deltaTime;
        if (gameTime < 1)
        {
            gameTime = 0;
            SceneManager.LoadScene("GameOver");
        }
        gameText.text = gameTime.ToString();
    }
    public void IncrementCraftable()
    {
        craftableCount += 1;
        craftableText.text = craftableCount.ToString();
    }
    public void RemoveCraftable()
    {
        if (craftableCount < 3)
        {
            return;
        }
        craftableCount -= 3;
        score += 1;
        craftableText.text = craftableCount.ToString();
    }
    public void IncreaseScoreByTag(string tag)
    {
        switch(tag)
        {
            case "Craftable":
                craftableCount += 1;
                break;
            default:
                craftableCount++;
                break;
        }
        craftableText.text = craftableCount.ToString();
    }

}
