using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osbtaculo : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-350, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -8.163)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            PlayerButtom obj = col.GetComponent<PlayerButtom>();
            obj.hurt();
            Destroy(gameObject);
        }
    }
}
