using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 moveDirection;
    private float moveSpeed;
    private float tooFar = 10;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        if (transform.position.x > tooFar)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > tooFar)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -tooFar)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -tooFar)
        {
            Destroy(gameObject);
        }
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }
}
