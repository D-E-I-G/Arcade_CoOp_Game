using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public string horizontalAxis;
    public string verticalAxis;

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float xRange = 9.0f;
    private float yRange = 4.5f;

    private SpriteRenderer playerSprite;

    // Start is called before the first frame update
    void Start()
    {
        playerSprite = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(horizontalAxis);
        verticalInput = Input.GetAxis(verticalAxis);

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

        //keep the sprite in the box
        if (transform.position.x < -xRange)
            {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
        if (transform.position.x > xRange)
            {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

        if (transform.position.y < -yRange)
            {
                transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
            }
        if (transform.position.y > yRange)
            {
                transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
            }

        //flip the sprite
        if (transform.position.x < 0)
        {
            playerSprite.flipX = true;
        }
        else
        {
            playerSprite.flipX = false;
        }      
    }
}
