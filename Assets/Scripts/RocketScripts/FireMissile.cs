using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    public GameObject Missile;
    public GameObject Rocket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
           
            Vector3 SpawnPoint =  new Vector3(0, 0, 0);

            Instantiate(Missile, SpawnPoint, Rocket.transform.rotation);
        }

    }
}
