using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bubble Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}