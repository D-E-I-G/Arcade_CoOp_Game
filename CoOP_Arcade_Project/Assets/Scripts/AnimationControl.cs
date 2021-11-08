using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public string horizontalAxis;
    public string verticalAxis;

    public float horizontalInput;
    public float verticalInput;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(horizontalAxis);
        verticalInput = Input.GetAxis(verticalAxis);

        if ((horizontalInput != 0) | (verticalInput !=0))
        {
            anim.SetBool("moving", true);
        }
        else
        {
            anim.SetBool("moving", false);
        }
    }
}
