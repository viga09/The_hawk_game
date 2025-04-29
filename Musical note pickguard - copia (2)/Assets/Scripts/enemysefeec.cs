using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysefeec : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(0, 500));
        Vector3 pos = transform.position;
        pos.x = Random.Range(-9.488f, 9.78f);
        pos.z = Random.Range(-1, -2);
        transform.position = pos;
    }


    void Update()
    {
        Vector3 rbvel = rb.velocity;
        rbvel.y = -1;
        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }
}
