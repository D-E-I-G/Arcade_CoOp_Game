using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool bulletPoolInstanse;

    public GameObject pooledBullet;
    public GameObject pooledBigBullet;

    private bool notEnopughBulletsinPool = true;

    private List<GameObject> bullets;

    private void Awake()
    {
        bulletPoolInstanse = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
    }

    public GameObject GetBullet()
    {

        if (notEnopughBulletsinPool)
        {
            GameObject bul = Instantiate(pooledBullet);
            bul.SetActive(false);
            bullets.Add(bul);
            return bul;
        }

        return null;
    }

    public GameObject GetBigBullet()
    {

        if (notEnopughBulletsinPool)
        {
            GameObject bull = Instantiate(pooledBigBullet);
            bull.SetActive(false);
            bullets.Add(bull);
            return bull;
        }

        return null;
    }
}
