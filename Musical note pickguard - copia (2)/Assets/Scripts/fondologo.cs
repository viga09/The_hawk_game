using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondologo : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-180, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -17)
        {
            Vector3 posc = transform.position;
            posc.x = 18.24799f;
            transform.position = posc;
        }
    }
}
