using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public KeyCode shoot;
    public GameObject bulletPrefab;
    public GameObject gun;
    public GameObject monster;

    private AudioSource shot;

    private bool hasShot;

    private void Awake()
    {
        hasShot = false;
        shot = GetComponent<AudioSource>();
    }

    IEnumerator Pew ()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        shot.Play();
        yield return new WaitForSeconds(1.75f);
        hasShot = false;
    }

    // Update is called once per frame
    void Update()
    {
        //look at monster
        gun.transform.LookAt(monster.transform);

        //shoot GUN
        if (Input.GetKeyDown(shoot) && (!hasShot))
        {
            hasShot = true;
            StartCoroutine(Pew());
        }
    }
}