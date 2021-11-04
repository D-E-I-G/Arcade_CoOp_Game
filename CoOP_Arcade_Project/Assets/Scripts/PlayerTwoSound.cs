using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoSound : MonoBehaviour
{
    private AudioSource running;

    // Start is called before the first frame update
    void Start()
    {
        running = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.RightArrow))
        {
            if (!running.isPlaying)
                running.Play();
        }
        else
        {
            running.Stop();
        }
    }
}
