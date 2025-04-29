using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondopiso2 : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-200, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -23.19)
        {
            Vector3 posc = transform.position;
            posc.x = 41.0501f;
            transform.position = posc;
        }
    }
}
