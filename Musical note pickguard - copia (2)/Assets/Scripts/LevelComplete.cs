using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    Score gc;
    public Text tscore;
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        gc = obj.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        tscore.text = "Score: "+ gc.score;

    }

    public void retry()
    {
        switch (gc.level)
        {
            case 1:
                SceneManager.LoadScene("Level1");
                break;
            case 2:
                //SceneManager.LoadScene("Level2");
                break;
            case 3:
                //SceneManager.LoadScene("Level3");
                break;
        }
    }
    public void continuar()
    {
            /*int hs;
            switch (gc.level)
            {
                case 1:
                hs= PlayerPrefs.GetInt("HighScore");
                if ((int)gc.score > hs)
                {
                    PlayerPrefs.SetInt("HighScore", (int)gc.score);
                    PlayerPrefs.SetString("nickname", gc.nick);
                }   
                break;
                /*case 2:
                hs = PlayerPrefs.GetInt("HighScore1");
                if ((int)gc.score > hs)
                {
                    PlayerPrefs.SetInt("HighScore1", (int)gc.score);
                    PlayerPrefs.SetString("nickname1", gc.nick);
                }
                break;
                case 3:
                hs = PlayerPrefs.GetInt("HighScore2");
                if ((int)gc.score > hs)
                {
                    PlayerPrefs.SetInt("HighScore2", (int)gc.score);
                    PlayerPrefs.SetString("nickname2", gc.nick);
                }
                break;
            }*/
        gc.score = 0;
        SceneManager.LoadScene("Menu");
    }
}
