using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Score gc;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        gc = obj.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {
            switch (gc.level)
            {
                case 1:
                    SceneManager.LoadScene("Level1");
                    break;
                case 2:
                    SceneManager.LoadScene("Level2");
                    break;
                case 3:
                    SceneManager.LoadScene("Level3");
                    break;
            }
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
