using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Button botpres1;
    public Button botpres2;
    public Button botUP;
    public Button botdown;

    public float pos;
    public bool vef;
    public bool des=false;
    public int contador = 0;

    public int score;
    public int timing;
    public int combo;
    public Text tscore;
    public Text tcombo;
    public int sos = 0;
    public float time = 0;
    public float timefin = 10f;

    public GameObject ritm1;
    public GameObject ritm2;
    public GameObject ai;
    public GameObject pis;
    public GameObject tim;
    public float posex;
    PlayerButtom gc;
    // Start is called before the first frame update
    void Start()
    {
        //time=50;
        StartCoroutine(rit1());
        StartCoroutine(obsa());
        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        gc = obj.GetComponent<PlayerButtom>();
        timing = (int)timefin;
        float volumenGuardado = PlayerPrefs.GetFloat("volumenAudio", 1f);
        AudioListener.volume = volumenGuardado;
    }
    IEnumerator rit1()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.4f);
            
            int r = Random.Range(0, 100);
            if (r >= 0 && r <= 50)
            {
                GameObject rits= Instantiate(ritm1);
                posex = rits.transform.position.x;
                sos = 1;
            }
            else
            {
                GameObject rits = Instantiate(ritm2); 
                posex = rits.transform.position.x;
                sos = 2;
            }
        }
    }
    IEnumerator obsa()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.1f);

            GameObject prefab;

            int r = Random.Range(0, 100);

            if (sos == 1) // salió ritm1 → evitar ai
            {
                prefab = pis;
            }
            else if (sos == 2) // salió ritm2 → evitar pis
            {
                prefab = ai;
            }
            else
            {
                // Por si acaso aún no se generó ningún ritmo
                prefab = (r <= 50) ? ai : pis;
            }

            GameObject obs = Instantiate(prefab);

            // Asegurar que no esté muy cerca del ritmo en X
            if (Mathf.Abs(obs.transform.position.x - posex) < 1.5f)
            {
                Vector3 newPos = obs.transform.position;
                newPos.x += 1.5f;

                if (Mathf.Abs(newPos.x - posex) < 1.5f)
                    newPos.x -= 3f;

                obs.transform.position = newPos;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        tcombo.text = "Combo: " + combo;
        tscore.text = "Score: "+score;
        if (gc != null)
        {

            pos = gc.transform.position.y;
            if (contador == 2)
            {
                vef = true;
            }
            else
            {
                vef = false;
            }
            if (pos == -1.73f)
            {
                botpres1.gameObject.SetActive(true);
                botUP.gameObject.SetActive(false);
                botpres2.gameObject.SetActive(false);
                botdown.gameObject.SetActive(true);
            }
            else if (pos == -0.06f)
            {
                botpres2.gameObject.SetActive(true);
                botdown.gameObject.SetActive(false);
                botpres1.gameObject.SetActive(false);
                botUP.gameObject.SetActive(true);
            }
            Vector3 tra = transform.localScale;
            tra.x = (time * 7.378974f) / timing;
            tra.y = 0.108542f;
            Vector3 posc = transform.position;
            posc.x = (-tra.x * -1.504f) -8.37f;
            posc.y = -4.54f;
            tim.transform.localScale = tra;
            tim.transform.position = posc;
        }
        if (time > timefin)
        {
            Levelcomplete();
        }

    }

    public void GameOver()
    {

        StopAllCoroutines();
        
        StartCoroutine(end());

    }
    IEnumerator end()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
            SceneManager.LoadScene("GameOver");
            Debug.Log("end");
        }
    }
    public void Levelcomplete()
    {
        //Debug.Log("A");
        StopAllCoroutines();
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        Score gc = obj.GetComponent<Score>();
        gc.score = score;
        int hs = PlayerPrefs.GetInt("HighScore");
        if (hs < score)
        {
            SceneManager.LoadScene("Name");
        }
        else
        {
            SceneManager.LoadScene("Levelcomplete");
        }
        
    }
}
