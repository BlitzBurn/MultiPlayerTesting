using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public static float HealtPoints;
    public int TestVariableDeleteLater;

    

    void Start()
    {
        
    }

  
    void Update()
    {
               
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "MissileTag")
        {
            Debug.Log("Missile hit");

            //var ExplodeOnContact : DetonateMissile = collision

            ExplodeOnContact explodeScript = collision.gameObject.GetComponent<ExplodeOnContact>();
            explodeScript.DetonateMissile();
        }
        
    }


     

}
