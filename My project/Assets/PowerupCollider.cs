using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollider : MonoBehaviour
{
    public PlayerController playerController;
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
        Destroy(gameObject);
        playerController.speed = 12.0f;
    }
}
