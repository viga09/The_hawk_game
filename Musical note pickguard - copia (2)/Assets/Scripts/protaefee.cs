using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protaefee : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(0, -500));
        Vector3 pos = transform.position;
        pos.x = Random.Range(-9.406f, 9.25f);
        pos.z = Random.Range(-1, -2);
        transform.position = pos;
    }


    void Update()
    {
        Vector3 rbvel = rb.velocity;
        rbvel.y = -1;
        if (transform.position.y > 7f)
        {
            Destroy(gameObject);
        }
    }
}
