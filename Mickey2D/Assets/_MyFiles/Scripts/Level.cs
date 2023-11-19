using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime = 60f;
    [SerializeField] Animator transitionAnim;
    
    public Transform startPosition;
    
    public Transform teleportLocation;
   
    private void Awake()
    {
        

    }
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            GameObject.FindGameObjectWithTag("Player").transform.position = startPosition.position;
            remainingTime = 60;
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(AnimationTransit(collision));
        }
    }

    IEnumerator AnimationTransit(Collider2D player)
    {

        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        if (teleportLocation != null)
        {
            player.transform.position = teleportLocation.position;
        }
        remainingTime = 60;

        
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        

    }
}
