using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneCollision : MonoBehaviour
{
    public static float radNum1 = 0;
    public Text radiation;

    void Start()
    {
        radiation.text = radNum1.ToString("F0");
    }

    void Update()
    {
        radiation.text = radNum1.ToString("F0");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blob"))
        {
            radNum1++;
        }
    }
}