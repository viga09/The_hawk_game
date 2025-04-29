using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectmenu : MonoBehaviour
{
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public GameObject part5;
    public GameObject part6;
    public GameObject part7;
    public GameObject part8;
    public GameObject part9;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(particule());

        StartCoroutine(particule2());

    }
    IEnumerator particule()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            int pes= Random.Range(1,3);
            switch (pes)
            {
                case 1:
                    Instantiate(part1);
                    break;
                case 2:
                    Instantiate(part2);
                    break;
                case 3:
                    Instantiate(part3);
                    break;
            }
        }
    }
    IEnumerator particule2()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            int pes = Random.Range(4, 9);
            switch (pes)
            {
                case 4:
                    Instantiate(part4);
                    break;
                case 5:
                    Instantiate(part5);
                    break;
                case 6:
                    Instantiate(part6);
                    break;
                case 7:
                    Instantiate(part7);
                    break;
                case 8:
                    Instantiate(part8);
                    break;
                case 9:
                    Instantiate(part9);
                    break;
            }
        }
    }

}
