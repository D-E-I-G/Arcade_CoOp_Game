using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneCollision : MonoBehaviour
{
    public float radNum = 0;
    public Text radiation;

    void Start()
    {
        radiation.text = radNum.ToString("F0");
    }

    void Update()
    {
        radiation.text = radNum.ToString("F0");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blob"))
        {
            radNum++;
        }
    }
}