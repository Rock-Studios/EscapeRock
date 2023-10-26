using UnityEngine;

public class VisibilityGhost : MonoBehaviour
{
    public float detectionRadius = 5f;
    public GameObject player;
    private Animator ghostAnimator;
    private bool hasAppeared = false;

    private void Start()
    {
        ghostAnimator = GetComponent<Animator>();
        ghostAnimator.SetBool("Appear", false); // Set initial state
        GetComponent<SpriteRenderer>().enabled = false;

        // If player is not assigned, try to find it by tag (assuming the player object has the tag "Player")
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            if (player == null)
            {
                Debug.LogError("Player object not found! Please ensure the player has the tag 'Player'.");
            }
        }
    }

    private void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

        if (!hasAppeared && distanceToPlayer <= detectionRadius)
        {
            hasAppeared = true;
            GetComponent<SpriteRenderer>().enabled = true;
            ghostAnimator.SetBool("Appear", true);
        }
    }

    // This function can be called at the end of the appearance animation
    public void FinishAppearing()
    {
        ghostAnimator.SetBool("Appear", false);
    }
}
