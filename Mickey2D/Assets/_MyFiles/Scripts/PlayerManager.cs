using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public AudioSource steamboat;
    public static Vector2 lastCheckPointPos = new Vector2 (-17,-3);

    private void Awake()
    {     
        isGameOver = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }


    // Start is called before the first frame update
    void Start()
    {
        steamboat.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
            steamboat.Stop();
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
