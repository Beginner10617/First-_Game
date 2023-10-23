using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Death_Trap : MonoBehaviour
{
    private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        if(collision.gameObject.CompareTag("Player"))// && reward.is_activated() == false)
        {
            Destroy(collision.gameObject);
            Restart();
            
        }
    }

    public void Restart()
    {
        reward.moveSpeed = 5f;
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
