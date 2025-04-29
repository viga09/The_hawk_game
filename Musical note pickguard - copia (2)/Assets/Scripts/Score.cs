using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public int score = 0;
    public int level = 0;
    public string nick = "0001";

    public Image panelBrillo;
    public float vole;

    private void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        float volumenGuardado = PlayerPrefs.GetFloat("volumenAudio", .5f);
        Debug.Log("Volumen guardado: " + volumenGuardado);
        vole=volumenGuardado;
        Color c = panelBrillo.color;
        float bri = PlayerPrefs.GetFloat("brillo", 0f);
        c.a = bri;
        panelBrillo.color = c;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnDestroy()
    {
        
    }*/
}
