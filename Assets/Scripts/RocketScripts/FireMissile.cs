using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    public GameObject Missile;
    public GameObject Rocket;
    public Transform RocketDirection;

    public float MissileCooldown;
    private float time;

    float MissileSpawnRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime ;
        //c.transform.rotation.eulerAngles.x
      //  Debug.Log(Rocket.transform.rotation.eulerAngles.y);
        if (Input.GetKeyDown(KeyCode.Mouse1) && time>=MissileCooldown)
        {
           
            Vector3 SpawnPoint =  new Vector3(0, 0, 0);

            // AngleAboutY(Rocket) = MissileSpawnRotation; Quaternion.Euler(90, Rocket.transform.rotation.eulerAngles.y, 0)

            /*
            Vector3 objFwd = Rocket.forward;
            float angle = Vector3.Angle(objFwd, Vector3.forward);
            float sign = Mathf.Sign(Vector3.Cross(objFwd, Vector3.forward).y);
            MissileSpawnRotation = angle * sign;*/

            Instantiate(Missile, SpawnPoint, RocketDirection.rotation);
            time = 0;
        }

        float AngleAboutY(Transform Rocket)
        {
            Vector3 objFwd = Rocket.forward;
            float angle = Vector3.Angle(objFwd, Vector3.forward);
            float sign = Mathf.Sign(Vector3.Cross(objFwd, Vector3.forward).y);
            return angle * sign;
        }

    }
}
