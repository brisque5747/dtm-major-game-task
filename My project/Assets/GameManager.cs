using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timevalue = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timevalue -= Time.deltaTime;
        if(timevalue <= 0 )
        {
            Debug.Log("You win!");
        }
    }
}
