using System.Collections;
using UnityEngine;

public class GhostPatrol : MonoBehaviour
{
    public float patrolDistance = 2f; // Distance to move left and right from the starting position
    public float patrolSpeed = 1f; // Speed of patrol movement

    private Vector3 leftPoint, rightPoint; // Points to move to
    private Vector3 startingPosition; // Original position of the ghost

    private void Start()
    {
        startingPosition = transform.position;
        // Calculate the left and right points based on the patrol distance
        leftPoint = startingPosition + new Vector3(-patrolDistance, 0, 0);
        rightPoint = startingPosition + new Vector3(patrolDistance, 0, 0);

        // Start the patrol coroutine
        StartCoroutine(PatrolRoutine());
    }

    IEnumerator PatrolRoutine()
    {
        while (true)
        {
            // Move to the left point
            yield return MoveToTarget(leftPoint);

            // Wait for a short time
            yield return new WaitForSeconds(0.5f);

            // Move to the right point
            yield return MoveToTarget(rightPoint);

            // Wait for a short time
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator MoveToTarget(Vector3 target)
    {
        float journeyLength = Vector3.Distance(transform.position, target);
        float startTime = Time.time;

        float distanceCovered, fractionOfJourney;

        while (Vector3.Distance(transform.position, target) > 0.05f)
        {
            distanceCovered = (Time.time - startTime) * patrolSpeed;
            fractionOfJourney = distanceCovered / journeyLength;

            transform.position = Vector3.Lerp(transform.position, target, fractionOfJourney);

            yield return null;
        }

        transform.position = target; // Ensure the ghost reaches the exact target position
    }
}

