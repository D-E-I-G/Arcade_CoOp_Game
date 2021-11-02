using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public KeyCode shoot;
    public GameObject bulletPrefab;
    public GameObject gun;
    public GameObject monster;

    // Update is called once per frame
    void Update()
    {
        //look at monster
        gun.transform.LookAt(monster.transform);

        //shoot GUN
        if (Input.GetKeyDown(shoot))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Debug.Log(transform.rotation.x);
        }
    }
}