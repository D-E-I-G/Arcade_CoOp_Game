using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoCollision : MonoBehaviour
{
    public int b;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blob"))
        {
            b += 1;
        }
    }
}
