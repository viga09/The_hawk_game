using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject dead;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            pos.y = -1.97f;
            transform.position = pos;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            pos.y = -0.13f;
            transform.position = pos;
            
        }
    }

    public void hurt()
    {
        Vector3 pos = transform.position;
        Destroy(gameObject);
        Instantiate(dead, pos, Quaternion.identity);
        GameObject obj = GameObject.FindGameObjectWithTag("GameController");
        GameController gc = obj.GetComponent<GameController>();
        gc.GameOver();
    }
}
