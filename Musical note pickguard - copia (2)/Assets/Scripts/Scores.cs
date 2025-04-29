using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scores : MonoBehaviour
{
    public Text highScoreText;
    public Text nickText; 
    /*public Text highScoreText1;
    public Text nickText1;
    public Text highScoreText2;
    public Text nickText2;*/
    // Start is called before the first frame update
    void Start()
    {
        int hs = PlayerPrefs.GetInt("HighScore");
        string nickname = PlayerPrefs.GetString("nickname");
        highScoreText.text = ""+hs;
        nickText.text = nickname;
        /*int hs1 = PlayerPrefs.GetInt("HighScore1");
        string nickname1 = PlayerPrefs.GetString("nickname1");
        highScoreText1.text = "" + hs1;
        nickText1.text = nickname1;
        int hs2 = PlayerPrefs.GetInt("HighScore2");
        string nickname2 = PlayerPrefs.GetString("nickname2");
        highScoreText2.text = "" + hs2;
        nickText2.text = nickname2;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
