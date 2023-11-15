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
        ghostAnimator.SetBool("Appear", false);
        GetComponent<SpriteRenderer>().enabled = false;

      
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

    public void FinishAppearing()
    {
        ghostAnimator.SetBool("Appear", false);
    }
}
