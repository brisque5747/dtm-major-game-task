using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timevalue = 15;
    public GameObject YouWinText;
    public bool timeRunning;
    // Start is called before the first frame update
    void Start()
    {
        timeRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }
    /// <summary>
    /// Generates a variable which then counts up. If player survives for more than 15 seconds, triggers YouWin function.
    /// </summary>
    void Timer()
    {
        timevalue -= Time.deltaTime;
        if (timeRunning)
        {
            if (timevalue <= 0)
            {
                YouWin();
            }
        }
        
    }
    /// <summary>
    /// Triggers a message within the debug log stating that player won. Still WIP
    /// </summary>
    void YouWin()
    {
        Debug.Log("You win!");
        YouWinText.SetActive(true);
    }
}
