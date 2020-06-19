using UnityEngine;

public class SpawnerBehaviour:MonoBehaviour
{
    public enum Direction { Left, Right, Up, Down};
    public Direction dir;
    public GameObject obstaclePrefab;

    public float spawnTimer = 2;
    public float speed;
    float currentTime = 9999;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > spawnTimer)
        {
            GameObject obstacle = Instantiate(obstaclePrefab, transform.position, Quaternion.identity, transform);
            obstacle.GetComponent<ObstacleBehaviour>().obstacleSpeed = speed;

            if( dir == Direction.Left)
            {
                obstacle.GetComponent<ObstacleBehaviour>().dir = Vector3.left;
            }
            else
            {
                obstacle.GetComponent<ObstacleBehaviour>().dir = Vector3.right;
            }

            currentTime = 0;
        }

    }
}
