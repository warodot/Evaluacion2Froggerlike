using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public float obstacleSpeed;
    public Vector3 dir;

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * obstacleSpeed * Time.deltaTime;
    }
}
