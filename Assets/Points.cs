using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public static class reward
{
    public static float moveSpeed = 5f;
}
public class Points : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            reward.moveSpeed+=2;
            Debug.Log("Item collected");
        }
    }   
}

