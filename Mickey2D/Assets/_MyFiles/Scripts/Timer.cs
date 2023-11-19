using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime = 60f;
    [SerializeField] Animator transitionAnim;

    public Transform teleportLocation;
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
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            PlayerManager.isGameOver = true;
            Time.timeScale = 0f;
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
    }



}
