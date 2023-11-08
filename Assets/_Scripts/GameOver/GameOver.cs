using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;  // Singleton instance

    private bool isGameOver = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    public void EndGame()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            Time.timeScale = 0;  // Stops the game
     
        }
    }


}
