using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneCollision : MonoBehaviour
{
    public int a;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blob"))
        {
            a++;
        }
    }
}