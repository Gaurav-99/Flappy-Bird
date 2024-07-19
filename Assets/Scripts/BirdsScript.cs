using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D birdRigidBody;
    float speed = 15.0f;
    public LogicScript logic;
    bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        //birdRigidBody.velocity = Vector2.up * 10;
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidBody.velocity = Vector2.up * speed;
        }
        
    }

  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
