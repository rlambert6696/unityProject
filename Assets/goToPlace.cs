using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToPlace : MonoBehaviour
{
    Vector2 randomPosition;
    public float xRange = 10;
    public float yRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime);

        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(0 - yRange, 0 + yRange);

        randomPosition = new Vector2(xPosition, yPosition);

        transform.position = randomPosition;
    }
}
