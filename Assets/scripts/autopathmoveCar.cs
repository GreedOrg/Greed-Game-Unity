using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autopathmoveCar : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Car_prefab;
    public Transform[] waypoints;  // array of waypoints along the path
    public float speed = 5.0f;     // movement speed
    public float rotationSpeed = 5.0f;  // rotation speed

    private int currentWaypoint = 0;

    void Start()
    {
        StartCoroutine(MoveObject());
    }

    IEnumerator MoveObject()
    {
        while (currentWaypoint < waypoints.Length)
        {
            // Move the car towards the current waypoint
            Car_prefab.transform.position = Vector3.MoveTowards(Car_prefab.transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);

            // Orient the car towards the current waypoint
            Vector3 targetDirection = waypoints[currentWaypoint].position - Car_prefab.transform.position;
            if (targetDirection != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                Car_prefab.transform.rotation = Quaternion.Slerp(Car_prefab.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            // Move to the next waypoint if we reach the current waypoint
            if (Car_prefab.transform.position == waypoints[currentWaypoint].position)
            {
                currentWaypoint++;
            }

            yield return null;
        }
    }
}
