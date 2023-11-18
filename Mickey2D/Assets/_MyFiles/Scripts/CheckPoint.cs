using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public AudioSource checkpoint;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.transform.tag == "Player")
        {
            checkpoint.Play();
            PlayerManager.lastCheckPointPos = transform.position;
            GetComponent<SpriteRenderer>().color = Color.white;
            
        }

        if (collision.transform.tag == "Player")
        {
            
            CircleCollider2D circleCollider = GetComponent<CircleCollider2D>();
            circleCollider.enabled = false;
        }

    }
}
