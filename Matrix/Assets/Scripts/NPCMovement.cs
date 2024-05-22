using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 5f;

    private int currentWaypointIndex = 0;
    private bool movingForward = true;

    void Update()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        Transform targetWaypoint = waypoints[currentWaypointIndex];
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetWaypoint.position, step);

        if ((Vector2)transform.position == (Vector2)targetWaypoint.position)
        {
            if (movingForward)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
            else
            {
                currentWaypointIndex = (currentWaypointIndex - 1 + waypoints.Length) % waypoints.Length;
            }
        }

        if (currentWaypointIndex == waypoints.Length - 1)
        {
            movingForward = false;
        }
        else if (currentWaypointIndex == 0)
        {
            movingForward = true;
        }

        Vector2 targetDirection = ((Vector2)waypoints[currentWaypointIndex].position - (Vector2)transform.position).normalized;
        if (!movingForward)
        {
            targetDirection = -targetDirection;
        }

        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        if (targetDirection == Vector2.zero)
        {
            angle += 180f;
        }
        if (!movingForward)
        {
            angle = 0f;
        }

        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}