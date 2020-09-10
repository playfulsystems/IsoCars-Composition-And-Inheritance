using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    

    // Update is called once per frame
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Move()
    {
        // face direction
        transform.rotation = Quaternion.LookRotation(direction);

        // set speed
        GetComponent<Rigidbody>().velocity = direction.normalized * speed;
    }

    public void SetSpeed(float newSpeed) {
        speed = newSpeed;
        Move();
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
        Move();
    }

    // note that this includes all cameras, so if you have your scene tab open, it won't delete your objects
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
