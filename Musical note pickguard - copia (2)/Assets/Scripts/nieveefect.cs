using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nieveefect : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(-70, -50));
        Vector3 pos = transform.position;
        pos.x= Random.Range(-9.58f, 14.5f);
        pos.z= Random.Range(-1, -2);
        transform.position = pos;
    }


    void Update()
    {
        Vector3 rbvel = rb.velocity;
        rbvel.y = -1;
        if (transform.position.y < -5.14f)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -11.43283f)
        {
            Destroy(gameObject);
        }
    }

}
