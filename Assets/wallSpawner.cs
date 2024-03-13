using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSpawner : MonoBehaviour
{
    public GameObject wall;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        createWall();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            createWall();
            timer = 0;
        }
    }
    void createWall()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(wall, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
