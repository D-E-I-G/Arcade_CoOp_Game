using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 8.0f;
    private float tooFar = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

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
}
