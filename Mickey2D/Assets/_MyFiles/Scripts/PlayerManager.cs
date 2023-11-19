using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
   
    public static Vector2 lastCheckPointPos = new Vector2 (-17,-3);

    private void Awake()
    {
        
        isGameOver = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
            
        }
    }

    public void ReplayLevel()
    {
        Debug.Log("clicked");
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
        gameOverScreen.SetActive(false);
        isGameOver = false;
    }
}
