using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efect : MonoBehaviour
{
    public GameObject part;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(particule());
    }
    IEnumerator particule()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            Instantiate(part);
        }
    }

            // Update is called once per frame
            void Update()
    {
        
    }
}
