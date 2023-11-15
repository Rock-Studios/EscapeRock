using UnityEngine;
using UnityEngine.SceneManagement;
public class RollingBoulder : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody2D rb;
    private bool isRolling = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
        rb.velocity = Vector2.zero;
    }

    private void Update()
    {
  
        if (isRolling)
        {
            rb.velocity = new Vector2(+speed, 0);
        }
    }

    public void StartRolling()
    {
        isRolling = true; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player hit by boulder");
       
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}