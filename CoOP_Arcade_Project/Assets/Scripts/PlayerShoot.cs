using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public KeyCode shoot;
    public GameObject bulletPrefab;
    public GameObject gun;
    public GameObject monster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //look at monster
        gun.transform.LookAt(monster.transform);

        //shoot GUN
        if (Input.GetKeyDown(shoot))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, bulletPrefab.transform.rotation.y, gun.transform.rotation.z));
            Debug.Log(transform.rotation.x);
        }
    }
}