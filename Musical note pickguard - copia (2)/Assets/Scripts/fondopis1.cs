using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondopis1 : MonoBehaviour
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
        if (transform.position.x < -22)
        {
            Vector3 posc = transform.position;
            posc.x = 42.22002f;
            transform.position = posc;
        }
    }
}
