using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MenuController : MonoBehaviour
{
    Score gc;
    // Start is called before the first frame update
    void Start()
    {
        float bri = PlayerPrefs.GetFloat("brillo", 1f);
        float vol = PlayerPrefs.GetFloat("volumenAudio", 1f);
        AudioListener.volume = vol;
        PlayerPrefs.SetFloat("volumenAudio", 0.15f);
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        if(obj != null)
        {
            gc = obj.GetComponent<Score>();
            gc.level = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playclick()
    {
        SceneManager.LoadScene("Levels");
    }

    public void playconfig()
    {
        SceneManager.LoadScene("Opciones");
    }
    public void score()
    {
        SceneManager.LoadScene("Scores");
    }
    public void quitlick()
    {
        Application.Quit();
    }
}
