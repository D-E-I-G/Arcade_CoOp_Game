using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool bulletPoolInstanse;

    [SerializeField]
    private GameObject pooledBullet;
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
}
