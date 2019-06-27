using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    public GameObject Missile;
    public GameObject Rocket;

    public float MissileCooldown;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime ;
        //c.transform.rotation.eulerAngles.x
        Debug.Log(Rocket.transform.rotation.eulerAngles.y);
        if (Input.GetKeyDown(KeyCode.Mouse1) && time>=MissileCooldown)
        {
           
            Vector3 SpawnPoint =  new Vector3(0, 0, 0);

            Instantiate(Missile, SpawnPoint, Quaternion.Euler(90, Rocket.transform.rotation.eulerAngles.y, 0));
            time = 0;
        }

    }
}
