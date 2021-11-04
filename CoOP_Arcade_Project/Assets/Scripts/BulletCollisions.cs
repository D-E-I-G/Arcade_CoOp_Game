using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerOne")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.name == "PlayerTwo")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.name == "Bullet(Clone)")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
