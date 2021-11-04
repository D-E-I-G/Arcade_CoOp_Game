using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneSound : MonoBehaviour
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
        if(Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.D))
        {
            if(!running.isPlaying)
            running.Play();
        }
        else
        {
            running.Stop();
        }
    }
}
