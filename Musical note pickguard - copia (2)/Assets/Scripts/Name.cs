using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReadStringg(string s)
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        Score gc = obj.GetComponent<Score>();
        gc.nick = s;
        PlayerPrefs.SetInt("HighScore", (int)gc.score);
        PlayerPrefs.SetString("nickname", gc.nick);
        SceneManager.LoadScene("Menu");
    }
}
