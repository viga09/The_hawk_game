using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLevel : MonoBehaviour
{
    Score gc;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        gc = obj.GetComponent<Score>(); 
        float volumenGuardado = PlayerPrefs.GetFloat("volumenAudio", 1f);
        AudioListener.volume = volumenGuardado;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lev1() 
    {
        gc.level=1;
        SceneManager.LoadScene("Level1");
    }

    /*public void lev2()
    {

        gc.level =2;
        SceneManager.LoadScene("Level2");
    }

    public void lev3()
    {

        gc.level = 3;
        SceneManager.LoadScene("Level3");
    }*/

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
