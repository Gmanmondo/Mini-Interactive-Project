using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePop : MonoBehaviour
{   
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject) // Check if clicked on this bubble
            {
                Destroy(gameObject); // Destroy the bubble
            }
        }
    }
}
