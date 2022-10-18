using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameObject youLoseText;
    public PlayerController playerController;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        playerController.speed = 0f;
        
        Destroy(gameObject);
        gameManager.timeRunning = false;
        youLoseText.SetActive(true);
        Time.timeScale = 0f;
    }
}
