using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }

    private void Update()
    {
        
       
    }
}
