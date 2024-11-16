using UnityEngine;
using UnityEngine.UI;

public class detectCollision : MonoBehaviour
{
 
    public int heartstat = 0;
    public int coinstat = 0;
    public Text statusText;
    public float displayTime = 2f;
    private float timer;
    private bool isShowingText = false;

    private void  Update()
    {
        if(isShowingText)
        {
            timer=Time.deltaTime;
            if(timer <= 0)
            {
                statusText.gameObject.SetActive(false);
                isShowingText = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("heart") == true)
        {
            heartstat++;
            ShowStatusText(heartstat);
        }
        if(collision.gameObject.CompareTag("coin") == true)
        {
            coinstat++;
            ShowStatusText(coinstat);
        }

    }
    private void ShowStatusText(int stat)
    {
        if(statusText != null)
        {
            if(stat %3 == 0)
            {
                statusText.text = "Running Off";
            }
            else if(stat %3 ==1)
            {
                statusText.text = "Running Complete 1";
            }
            else
            {
                statusText.text = "Running Complete 2!";
            }

            statusText.gameObject.SetActive(true);
            isShowingText = true;
            timer = displayTime;
        }
    }

}    
