using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rit : MonoBehaviour
{
    public int contador=0;
    public bool adentro = false;
    Rigidbody2D rb;
    GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-350, 0));
        GameObject obj = GameObject.FindGameObjectWithTag("GameController");
        gc = obj.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < -9.89)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("GameController");
            GameController gc = obj.GetComponent<GameController>();
            gc.combo=0;
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            gc.contador++;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            gc.contador--;
        }
        if (gc.des == true)
        {
            Destroy(gameObject);
            gc.des = false;
        }
    }
}
