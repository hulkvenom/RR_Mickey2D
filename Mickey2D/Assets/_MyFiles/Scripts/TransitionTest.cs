using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTest : MonoBehaviour
{
    //public static TransitionTest instance;
    //[SerializeField] Animator transitionAnim;

    

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        DontDestroyOnLoad(gameObject);
    //        instance = this;
    //    }
    //    else if (instance != this)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    ////public void NextLevel()
    ////{
    ////    StartCoroutine(LoadLevel1());
    ////}

    ////IEnumerator LoadLevel1()
    ////{
    ////    transitionAnim.SetTrigger("End");
    ////    yield return new WaitForSeconds(1);
    ////    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    ////    transitionAnim.SetTrigger("Start");
    ////}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.C))
    //    {
    //        NextLevel();
    //    }
    //}
}
