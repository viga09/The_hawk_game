using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using System;

public class config : MonoBehaviour
{
    public Slider vol;
    public float volvalue;

    public Slider bri;
    public float brilue;
    float brilloGuardado;
    Score gc;
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        gc = obj.GetComponent<Score>();
        float volumenGuardado = gc.vole;
        vol.value = volumenGuardado;
        AudioListener.volume = volumenGuardado;
        
        gc.level = 0;
        brilloGuardado = PlayerPrefs.GetFloat("brillo", 0f);
        bri.value = brilloGuardado;

    }

    // Update is called once per frame
    public void ChangeVol(float valor)
    {
        volvalue = valor;
        PlayerPrefs.SetFloat("volumenAudio", volvalue);
        gc.vole = volvalue;
        Debug.Log(gc.vole);
        AudioListener.volume = vol.value;
        PlayerPrefs.Save();
    }

    public void ChangeBri(float valor)
    {
        brilue = valor;
        PlayerPrefs.SetFloat("brillo", brilue);
        PlayerPrefs.Save();
        //bri.value = brilloGuardado;

        // Aplicar brillo
        Color c = gc.panelBrillo.color;
        c.a = bri.value;
        gc.panelBrillo.color = c;
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
