using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitpointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waitpoints;
    private int currentWaitpointIndex = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (Vector2.Distance(waitpoints[currentWaitpointIndex].transform.position, transform.position) < .1f)
        {
            currentWaitpointIndex++;
            if(currentWaitpointIndex >= waitpoints.Length)
            {
                currentWaitpointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waitpoints[currentWaitpointIndex].transform.position, Time.deltaTime * speed);
    }
}
