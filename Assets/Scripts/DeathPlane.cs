using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

void OnTriggerEnter2D (Collider2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}


}
