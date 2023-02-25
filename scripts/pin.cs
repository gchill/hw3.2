using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed = Data.PSpeed;
    public Rigidbody2D rb;

    void Update()
    {
        rb.MovePosition(rb.position + Vector2.up * Data.PSpeed * Time.deltaTime);
    }
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.tag == "rotator")
        {
            transform.SetParent(col.transform);
            score.PinCount++;
            isPinned = true;
            
        }
        else if(col.tag == "pin")
        {
            FindObjectOfType<gameManager>().EndGame();
             if(score.PinCount > score.TempScore)
        {
            score.TempScore = score.PinCount;
        }
        }
    }
}
