using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioClip pickup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            AudioSource.PlayClipAtPoint(pickup, this.gameObject.transform.position);
            ScoreManager.instance.AddPoint();
            Destroy(gameObject);
        }
    }
}
