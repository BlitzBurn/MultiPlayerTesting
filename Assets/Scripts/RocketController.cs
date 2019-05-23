using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public Transform direction = null;

    public GameObject ship;
    public Rigidbody rocketRB;

    public float rocketForce;
    public float rotationSpeed;

    void Start()
    {
        rocketRB = GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
        if (this.direction != null && Input.GetKeyDown(KeyCode.Space))
        {
            rocketRB.AddForce(direction.right*rocketForce);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ship.transform.Rotate(Vector3.left*rotationSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ship.transform.Rotate(Vector3.right * rotationSpeed);
        }
    }
}
