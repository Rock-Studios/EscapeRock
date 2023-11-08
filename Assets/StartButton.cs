using UnityEngine;

public class StartButton : MonoBehaviour
{
    public RollingBoulder rollingBoulder; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TaskOnClick();
        }
    }

    void TaskOnClick()
    {
        rollingBoulder.StartRolling();
    }
}