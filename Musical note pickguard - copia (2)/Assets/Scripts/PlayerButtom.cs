using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerButtom : MonoBehaviour
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
            if (pos.y == -1.73f)
            {
                push();
            }
            else
            {
                up();
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (pos.y == -0.06f)
            {
                push();
            }
            else
            {
                Down();
            }
            

        }
    }

    public void hurt()
    {
        Vector3 pos = transform.position;
        Instantiate(dead, pos, Quaternion.identity); GameObject obj = GameObject.FindGameObjectWithTag("GameController");
        GameController gc = obj.GetComponent<GameController>();
        gc.GameOver();
        Destroy(gameObject);

    }
    public void up()
    {
        pos.y = -1.73f;
        transform.position = pos;
    }

    public void Down()
    {
        pos.y = -0.06f;//-1.73
        transform.position = pos;
    }

    public void push()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("GameController");
        GameController gc = obj.GetComponent<GameController>();
        if (gc.vef == true)
        {
            if (gc.combo < 5)
            {
                gc.combo++;
                gc.score++;
            }
            if (gc.combo>=5)
            {
                gc.combo++;
                gc.score += 5;
            }
            if (gc.combo >= 10)
            {
                gc.combo++;
                gc.score += gc.combo;
            }
            gc.des = true;
        }

    }
}
