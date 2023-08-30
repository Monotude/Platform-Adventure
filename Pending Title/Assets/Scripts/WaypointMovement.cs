using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentIndex = 0;
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, waypoints[currentIndex].transform.position) < .05f)
        {
            currentIndex++;
            if(currentIndex >= waypoints.Length)
            {
                currentIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentIndex].transform.position, speed * Time.deltaTime);
    }
}
