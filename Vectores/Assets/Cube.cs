using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    Vector3 velocity = new Vector3(-3, 2, 0);
    Vector3 acceleration = new Vector3(0, -9.8f, 0);
    
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        velocity += acceleration * Time.deltaTime;

        if(transform.position.y < -5){
            velocity.y *= -1;
        }

        if(transform.position.x < -9 || transform.position.x > 9){
            velocity.x *= -1;
        }
    }
}
