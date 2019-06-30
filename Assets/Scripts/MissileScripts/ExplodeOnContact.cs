using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnContact : MonoBehaviour
{

    public GameObject Missile;

    void OnTriggerEnter(Collider other)
    {
       // Destroy(gameObject);
            //Debug.Log("kaboom");

        
        
    }

    public void DetonateMissile()
    {
        Destroy(gameObject);
        Debug.Log("DetonateMissileCalled");
    }


}
