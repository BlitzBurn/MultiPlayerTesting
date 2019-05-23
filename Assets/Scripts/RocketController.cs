using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public Transform direction = null;

    public GameObject ship;
    public Rigidbody rocketRB;
    public float RocketForce;

    void Start()
    {
        rocketRB = GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
        if (this.direction != null && Input.GetKeyDown(KeyCode.Space))
        {
            rocketRB.AddForce(direction.right*RocketForce);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {

        }
    }
}
