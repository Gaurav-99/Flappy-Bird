using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float moveSpeed = 10;
    float deadZone = -40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * Time.deltaTime * moveSpeed);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
