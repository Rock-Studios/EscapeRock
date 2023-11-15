using System.Collections;
using UnityEngine;

public class GhostPatrol : MonoBehaviour
{
    public float patrolDistance = 2f; 
    public float patrolSpeed = 0.5f; 

    private Vector3 leftPoint, rightPoint; 
    private Vector3 startingPosition; 

    private void Start()
    {
        startingPosition = transform.position;
        // Calculate the left and right points based on the patrol distance
        leftPoint = startingPosition + new Vector3(-patrolDistance, 0, 0);
        rightPoint = startingPosition + new Vector3(patrolDistance, 0, 0);

  
        StartCoroutine(PatrolRoutine());
    }

    IEnumerator PatrolRoutine()
    {
        while (true)
        {
            yield return MoveToTarget(leftPoint);

         
            yield return new WaitForSeconds(0.5f);

            yield return MoveToTarget(rightPoint);

            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator MoveToTarget(Vector3 target)
    {
        float journeyLength = Vector3.Distance(transform.position, target);
        float startTime = Time.time;

        float distanceCovered, fractionOfJourney;

        while (Vector3.Distance(transform.position, target) > 0.15f)
        {
            distanceCovered = (Time.time - startTime) * patrolSpeed;
            fractionOfJourney = distanceCovered / journeyLength;

            transform.position = Vector3.Lerp(transform.position, target, fractionOfJourney);

            yield return null;
        }

        transform.position = target; // Ensure the ghost reaches the exact target position
    }
}

